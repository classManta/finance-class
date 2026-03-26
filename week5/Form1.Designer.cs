namespace COMSample1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1LoginID = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.button1Login = new System.Windows.Forms.Button();
            this.buttonEnterMonitorLONG = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.btnQueryStocks = new System.Windows.Forms.Button();
            this.btnCancelStocks = new System.Windows.Forms.Button();
            this.gridStocks = new System.Windows.Forms.DataGridView();
            this.GridBest5Bid = new System.Windows.Forms.DataGridView();
            this.GridBest5Ask = new System.Windows.Forms.DataGridView();
            this.listTicks = new System.Windows.Forms.ListBox();
            this.btnTicks = new System.Windows.Forms.Button();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.btnTickStop = new System.Windows.Forms.Button();
            this.txtTickPageNo = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.RequestStockListBtn = new System.Windows.Forms.Button();
            this.MarketNo_txt = new System.Windows.Forms.TextBox();
            this.StockList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendStocksSocketOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Bid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Ask)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登入ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼";
            // 
            // textBox1LoginID
            // 
            this.textBox1LoginID.Location = new System.Drawing.Point(6, 34);
            this.textBox1LoginID.Name = "textBox1LoginID";
            this.textBox1LoginID.Size = new System.Drawing.Size(100, 22);
            this.textBox1LoginID.TabIndex = 2;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(129, 34);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(100, 22);
            this.textBox2Password.TabIndex = 3;
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(247, 34);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(75, 23);
            this.button1Login.TabIndex = 4;
            this.button1Login.Text = "登入";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // buttonEnterMonitorLONG
            // 
            this.buttonEnterMonitorLONG.Location = new System.Drawing.Point(8, 21);
            this.buttonEnterMonitorLONG.Name = "buttonEnterMonitorLONG";
            this.buttonEnterMonitorLONG.Size = new System.Drawing.Size(100, 23);
            this.buttonEnterMonitorLONG.TabIndex = 5;
            this.buttonEnterMonitorLONG.Text = "連線報價主機";
            this.buttonEnterMonitorLONG.UseVisualStyleBackColor = true;
            this.buttonEnterMonitorLONG.Click += new System.EventHandler(this.buttonEnterMonitorLONG_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(355, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 226);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // txtStocks
            // 
            this.txtStocks.Location = new System.Drawing.Point(8, 21);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(243, 22);
            this.txtStocks.TabIndex = 7;
            this.txtStocks.Text = "6005,1815";
            // 
            // btnQueryStocks
            // 
            this.btnQueryStocks.Location = new System.Drawing.Point(257, 20);
            this.btnQueryStocks.Name = "btnQueryStocks";
            this.btnQueryStocks.Size = new System.Drawing.Size(65, 23);
            this.btnQueryStocks.TabIndex = 8;
            this.btnQueryStocks.Text = "訂閱報價";
            this.btnQueryStocks.UseVisualStyleBackColor = true;
            this.btnQueryStocks.Click += new System.EventHandler(this.btnQueryStocks_Click);
            // 
            // btnCancelStocks
            // 
            this.btnCancelStocks.Location = new System.Drawing.Point(328, 19);
            this.btnCancelStocks.Name = "btnCancelStocks";
            this.btnCancelStocks.Size = new System.Drawing.Size(64, 23);
            this.btnCancelStocks.TabIndex = 10;
            this.btnCancelStocks.Text = "取消訂閱";
            this.btnCancelStocks.UseVisualStyleBackColor = true;
            this.btnCancelStocks.Click += new System.EventHandler(this.btnCancelStocks_Click);
            // 
            // gridStocks
            // 
            this.gridStocks.AllowUserToAddRows = false;
            this.gridStocks.AllowUserToDeleteRows = false;
            this.gridStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStocks.Location = new System.Drawing.Point(5, 49);
            this.gridStocks.Name = "gridStocks";
            this.gridStocks.ReadOnly = true;
            this.gridStocks.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridStocks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridStocks.RowTemplate.Height = 24;
            this.gridStocks.Size = new System.Drawing.Size(595, 219);
            this.gridStocks.TabIndex = 11;
            // 
            // GridBest5Bid
            // 
            this.GridBest5Bid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBest5Bid.Location = new System.Drawing.Point(524, 128);
            this.GridBest5Bid.MultiSelect = false;
            this.GridBest5Bid.Name = "GridBest5Bid";
            this.GridBest5Bid.RowHeadersVisible = false;
            this.GridBest5Bid.RowTemplate.Height = 24;
            this.GridBest5Bid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridBest5Bid.Size = new System.Drawing.Size(131, 157);
            this.GridBest5Bid.TabIndex = 16;
            // 
            // GridBest5Ask
            // 
            this.GridBest5Ask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBest5Ask.Location = new System.Drawing.Point(671, 128);
            this.GridBest5Ask.MultiSelect = false;
            this.GridBest5Ask.Name = "GridBest5Ask";
            this.GridBest5Ask.RowHeadersVisible = false;
            this.GridBest5Ask.RowTemplate.Height = 24;
            this.GridBest5Ask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridBest5Ask.Size = new System.Drawing.Size(131, 157);
            this.GridBest5Ask.TabIndex = 15;
            // 
            // listTicks
            // 
            this.listTicks.BackColor = System.Drawing.SystemColors.Window;
            this.listTicks.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listTicks.FormattingEnabled = true;
            this.listTicks.HorizontalExtent = 1000;
            this.listTicks.HorizontalScrollbar = true;
            this.listTicks.ItemHeight = 17;
            this.listTicks.Location = new System.Drawing.Point(8, 43);
            this.listTicks.Name = "listTicks";
            this.listTicks.ScrollAlwaysVisible = true;
            this.listTicks.Size = new System.Drawing.Size(510, 242);
            this.listTicks.TabIndex = 14;
            // 
            // btnTicks
            // 
            this.btnTicks.Location = new System.Drawing.Point(174, 10);
            this.btnTicks.Name = "btnTicks";
            this.btnTicks.Size = new System.Drawing.Size(112, 27);
            this.btnTicks.TabIndex = 13;
            this.btnTicks.Text = "訂閱Ticks_Best5";
            this.btnTicks.UseVisualStyleBackColor = true;
            this.btnTicks.Click += new System.EventHandler(this.btnTicks_Click);
            // 
            // txtTick
            // 
            this.txtTick.Location = new System.Drawing.Point(105, 15);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(63, 22);
            this.txtTick.TabIndex = 12;
            this.txtTick.Text = "6005";
            // 
            // btnTickStop
            // 
            this.btnTickStop.Location = new System.Drawing.Point(292, 10);
            this.btnTickStop.Name = "btnTickStop";
            this.btnTickStop.Size = new System.Drawing.Size(102, 25);
            this.btnTickStop.TabIndex = 17;
            this.btnTickStop.Text = "取消訂閱";
            this.btnTickStop.UseVisualStyleBackColor = true;
            this.btnTickStop.Click += new System.EventHandler(this.btnTickStop_Click);
            // 
            // txtTickPageNo
            // 
            this.txtTickPageNo.Location = new System.Drawing.Point(53, 15);
            this.txtTickPageNo.Name = "txtTickPageNo";
            this.txtTickPageNo.Size = new System.Drawing.Size(46, 22);
            this.txtTickPageNo.TabIndex = 23;
            this.txtTickPageNo.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 18);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 12);
            this.label45.TabIndex = 22;
            this.label45.Text = "PageNo";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(52, 12);
            this.label42.TabIndex = 27;
            this.label42.Text = "MarketNo";
            // 
            // RequestStockListBtn
            // 
            this.RequestStockListBtn.Location = new System.Drawing.Point(92, 12);
            this.RequestStockListBtn.Name = "RequestStockListBtn";
            this.RequestStockListBtn.Size = new System.Drawing.Size(135, 29);
            this.RequestStockListBtn.TabIndex = 26;
            this.RequestStockListBtn.Text = "RequestStockList";
            this.RequestStockListBtn.UseVisualStyleBackColor = true;
            this.RequestStockListBtn.Click += new System.EventHandler(this.RequestStockListBtn_Click);
            // 
            // MarketNo_txt
            // 
            this.MarketNo_txt.Location = new System.Drawing.Point(64, 15);
            this.MarketNo_txt.Name = "MarketNo_txt";
            this.MarketNo_txt.Size = new System.Drawing.Size(22, 22);
            this.MarketNo_txt.TabIndex = 25;
            // 
            // StockList
            // 
            this.StockList.FormattingEnabled = true;
            this.StockList.HorizontalScrollbar = true;
            this.StockList.ItemHeight = 12;
            this.StockList.Location = new System.Drawing.Point(8, 43);
            this.StockList.Name = "StockList";
            this.StockList.ScrollAlwaysVisible = true;
            this.StockList.Size = new System.Drawing.Size(816, 184);
            this.StockList.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1LoginID);
            this.groupBox1.Controls.Add(this.textBox2Password);
            this.groupBox1.Controls.Add(this.button1Login);
            this.groupBox1.Location = new System.Drawing.Point(17, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 72);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEnterMonitorLONG);
            this.groupBox2.Location = new System.Drawing.Point(17, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 149);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "行情";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.MarketNo_txt);
            this.groupBox3.Controls.Add(this.RequestStockListBtn);
            this.groupBox3.Controls.Add(this.StockList);
            this.groupBox3.Location = new System.Drawing.Point(631, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 227);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "商品檔查詢";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStocks);
            this.groupBox4.Controls.Add(this.btnQueryStocks);
            this.groupBox4.Controls.Add(this.btnCancelStocks);
            this.groupBox4.Controls.Add(this.gridStocks);
            this.groupBox4.Location = new System.Drawing.Point(17, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 298);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "即時報價";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.txtTickPageNo);
            this.groupBox5.Controls.Add(this.txtTick);
            this.groupBox5.Controls.Add(this.btnTicks);
            this.groupBox5.Controls.Add(this.btnTickStop);
            this.groupBox5.Controls.Add(this.GridBest5Ask);
            this.groupBox5.Controls.Add(this.GridBest5Bid);
            this.groupBox5.Controls.Add(this.listTicks);
            this.groupBox5.Location = new System.Drawing.Point(639, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(821, 298);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ticks跟5檔";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.btnSendStocksSocketOrder);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(17, 548);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(600, 162);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "證券新單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品代碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "買賣別";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "委託價";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "委託量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "自訂義欄位";
            // 
            // btnSendStocksSocketOrder
            // 
            this.btnSendStocksSocketOrder.Location = new System.Drawing.Point(349, 41);
            this.btnSendStocksSocketOrder.Name = "btnSendStocksSocketOrder";
            this.btnSendStocksSocketOrder.Size = new System.Drawing.Size(135, 23);
            this.btnSendStocksSocketOrder.TabIndex = 10;
            this.btnSendStocksSocketOrder.Text = "SendStocksSocketOrder";
            this.btnSendStocksSocketOrder.UseVisualStyleBackColor = true;
            this.btnSendStocksSocketOrder.Click += new System.EventHandler(this.btnSendStocksSocketOrder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 22);
            this.textBox4.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 20);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1472, 722);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Bid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Ask)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1LoginID;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.Button buttonEnterMonitorLONG;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.Button btnQueryStocks;
        private System.Windows.Forms.Button btnCancelStocks;
        private System.Windows.Forms.DataGridView gridStocks;
        private System.Windows.Forms.DataGridView GridBest5Bid;
        private System.Windows.Forms.DataGridView GridBest5Ask;
        private System.Windows.Forms.ListBox listTicks;
        private System.Windows.Forms.Button btnTicks;
        private System.Windows.Forms.TextBox txtTick;
        private System.Windows.Forms.Button btnTickStop;
        private System.Windows.Forms.TextBox txtTickPageNo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button RequestStockListBtn;
        private System.Windows.Forms.TextBox MarketNo_txt;
        private System.Windows.Forms.ListBox StockList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSendStocksSocketOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

