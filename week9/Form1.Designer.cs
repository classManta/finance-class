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
            this.textbstrCommentCancel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendStockSocketAlter = new System.Windows.Forms.Button();
            this.txtCancelSeqNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbstrCommentOrder = new System.Windows.Forms.TextBox();
            this.btnSendStockSocketOrder = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.boxBidAsk = new System.Windows.Forms.ComboBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSocketOrderHistoryReport = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SMAbox = new System.Windows.Forms.GroupBox();
            this.richTextBoxSMA = new System.Windows.Forms.RichTextBox();
            this.buttonCalculateSMA = new System.Windows.Forms.Button();
            this.textBoxSMAperiod = new System.Windows.Forms.TextBox();
            this.textBoxSMAStockNo = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listKLine = new System.Windows.Forms.ListBox();
            this.btnKLineAMByDate = new System.Windows.Forms.Button();
            this.boxOutType_ByDate = new System.Windows.Forms.ComboBox();
            this.boxKLine_ByDate = new System.Windows.Forms.ComboBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtMinuteNumber = new System.Windows.Forms.TextBox();
            this.txtKLine_ByDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Bid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Ask)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SMAbox.SuspendLayout();
            this.groupBox10.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(332, 63);
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
            this.groupBox6.Controls.Add(this.textbstrCommentCancel);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnSendStockSocketAlter);
            this.groupBox6.Controls.Add(this.txtCancelSeqNo);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(17, 634);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(608, 42);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "證券刪單";
            // 
            // textbstrCommentCancel
            // 
            this.textbstrCommentCancel.Location = new System.Drawing.Point(316, 11);
            this.textbstrCommentCancel.Name = "textbstrCommentCancel";
            this.textbstrCommentCancel.Size = new System.Drawing.Size(49, 22);
            this.textbstrCommentCancel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "自定義欄位";
            // 
            // btnSendStockSocketAlter
            // 
            this.btnSendStockSocketAlter.Location = new System.Drawing.Point(371, 11);
            this.btnSendStockSocketAlter.Name = "btnSendStockSocketAlter";
            this.btnSendStockSocketAlter.Size = new System.Drawing.Size(152, 23);
            this.btnSendStockSocketAlter.TabIndex = 5;
            this.btnSendStockSocketAlter.Text = "SendStockSocketAlter";
            this.btnSendStockSocketAlter.UseVisualStyleBackColor = true;
            this.btnSendStockSocketAlter.Click += new System.EventHandler(this.btnSendStockSocketAlter_Click);
            // 
            // txtCancelSeqNo
            // 
            this.txtCancelSeqNo.Location = new System.Drawing.Point(79, 12);
            this.txtCancelSeqNo.Name = "txtCancelSeqNo";
            this.txtCancelSeqNo.Size = new System.Drawing.Size(149, 22);
            this.txtCancelSeqNo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "委託序號";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textbstrCommentOrder);
            this.groupBox7.Controls.Add(this.btnSendStockSocketOrder);
            this.groupBox7.Controls.Add(this.txtQty);
            this.groupBox7.Controls.Add(this.txtPrice);
            this.groupBox7.Controls.Add(this.boxBidAsk);
            this.groupBox7.Controls.Add(this.txtStockNo);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Location = new System.Drawing.Point(17, 548);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(608, 80);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "證券新單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "自定義欄位";
            // 
            // textbstrCommentOrder
            // 
            this.textbstrCommentOrder.Location = new System.Drawing.Point(316, 45);
            this.textbstrCommentOrder.Name = "textbstrCommentOrder";
            this.textbstrCommentOrder.Size = new System.Drawing.Size(49, 22);
            this.textbstrCommentOrder.TabIndex = 9;
            // 
            // btnSendStockSocketOrder
            // 
            this.btnSendStockSocketOrder.Location = new System.Drawing.Point(371, 43);
            this.btnSendStockSocketOrder.Name = "btnSendStockSocketOrder";
            this.btnSendStockSocketOrder.Size = new System.Drawing.Size(152, 24);
            this.btnSendStockSocketOrder.TabIndex = 8;
            this.btnSendStockSocketOrder.Text = "SendStockSocketOrder";
            this.btnSendStockSocketOrder.UseVisualStyleBackColor = true;
            this.btnSendStockSocketOrder.Click += new System.EventHandler(this.btnSendStockSocketOrder_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(247, 43);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 22);
            this.txtQty.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(74, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // boxBidAsk
            // 
            this.boxBidAsk.FormattingEnabled = true;
            this.boxBidAsk.Items.AddRange(new object[] {
            "買",
            "賣"});
            this.boxBidAsk.Location = new System.Drawing.Point(90, 45);
            this.boxBidAsk.Name = "boxBidAsk";
            this.boxBidAsk.Size = new System.Drawing.Size(49, 20);
            this.boxBidAsk.TabIndex = 2;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(19, 45);
            this.txtStockNo.MaxLength = 8;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(64, 22);
            this.txtStockNo.TabIndex = 1;
            this.txtStockNo.Text = "6005";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "委託量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "委託價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "買賣別";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "商品代碼";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSocketOrderHistoryReport);
            this.groupBox8.Location = new System.Drawing.Point(17, 682);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(608, 42);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "今日下單紀錄查詢";
            // 
            // btnSocketOrderHistoryReport
            // 
            this.btnSocketOrderHistoryReport.Location = new System.Drawing.Point(8, 13);
            this.btnSocketOrderHistoryReport.Name = "btnSocketOrderHistoryReport";
            this.btnSocketOrderHistoryReport.Size = new System.Drawing.Size(178, 23);
            this.btnSocketOrderHistoryReport.TabIndex = 5;
            this.btnSocketOrderHistoryReport.Text = "查詢";
            this.btnSocketOrderHistoryReport.UseVisualStyleBackColor = true;
            this.btnSocketOrderHistoryReport.Click += new System.EventHandler(this.btnSocketOrderHistoryReport_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listMessage);
            this.groupBox9.Location = new System.Drawing.Point(639, 548);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(821, 176);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "回報";
            // 
            // listMessage
            // 
            this.listMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMessage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMessage.FormattingEnabled = true;
            this.listMessage.HorizontalExtent = 20000;
            this.listMessage.HorizontalScrollbar = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(6, 23);
            this.listMessage.Name = "listMessage";
            this.listMessage.ScrollAlwaysVisible = true;
            this.listMessage.Size = new System.Drawing.Size(804, 148);
            this.listMessage.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "智慧單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SMAbox
            // 
            this.SMAbox.Controls.Add(this.richTextBoxSMA);
            this.SMAbox.Controls.Add(this.buttonCalculateSMA);
            this.SMAbox.Controls.Add(this.textBoxSMAperiod);
            this.SMAbox.Controls.Add(this.textBoxSMAStockNo);
            this.SMAbox.Location = new System.Drawing.Point(17, 744);
            this.SMAbox.Name = "SMAbox";
            this.SMAbox.Size = new System.Drawing.Size(608, 256);
            this.SMAbox.TabIndex = 38;
            this.SMAbox.TabStop = false;
            this.SMAbox.Text = "簡單移動平均線計算";
            // 
            // richTextBoxSMA
            // 
            this.richTextBoxSMA.Location = new System.Drawing.Point(8, 49);
            this.richTextBoxSMA.Name = "richTextBoxSMA";
            this.richTextBoxSMA.Size = new System.Drawing.Size(221, 201);
            this.richTextBoxSMA.TabIndex = 3;
            this.richTextBoxSMA.Text = "";
            // 
            // buttonCalculateSMA
            // 
            this.buttonCalculateSMA.Location = new System.Drawing.Point(233, 21);
            this.buttonCalculateSMA.Name = "buttonCalculateSMA";
            this.buttonCalculateSMA.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateSMA.TabIndex = 2;
            this.buttonCalculateSMA.Text = "計算";
            this.buttonCalculateSMA.UseVisualStyleBackColor = true;
            this.buttonCalculateSMA.Click += new System.EventHandler(this.buttonCalculateSMA_Click);
            // 
            // textBoxSMAperiod
            // 
            this.textBoxSMAperiod.Location = new System.Drawing.Point(114, 21);
            this.textBoxSMAperiod.Name = "textBoxSMAperiod";
            this.textBoxSMAperiod.Size = new System.Drawing.Size(100, 22);
            this.textBoxSMAperiod.TabIndex = 1;
            // 
            // textBoxSMAStockNo
            // 
            this.textBoxSMAStockNo.Location = new System.Drawing.Point(8, 21);
            this.textBoxSMAStockNo.Name = "textBoxSMAStockNo";
            this.textBoxSMAStockNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxSMAStockNo.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.richTextBox2);
            this.groupBox10.Controls.Add(this.listKLine);
            this.groupBox10.Controls.Add(this.btnKLineAMByDate);
            this.groupBox10.Controls.Add(this.boxOutType_ByDate);
            this.groupBox10.Controls.Add(this.boxKLine_ByDate);
            this.groupBox10.Controls.Add(this.txtEndDate);
            this.groupBox10.Controls.Add(this.txtStartDate);
            this.groupBox10.Controls.Add(this.txtMinuteNumber);
            this.groupBox10.Controls.Add(this.txtKLine_ByDate);
            this.groupBox10.Location = new System.Drawing.Point(658, 744);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(608, 344);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "歷史K線";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(477, 195);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(123, 137);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // listKLine
            // 
            this.listKLine.FormattingEnabled = true;
            this.listKLine.ItemHeight = 12;
            this.listKLine.Location = new System.Drawing.Point(9, 195);
            this.listKLine.Name = "listKLine";
            this.listKLine.Size = new System.Drawing.Size(451, 136);
            this.listKLine.TabIndex = 7;
            // 
            // btnKLineAMByDate
            // 
            this.btnKLineAMByDate.Location = new System.Drawing.Point(453, 129);
            this.btnKLineAMByDate.Name = "btnKLineAMByDate";
            this.btnKLineAMByDate.Size = new System.Drawing.Size(75, 23);
            this.btnKLineAMByDate.TabIndex = 6;
            this.btnKLineAMByDate.Text = "button1";
            this.btnKLineAMByDate.UseVisualStyleBackColor = true;
            // 
            // boxOutType_ByDate
            // 
            this.boxOutType_ByDate.FormattingEnabled = true;
            this.boxOutType_ByDate.Location = new System.Drawing.Point(175, 103);
            this.boxOutType_ByDate.Name = "boxOutType_ByDate";
            this.boxOutType_ByDate.Size = new System.Drawing.Size(121, 20);
            this.boxOutType_ByDate.TabIndex = 5;
            // 
            // boxKLine_ByDate
            // 
            this.boxKLine_ByDate.FormattingEnabled = true;
            this.boxKLine_ByDate.Location = new System.Drawing.Point(175, 31);
            this.boxKLine_ByDate.Name = "boxKLine_ByDate";
            this.boxKLine_ByDate.Size = new System.Drawing.Size(121, 20);
            this.boxKLine_ByDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(453, 101);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 22);
            this.txtEndDate.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(453, 29);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 22);
            this.txtStartDate.TabIndex = 2;
            // 
            // txtMinuteNumber
            // 
            this.txtMinuteNumber.Location = new System.Drawing.Point(357, 57);
            this.txtMinuteNumber.Name = "txtMinuteNumber";
            this.txtMinuteNumber.Size = new System.Drawing.Size(65, 22);
            this.txtMinuteNumber.TabIndex = 1;
            // 
            // txtKLine_ByDate
            // 
            this.txtKLine_ByDate.Location = new System.Drawing.Point(19, 72);
            this.txtKLine_ByDate.Name = "txtKLine_ByDate";
            this.txtKLine_ByDate.Size = new System.Drawing.Size(78, 22);
            this.txtKLine_ByDate.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1472, 1061);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.SMAbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.SMAbox.ResumeLayout(false);
            this.SMAbox.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
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
        private System.Windows.Forms.Button btnSendStockSocketAlter;
        private System.Windows.Forms.TextBox txtCancelSeqNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSendStockSocketOrder;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox boxBidAsk;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbstrCommentOrder;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSocketOrderHistoryReport;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textbstrCommentCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox SMAbox;
        private System.Windows.Forms.RichTextBox richTextBoxSMA;
        private System.Windows.Forms.Button buttonCalculateSMA;
        private System.Windows.Forms.TextBox textBoxSMAperiod;
        private System.Windows.Forms.TextBox textBoxSMAStockNo;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox listKLine;
        private System.Windows.Forms.Button btnKLineAMByDate;
        private System.Windows.Forms.ComboBox boxOutType_ByDate;
        private System.Windows.Forms.ComboBox boxKLine_ByDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtMinuteNumber;
        private System.Windows.Forms.TextBox txtKLine_ByDate;
    }
}

