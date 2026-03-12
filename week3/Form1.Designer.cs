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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登入ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼";
            // 
            // textBox1LoginID
            // 
            this.textBox1LoginID.Location = new System.Drawing.Point(13, 29);
            this.textBox1LoginID.Name = "textBox1LoginID";
            this.textBox1LoginID.Size = new System.Drawing.Size(100, 22);
            this.textBox1LoginID.TabIndex = 2;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(136, 29);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(100, 22);
            this.textBox2Password.TabIndex = 3;
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(254, 29);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(75, 23);
            this.button1Login.TabIndex = 4;
            this.button1Login.Text = "登入";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // buttonEnterMonitorLONG_click
            // 
            this.buttonEnterMonitorLONG_click.Location = new System.Drawing.Point(15, 71);
            this.buttonEnterMonitorLONG_click.Name = "buttonEnterMonitorLONG_click";
            this.buttonEnterMonitorLONG_click.Size = new System.Drawing.Size(75, 23);
            this.buttonEnterMonitorLONG_click.TabIndex = 7;
            this.buttonEnterMonitorLONG_click.Text = "繼續";
            this.buttonEnterMonitorLONG_click.UseVisualStyleBackColor = true;
            this.buttonEnterMonitorLONG_click.Click += new System.EventHandler(this.buttonEnterMonitorLONG_click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(458, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 155);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonEnterMonitorLONG_click);
            this.Controls.Add(this.button1Login);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1LoginID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

