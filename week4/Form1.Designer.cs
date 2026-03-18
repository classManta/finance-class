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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1LoginID = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.button1Login = new System.Windows.Forms.Button();
            this.buttonEnterMonitorLONG_click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StockList = new System.Windows.Forms.ListBox();
            this.gvListData = new System.Windows.Forms.DataGridView();
            this.button1gvSearch = new System.Windows.Forms.Button();
            this.textBox1StockData = new System.Windows.Forms.TextBox();
            this.comboBox1StockDataType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvListData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "登入ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼";
            // 
            // textBox1LoginID
            // 
            this.textBox1LoginID.Location = new System.Drawing.Point(17, 36);
            this.textBox1LoginID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1LoginID.Name = "textBox1LoginID";
            this.textBox1LoginID.Size = new System.Drawing.Size(132, 25);
            this.textBox1LoginID.TabIndex = 2;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(181, 36);
            this.textBox2Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(132, 25);
            this.textBox2Password.TabIndex = 3;
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(339, 36);
            this.button1Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(100, 29);
            this.button1Login.TabIndex = 4;
            this.button1Login.Text = "登入";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // buttonEnterMonitorLONG_click
            // 
            this.buttonEnterMonitorLONG_click.Location = new System.Drawing.Point(20, 89);
            this.buttonEnterMonitorLONG_click.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnterMonitorLONG_click.Name = "buttonEnterMonitorLONG_click";
            this.buttonEnterMonitorLONG_click.Size = new System.Drawing.Size(100, 29);
            this.buttonEnterMonitorLONG_click.TabIndex = 7;
            this.buttonEnterMonitorLONG_click.Text = "繼續";
            this.buttonEnterMonitorLONG_click.UseVisualStyleBackColor = true;
            this.buttonEnterMonitorLONG_click.Click += new System.EventHandler(this.buttonEnterMonitorLONG_click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(557, 39);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 193);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // StockList
            // 
            this.StockList.FormattingEnabled = true;
            this.StockList.ItemHeight = 15;
            this.StockList.Location = new System.Drawing.Point(557, 301);
            this.StockList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(353, 109);
            this.StockList.TabIndex = 9;
            // 
            // gvListData
            // 
            this.gvListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListData.Location = new System.Drawing.Point(20, 301);
            this.gvListData.Name = "gvListData";
            this.gvListData.RowHeadersWidth = 51;
            this.gvListData.RowTemplate.Height = 27;
            this.gvListData.Size = new System.Drawing.Size(240, 150);
            this.gvListData.TabIndex = 10;
            // 
            // button1gvSearch
            // 
            this.button1gvSearch.Location = new System.Drawing.Point(20, 490);
            this.button1gvSearch.Name = "button1gvSearch";
            this.button1gvSearch.Size = new System.Drawing.Size(75, 23);
            this.button1gvSearch.TabIndex = 11;
            this.button1gvSearch.Text = "查詢";
            this.button1gvSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1StockData
            // 
            this.textBox1StockData.Location = new System.Drawing.Point(20, 457);
            this.textBox1StockData.Name = "textBox1StockData";
            this.textBox1StockData.Size = new System.Drawing.Size(100, 25);
            this.textBox1StockData.TabIndex = 12;
            // 
            // comboBox1StockDataType
            // 
            this.comboBox1StockDataType.FormattingEnabled = true;
            this.comboBox1StockDataType.Location = new System.Drawing.Point(139, 457);
            this.comboBox1StockDataType.Name = "comboBox1StockDataType";
            this.comboBox1StockDataType.Size = new System.Drawing.Size(121, 23);
            this.comboBox1StockDataType.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.comboBox1StockDataType);
            this.Controls.Add(this.textBox1StockData);
            this.Controls.Add(this.button1gvSearch);
            this.Controls.Add(this.gvListData);
            this.Controls.Add(this.StockList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonEnterMonitorLONG_click);
            this.Controls.Add(this.button1Login);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1LoginID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1LoginID;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.Button buttonEnterMonitorLONG_click;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox StockList;
        private System.Windows.Forms.DataGridView gvListData;
        private System.Windows.Forms.Button button1gvSearch;
        private System.Windows.Forms.TextBox textBox1StockData;
        private System.Windows.Forms.ComboBox comboBox1StockDataType;
    }
}

