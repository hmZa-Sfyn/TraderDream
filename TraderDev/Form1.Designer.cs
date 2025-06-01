namespace TraderDev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_wallet_analytics = new System.Windows.Forms.Label();
            this.lbl_stock_holdings = new System.Windows.Forms.Label();
            this.lbl_cash_balance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_sell_10000 = new System.Windows.Forms.Button();
            this.btn_sell_1000 = new System.Windows.Forms.Button();
            this.btn_sell_100 = new System.Windows.Forms.Button();
            this.btn_sell_10 = new System.Windows.Forms.Button();
            this.btn_sell_1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_but_10000 = new System.Windows.Forms.Button();
            this.btn_but_1000 = new System.Windows.Forms.Button();
            this.btn_but_100 = new System.Windows.Forms.Button();
            this.btn_but_10 = new System.Windows.Forms.Button();
            this.btn_but_1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_price_change_from_the_start_of_session = new System.Windows.Forms.Label();
            this.lbl_analytics_from_last_10th_price = new System.Windows.Forms.Label();
            this.lbl_current_price = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_show_last_10_prices = new System.Windows.Forms.Button();
            this.btn_show_last_30_prices = new System.Windows.Forms.Button();
            this.btn_show_last_100_prices = new System.Windows.Forms.Button();
            this.btn_show_last_500_prices = new System.Windows.Forms.Button();
            this.btn_show_last_1000_prices = new System.Windows.Forms.Button();
            this.btn_show_last_2000_prices = new System.Windows.Forms.Button();
            this.btn_show_last_10000_prices = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_wallet_analytics);
            this.panel1.Controls.Add(this.lbl_stock_holdings);
            this.panel1.Controls.Add(this.lbl_cash_balance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 672);
            this.panel1.TabIndex = 0;
            // 
            // lbl_wallet_analytics
            // 
            this.lbl_wallet_analytics.AutoSize = true;
            this.lbl_wallet_analytics.Location = new System.Drawing.Point(12, 144);
            this.lbl_wallet_analytics.Name = "lbl_wallet_analytics";
            this.lbl_wallet_analytics.Size = new System.Drawing.Size(49, 15);
            this.lbl_wallet_analytics.TabIndex = 2;
            this.lbl_wallet_analytics.Text = "label2";
            // 
            // lbl_stock_holdings
            // 
            this.lbl_stock_holdings.AutoSize = true;
            this.lbl_stock_holdings.Location = new System.Drawing.Point(12, 96);
            this.lbl_stock_holdings.Name = "lbl_stock_holdings";
            this.lbl_stock_holdings.Size = new System.Drawing.Size(49, 15);
            this.lbl_stock_holdings.TabIndex = 1;
            this.lbl_stock_holdings.Text = "label2";
            // 
            // lbl_cash_balance
            // 
            this.lbl_cash_balance.AutoSize = true;
            this.lbl_cash_balance.Location = new System.Drawing.Point(12, 48);
            this.lbl_cash_balance.Name = "lbl_cash_balance";
            this.lbl_cash_balance.Size = new System.Drawing.Size(49, 15);
            this.lbl_cash_balance.TabIndex = 0;
            this.lbl_cash_balance.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_show_last_10000_prices);
            this.panel2.Controls.Add(this.btn_show_last_2000_prices);
            this.panel2.Controls.Add(this.btn_show_last_1000_prices);
            this.panel2.Controls.Add(this.btn_show_last_500_prices);
            this.panel2.Controls.Add(this.btn_show_last_100_prices);
            this.panel2.Controls.Add(this.btn_show_last_30_prices);
            this.panel2.Controls.Add(this.btn_show_last_10_prices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(858, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 672);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(214, 519);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 153);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(329, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_sell_10000);
            this.panel5.Controls.Add(this.btn_sell_1000);
            this.panel5.Controls.Add(this.btn_sell_100);
            this.panel5.Controls.Add(this.btn_sell_10);
            this.panel5.Controls.Add(this.btn_sell_1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 46);
            this.panel5.TabIndex = 1;
            // 
            // btn_sell_10000
            // 
            this.btn_sell_10000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sell_10000.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sell_10000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_10000.Location = new System.Drawing.Point(31, 0);
            this.btn_sell_10000.Name = "btn_sell_10000";
            this.btn_sell_10000.Size = new System.Drawing.Size(65, 46);
            this.btn_sell_10000.TabIndex = 5;
            this.btn_sell_10000.Text = "-10000";
            this.btn_sell_10000.UseVisualStyleBackColor = false;
            this.btn_sell_10000.Click += new System.EventHandler(this.btn_sell_10000_Click);
            // 
            // btn_sell_1000
            // 
            this.btn_sell_1000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sell_1000.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sell_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_1000.Location = new System.Drawing.Point(96, 0);
            this.btn_sell_1000.Name = "btn_sell_1000";
            this.btn_sell_1000.Size = new System.Drawing.Size(60, 46);
            this.btn_sell_1000.TabIndex = 4;
            this.btn_sell_1000.Text = "-1000";
            this.btn_sell_1000.UseVisualStyleBackColor = false;
            this.btn_sell_1000.Click += new System.EventHandler(this.btn_sell_1000_Click);
            // 
            // btn_sell_100
            // 
            this.btn_sell_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sell_100.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sell_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_100.Location = new System.Drawing.Point(156, 0);
            this.btn_sell_100.Name = "btn_sell_100";
            this.btn_sell_100.Size = new System.Drawing.Size(51, 46);
            this.btn_sell_100.TabIndex = 3;
            this.btn_sell_100.Text = "-100";
            this.btn_sell_100.UseVisualStyleBackColor = false;
            this.btn_sell_100.Click += new System.EventHandler(this.btn_sell_100_Click);
            // 
            // btn_sell_10
            // 
            this.btn_sell_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sell_10.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sell_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_10.Location = new System.Drawing.Point(207, 0);
            this.btn_sell_10.Name = "btn_sell_10";
            this.btn_sell_10.Size = new System.Drawing.Size(51, 46);
            this.btn_sell_10.TabIndex = 2;
            this.btn_sell_10.Text = "-10";
            this.btn_sell_10.UseVisualStyleBackColor = false;
            this.btn_sell_10.Click += new System.EventHandler(this.btn_sell_10_Click);
            // 
            // btn_sell_1
            // 
            this.btn_sell_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sell_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sell_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell_1.Location = new System.Drawing.Point(258, 0);
            this.btn_sell_1.Name = "btn_sell_1";
            this.btn_sell_1.Size = new System.Drawing.Size(51, 46);
            this.btn_sell_1.TabIndex = 1;
            this.btn_sell_1.Text = "-1";
            this.btn_sell_1.UseVisualStyleBackColor = false;
            this.btn_sell_1.Click += new System.EventHandler(this.btn_sell_1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_but_10000);
            this.panel4.Controls.Add(this.btn_but_1000);
            this.panel4.Controls.Add(this.btn_but_100);
            this.panel4.Controls.Add(this.btn_but_10);
            this.panel4.Controls.Add(this.btn_but_1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 46);
            this.panel4.TabIndex = 0;
            // 
            // btn_but_10000
            // 
            this.btn_but_10000.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_but_10000.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_but_10000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_but_10000.Location = new System.Drawing.Point(31, 0);
            this.btn_but_10000.Name = "btn_but_10000";
            this.btn_but_10000.Size = new System.Drawing.Size(65, 46);
            this.btn_but_10000.TabIndex = 5;
            this.btn_but_10000.Text = "^10000";
            this.btn_but_10000.UseVisualStyleBackColor = false;
            this.btn_but_10000.Click += new System.EventHandler(this.btn_but_10000_Click);
            // 
            // btn_but_1000
            // 
            this.btn_but_1000.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_but_1000.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_but_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_but_1000.Location = new System.Drawing.Point(96, 0);
            this.btn_but_1000.Name = "btn_but_1000";
            this.btn_but_1000.Size = new System.Drawing.Size(60, 46);
            this.btn_but_1000.TabIndex = 4;
            this.btn_but_1000.Text = "^1000";
            this.btn_but_1000.UseVisualStyleBackColor = false;
            this.btn_but_1000.Click += new System.EventHandler(this.btn_but_1000_Click);
            // 
            // btn_but_100
            // 
            this.btn_but_100.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_but_100.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_but_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_but_100.Location = new System.Drawing.Point(156, 0);
            this.btn_but_100.Name = "btn_but_100";
            this.btn_but_100.Size = new System.Drawing.Size(51, 46);
            this.btn_but_100.TabIndex = 3;
            this.btn_but_100.Text = "^100";
            this.btn_but_100.UseVisualStyleBackColor = false;
            this.btn_but_100.Click += new System.EventHandler(this.btn_but_100_Click);
            // 
            // btn_but_10
            // 
            this.btn_but_10.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_but_10.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_but_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_but_10.Location = new System.Drawing.Point(207, 0);
            this.btn_but_10.Name = "btn_but_10";
            this.btn_but_10.Size = new System.Drawing.Size(51, 46);
            this.btn_but_10.TabIndex = 2;
            this.btn_but_10.Text = "^10";
            this.btn_but_10.UseVisualStyleBackColor = false;
            this.btn_but_10.Click += new System.EventHandler(this.btn_but_10_Click);
            // 
            // btn_but_1
            // 
            this.btn_but_1.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_but_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_but_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_but_1.Location = new System.Drawing.Point(258, 0);
            this.btn_but_1.Name = "btn_but_1";
            this.btn_but_1.Size = new System.Drawing.Size(51, 46);
            this.btn_but_1.TabIndex = 1;
            this.btn_but_1.Text = "^1";
            this.btn_but_1.UseVisualStyleBackColor = false;
            this.btn_but_1.Click += new System.EventHandler(this.btn_but_1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_price_change_from_the_start_of_session);
            this.groupBox1.Controls.Add(this.lbl_analytics_from_last_10th_price);
            this.groupBox1.Controls.Add(this.lbl_current_price);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // lbl_price_change_from_the_start_of_session
            // 
            this.lbl_price_change_from_the_start_of_session.AutoSize = true;
            this.lbl_price_change_from_the_start_of_session.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_change_from_the_start_of_session.Location = new System.Drawing.Point(134, 37);
            this.lbl_price_change_from_the_start_of_session.Name = "lbl_price_change_from_the_start_of_session";
            this.lbl_price_change_from_the_start_of_session.Size = new System.Drawing.Size(56, 18);
            this.lbl_price_change_from_the_start_of_session.TabIndex = 2;
            this.lbl_price_change_from_the_start_of_session.Text = "label1";
            // 
            // lbl_analytics_from_last_10th_price
            // 
            this.lbl_analytics_from_last_10th_price.AutoSize = true;
            this.lbl_analytics_from_last_10th_price.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_analytics_from_last_10th_price.Location = new System.Drawing.Point(1, 37);
            this.lbl_analytics_from_last_10th_price.Name = "lbl_analytics_from_last_10th_price";
            this.lbl_analytics_from_last_10th_price.Size = new System.Drawing.Size(56, 18);
            this.lbl_analytics_from_last_10th_price.TabIndex = 1;
            this.lbl_analytics_from_last_10th_price.Text = "label1";
            // 
            // lbl_current_price
            // 
            this.lbl_current_price.AutoSize = true;
            this.lbl_current_price.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_price.Location = new System.Drawing.Point(3, 19);
            this.lbl_current_price.Name = "lbl_current_price";
            this.lbl_current_price.Size = new System.Drawing.Size(56, 18);
            this.lbl_current_price.TabIndex = 0;
            this.lbl_current_price.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(214, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 519);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "^30";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "PriceSeries";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(630, 485);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_show_last_10_prices
            // 
            this.btn_show_last_10_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_10_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_10_prices.Location = new System.Drawing.Point(0, 0);
            this.btn_show_last_10_prices.Name = "btn_show_last_10_prices";
            this.btn_show_last_10_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_10_prices.TabIndex = 0;
            this.btn_show_last_10_prices.Text = "^10";
            this.btn_show_last_10_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_10_prices.Click += new System.EventHandler(this.btn_show_last_10_prices_Click);
            // 
            // btn_show_last_30_prices
            // 
            this.btn_show_last_30_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_30_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_30_prices.Location = new System.Drawing.Point(0, 48);
            this.btn_show_last_30_prices.Name = "btn_show_last_30_prices";
            this.btn_show_last_30_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_30_prices.TabIndex = 1;
            this.btn_show_last_30_prices.Text = "^30";
            this.btn_show_last_30_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_30_prices.Click += new System.EventHandler(this.btn_show_last_30_prices_Click);
            // 
            // btn_show_last_100_prices
            // 
            this.btn_show_last_100_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_100_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_100_prices.Location = new System.Drawing.Point(0, 96);
            this.btn_show_last_100_prices.Name = "btn_show_last_100_prices";
            this.btn_show_last_100_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_100_prices.TabIndex = 2;
            this.btn_show_last_100_prices.Text = "^100";
            this.btn_show_last_100_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_100_prices.Click += new System.EventHandler(this.btn_show_last_100_prices_Click);
            // 
            // btn_show_last_500_prices
            // 
            this.btn_show_last_500_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_500_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_500_prices.Location = new System.Drawing.Point(0, 144);
            this.btn_show_last_500_prices.Name = "btn_show_last_500_prices";
            this.btn_show_last_500_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_500_prices.TabIndex = 3;
            this.btn_show_last_500_prices.Text = "^500";
            this.btn_show_last_500_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_500_prices.Click += new System.EventHandler(this.btn_show_last_500_prices_Click);
            // 
            // btn_show_last_1000_prices
            // 
            this.btn_show_last_1000_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_1000_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_1000_prices.Location = new System.Drawing.Point(0, 192);
            this.btn_show_last_1000_prices.Name = "btn_show_last_1000_prices";
            this.btn_show_last_1000_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_1000_prices.TabIndex = 4;
            this.btn_show_last_1000_prices.Text = "^1000";
            this.btn_show_last_1000_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_1000_prices.Click += new System.EventHandler(this.btn_show_last_1000_prices_Click);
            // 
            // btn_show_last_2000_prices
            // 
            this.btn_show_last_2000_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_2000_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_2000_prices.Location = new System.Drawing.Point(0, 240);
            this.btn_show_last_2000_prices.Name = "btn_show_last_2000_prices";
            this.btn_show_last_2000_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_2000_prices.TabIndex = 5;
            this.btn_show_last_2000_prices.Text = "^2000";
            this.btn_show_last_2000_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_2000_prices.Click += new System.EventHandler(this.btn_show_last_2000_prices_Click);
            // 
            // btn_show_last_10000_prices
            // 
            this.btn_show_last_10000_prices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_last_10000_prices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_last_10000_prices.Location = new System.Drawing.Point(0, 288);
            this.btn_show_last_10000_prices.Name = "btn_show_last_10000_prices";
            this.btn_show_last_10000_prices.Size = new System.Drawing.Size(214, 48);
            this.btn_show_last_10000_prices.TabIndex = 6;
            this.btn_show_last_10000_prices.Text = "^10000";
            this.btn_show_last_10000_prices.UseVisualStyleBackColor = true;
            this.btn_show_last_10000_prices.Click += new System.EventHandler(this.btn_show_last_10000_prices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 672);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Trade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_analytics_from_last_10th_price;
        private System.Windows.Forms.Label lbl_current_price;
        private System.Windows.Forms.Label lbl_price_change_from_the_start_of_session;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_sell_10000;
        private System.Windows.Forms.Button btn_sell_1000;
        private System.Windows.Forms.Button btn_sell_100;
        private System.Windows.Forms.Button btn_sell_10;
        private System.Windows.Forms.Button btn_sell_1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_but_10000;
        private System.Windows.Forms.Button btn_but_1000;
        private System.Windows.Forms.Button btn_but_100;
        private System.Windows.Forms.Button btn_but_10;
        private System.Windows.Forms.Button btn_but_1;
        private System.Windows.Forms.Label lbl_cash_balance;
        private System.Windows.Forms.Label lbl_stock_holdings;
        private System.Windows.Forms.Label lbl_wallet_analytics;
        private System.Windows.Forms.Button btn_show_last_10000_prices;
        private System.Windows.Forms.Button btn_show_last_2000_prices;
        private System.Windows.Forms.Button btn_show_last_1000_prices;
        private System.Windows.Forms.Button btn_show_last_500_prices;
        private System.Windows.Forms.Button btn_show_last_100_prices;
        private System.Windows.Forms.Button btn_show_last_30_prices;
        private System.Windows.Forms.Button btn_show_last_10_prices;
    }
}

