using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace TraderDev
{
    public partial class Form1 : Form
    {
        private Timer priceUpdateTimer;
        private Random random = new Random();
        private double initialPrice = 100.0;
        private string priceSavePath = "./historic_prices.json";
        private string walletSavePath = "./wallet.json";

        private List<PricePoint> priceHistoryAll = new List<PricePoint>();
        private int currentViewLength = 10;

        // Price simulation vars
        private double velocity = 0;
        private const double randomFactor = 0.5;
        private const double decay = 0.9;
        private const double timeStep = 1.0;

        // Session tracking
        private double sessionStartPrice;

        // Trading wallet
        private Wallet wallet;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            LoadPriceHistory();
            LoadWallet();

            sessionStartPrice = priceHistoryAll.Last().Price;

            InitializeTimer();
            UpdateTradingLabels();
            UpdateWalletAnalyticsLabel();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();

            Series series = new Series("PriceSeries")
            {
                ChartType = SeriesChartType.Spline
            };

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Price";
        }

        private void InitializeTimer()
        {
            priceUpdateTimer = new Timer();
            priceUpdateTimer.Interval = 1;
            priceUpdateTimer.Tick += PriceUpdateTimer_Tick;
            priceUpdateTimer.Start();
        }

        private void PriceUpdateTimer_Tick(object sender, EventArgs e)
        {
            double lastPrice = priceHistoryAll.Count > 0 ? priceHistoryAll[priceHistoryAll.Count - 1].Price : initialPrice;
            double newPrice = GenerateRealisticPrice(lastPrice);
            bool isUp = newPrice >= lastPrice;

            priceHistoryAll.Add(new PricePoint { Price = newPrice, IsUp = isUp });

            SavePriceHistory();
            UpdateChart();
            UpdateLabels();
            UpdateWalletAnalyticsLabel();
        }

        private double GenerateRealisticPrice(double lastPrice)
        {
            velocity *= decay;

            double randomInfluence = (random.NextDouble() * 2 - 1) * randomFactor;
            velocity += randomInfluence * timeStep;

            double newPrice = lastPrice + velocity;
            if (newPrice < 0.1) newPrice = 0.1;

            return newPrice;
        }

        private void UpdateChart()
        {
            List<PricePoint> viewData = priceHistoryAll.Skip(Math.Max(0, priceHistoryAll.Count - currentViewLength)).ToList();

            var series = chart1.Series["PriceSeries"];
            series.Points.Clear();

            for (int i = 0; i < viewData.Count; i++)
            {
                int index = series.Points.AddXY(i + 1, viewData[i].Price);
                series.Points[index].Color = viewData[i].IsUp ? Color.Green : Color.Red;
            }

            // Dynamic Y-axis scaling based on view length
            if (viewData.Count > 0)
            {
                double currentPrice = viewData.Last().Price;
                double minPrice = viewData.Min(p => p.Price);
                double maxPrice = viewData.Max(p => p.Price);
                double priceRange = maxPrice - minPrice;

                // Default padding as a percentage of the range
                double padding = priceRange * 0.1; // 10% padding
                if (padding == 0) padding = currentPrice * 0.1; // Fallback for flat data

                // Adjust Y-axis scale based on view length
                double yMin, yMax, interval;

                if (currentViewLength <= 30)
                {
                    // For short view lengths (10 or 30), zoom in tightly around current price
                    double range = currentViewLength == 10 ? 1.0 : 5.0; // Narrower for 10, wider for 30
                    yMin = Math.Floor(currentPrice - range);
                    yMax = Math.Ceiling(currentPrice + range);
                    interval = currentViewLength == 10 ? 0.1 : 0.5; // Finer ticks for 10, coarser for 30
                }
                else
                {
                    // For longer view lengths, show broader range based on data
                    yMin = Math.Floor(minPrice - padding);
                    yMax = Math.Ceiling(maxPrice + padding);
                    interval = Math.Ceiling((yMax - yMin) / 10); // Aim for ~10 major ticks
                    if (currentViewLength >= 1000)
                    {
                        // For 1000 or more, use increments of 10
                        interval = 10;
                        yMin = Math.Floor(yMin / 10) * 10;
                        yMax = Math.Ceiling(yMax / 10) * 10;
                    }
                }

                // Ensure non-negative prices
                if (yMin < 0) yMin = 0;

                // Apply Y-axis settings
                chart1.ChartAreas[0].AxisY.Minimum = yMin;
                chart1.ChartAreas[0].AxisY.Maximum = yMax;
                chart1.ChartAreas[0].AxisY.Interval = interval;

                // Optional: Set X-axis interval for better readability
                chart1.ChartAreas[0].AxisX.Interval = Math.Max(1, currentViewLength / 10);
            }
        }

        private void SavePriceHistory()
        {
            try
            {
                File.WriteAllText(priceSavePath, JsonConvert.SerializeObject(priceHistoryAll, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save price data: " + ex.Message);
            }
        }

        private void LoadPriceHistory()
        {
            try
            {
                if (File.Exists(priceSavePath))
                {
                    string json = File.ReadAllText(priceSavePath);
                    priceHistoryAll = JsonConvert.DeserializeObject<List<PricePoint>>(json);
                }

                if (priceHistoryAll == null || priceHistoryAll.Count == 0)
                {
                    priceHistoryAll = new List<PricePoint> { new PricePoint { Price = initialPrice, IsUp = true } };
                }
            }
            catch
            {
                priceHistoryAll = new List<PricePoint> { new PricePoint { Price = initialPrice, IsUp = true } };
            }
        }

        private void SaveWallet()
        {
            try
            {
                File.WriteAllText(walletSavePath, JsonConvert.SerializeObject(wallet, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save wallet data: " + ex.Message);
            }
        }

        private void LoadWallet()
        {
            try
            {
                if (File.Exists(walletSavePath))
                {
                    string json = File.ReadAllText(walletSavePath);
                    wallet = JsonConvert.DeserializeObject<Wallet>(json);
                }

                if (wallet == null)
                {
                    wallet = new Wallet()
                    {
                        CashBalance = 100000.0,
                        StockHoldings = 0,
                        InitialCash = 100000.0
                    };
                }
            }
            catch
            {
                wallet = new Wallet()
                {
                    CashBalance = 100000.0,
                    StockHoldings = 0,
                    InitialCash = 100000.0
                };
            }
        }

        private void UpdateLabels()
        {
            if (priceHistoryAll.Count == 0) return;

            var currentPrice = priceHistoryAll.Last().Price;
            var firstPrice = priceHistoryAll[0].Price;

            lbl_current_price.Text = $"{currentPrice:F2}";

            double percentChange = ((currentPrice - firstPrice) / firstPrice) * 100.0;
            lbl_analytics_from_last_10th_price.Text = $"Since start: {percentChange:+0.00;-0.00;0.00}%";

            if (currentPrice > firstPrice)
            {
                lbl_current_price.ForeColor = Color.Green;
                lbl_analytics_from_last_10th_price.ForeColor = Color.Green;
            }
            else if (currentPrice < firstPrice)
            {
                lbl_current_price.ForeColor = Color.Red;
                lbl_analytics_from_last_10th_price.ForeColor = Color.Red;
            }
            else
            {
                lbl_current_price.ForeColor = Color.Black;
                lbl_analytics_from_last_10th_price.ForeColor = Color.Black;
            }

            double priceDiffFromSessionStart = currentPrice - sessionStartPrice;
            string sign = priceDiffFromSessionStart >= 0 ? "+" : "-";
            lbl_price_change_from_the_start_of_session.Text = $"Session Change: {sign}{Math.Abs(priceDiffFromSessionStart):F2}";

            if (priceDiffFromSessionStart > 0)
                lbl_price_change_from_the_start_of_session.ForeColor = Color.Green;
            else if (priceDiffFromSessionStart < 0)
                lbl_price_change_from_the_start_of_session.ForeColor = Color.Red;
            else
                lbl_price_change_from_the_start_of_session.ForeColor = Color.Black;
        }

        private double previousStockValue = 0;

        private void UpdateTradingLabels()
        {
            double currentPrice = GetCurrentPrice();  // Assumes this method returns the latest price
            int stocks = wallet.StockHoldings;
            double stockValue = stocks * currentPrice;

            lbl_cash_balance.Text = $"Cash: ${wallet.CashBalance:F2}";

            lbl_stock_holdings.Text = $"Stocks: {stocks} (${stockValue:F2})";

            // Color the label based on how stock value changed compared to last update
            if (stockValue > previousStockValue)
                lbl_stock_holdings.ForeColor = Color.Green;
            else if (stockValue < previousStockValue)
                lbl_stock_holdings.ForeColor = Color.Red;
            else
                lbl_stock_holdings.ForeColor = Color.Black;

            previousStockValue = stockValue;
        }


        private void UpdateWalletAnalyticsLabel()
        {
            double currentPrice = GetCurrentPrice();
            // Current portfolio value = cash + stocks * currentPrice
            double currentPortfolioValue = wallet.CashBalance + wallet.StockHoldings * currentPrice;

            // Profit/Loss = currentPortfolioValue - initial wallet value (cash + holdings value at start)
            double initialPortfolioValue = wallet.InitialCash; // holdings initially 0 assumed

            double profitLoss = currentPortfolioValue - initialPortfolioValue;
            double profitLossPercent = (profitLoss / initialPortfolioValue) * 100.0;

            lbl_wallet_analytics.Text = $"P/L: {profitLoss:+0.00;-0.00;0.00} (${profitLossPercent:+0.00;-0.00;0.00}%)";

            if (profitLoss > 0)
                lbl_wallet_analytics.ForeColor = Color.Green;
            else if (profitLoss < 0)
                lbl_wallet_analytics.ForeColor = Color.Red;
            else
                lbl_wallet_analytics.ForeColor = Color.Black;
        }

        // Helper method to get current price
        private double GetCurrentPrice()
        {
            return priceHistoryAll.Count > 0 ? priceHistoryAll.Last().Price : initialPrice;
        }

        // Buy stock method
        private void BuyStock(int quantity)
        {
            double price = GetCurrentPrice();
            double cost = price * quantity;

            if (cost > wallet.CashBalance)
            {
                MessageBox.Show($"Not enough cash to buy {quantity} stocks.");
                return;
            }

            wallet.CashBalance -= cost;
            wallet.StockHoldings += quantity;

            SaveWallet();
            UpdateTradingLabels();
            UpdateWalletAnalyticsLabel();
        }

        // Sell stock method
        private void SellStock(int quantity)
        {
            if (quantity > wallet.StockHoldings)
            {
                MessageBox.Show($"Not enough stocks to sell {quantity}.");
                return;
            }

            double price = GetCurrentPrice();
            double revenue = price * quantity;

            wallet.CashBalance += revenue;
            wallet.StockHoldings -= quantity;

            SaveWallet();
            UpdateTradingLabels();
            UpdateWalletAnalyticsLabel();
        }

        // Buy/Sell buttons

        private void btn_but_1_Click(object sender, EventArgs e) => BuyStock(1);
        private void btn_sell_1_Click(object sender, EventArgs e) => SellStock(1);
        private void btn_but_10_Click(object sender, EventArgs e) => BuyStock(10);
        private void btn_sell_10_Click(object sender, EventArgs e) => SellStock(10);
        private void btn_but_100_Click(object sender, EventArgs e) => BuyStock(100);
        private void btn_sell_100_Click(object sender, EventArgs e) => SellStock(100);
        private void btn_but_1000_Click(object sender, EventArgs e) => BuyStock(1000);
        private void btn_sell_1000_Click(object sender, EventArgs e) => SellStock(1000);
        private void btn_but_10000_Click(object sender, EventArgs e) => BuyStock(10000);
        private void btn_sell_10000_Click(object sender, EventArgs e) => SellStock(10000);

        // View-length buttons (existing)...

        private void btn_show_last_10_prices_Click(object sender, EventArgs e) => SetViewLength(10);
        private void btn_show_last_30_prices_Click(object sender, EventArgs e) => SetViewLength(30);
        private void btn_show_last_100_prices_Click(object sender, EventArgs e) => SetViewLength(100);
        private void btn_show_last_500_prices_Click(object sender, EventArgs e) => SetViewLength(500);
        private void btn_show_last_1000_prices_Click(object sender, EventArgs e) => SetViewLength(1000);
        private void btn_show_last_2000_prices_Click(object sender, EventArgs e) => SetViewLength(2000);
        private void btn_show_last_10000_prices_Click(object sender, EventArgs e) => SetViewLength(10000);

        private void SetViewLength(int length)
        {
            currentViewLength = length;
            UpdateChart();
        }
    }

    public class PricePoint
    {
        public double Price { get; set; }
        public bool IsUp { get; set; }
    }

    public class Wallet
    {
        public double CashBalance { get; set; }
        public int StockHoldings { get; set; }

        // Used to calculate profit/loss vs start
        public double InitialCash { get; set; }
    }
}