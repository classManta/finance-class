using SKCOMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMSample1
{
    public partial class Form1 : Form
    {
        int m_nCode;
        SKCenterLib m_pSKCenter;
        void OnLoginMessage(string strUserID, string strStatusCode, string strMessage)
        {
            if (strStatusCode == "0")//成功
            {
                MessageBox.Show(strUserID + "登入成功!");
            }
            else
            {
                MessageBox.Show(strUserID + "登入失敗!狀態碼： " + strStatusCode + "錯誤訊息： " + strMessage);
            }
        }

        public Form1()
        {
            InitializeComponent();
            m_pSKCenter = new SKCenterLib();
            m_pSKCenter.OnLoginMessage += new _ISKCenterLibEvents_OnLoginMessageEventHandler(this.OnLoginMessage);
        }

        private void button1Login_Click(object sender, EventArgs e)
        {
            int nSeqId = 0;
            m_nCode = m_pSKCenter.SKCenterLib_SocketLogin(ref nSeqId, textBox1LoginID.Text.Trim().ToUpper(), textBox2Password.Text.Trim());
            if (m_nCode == 0)
            {
                MessageBox.Show(textBox1LoginID.Text.Trim() + " 呼叫登入函式");
            }
            else
            {
                MessageBox.Show(textBox1LoginID.Text.Trim() + " 呼叫登入函式失敗!錯誤代碼:" + m_nCode);
            }
        }
    }
}
