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
        //add com object
        SKQuoteLib m_SKQuote;
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
        void m_SKQuoteLib_OnConnection(int nKind, int nCode)
        {
            if (nKind == 3001)
            {
                richTextBox1.AppendText("連線中(尚未連線完成)" + nKind + "\n");
            }
            else if (nKind == 3002)
            {
                richTextBox1.AppendText("斷線" + nKind + "\n");
            }
            else if (nKind == 3003)
            {
                richTextBox1.AppendText("連線完成(下載完商品檔))" + nKind + "\n");
            }
            else if (nKind == 3033)
            {
                //異常
                richTextBox1.AppendText("與報價主機發生異常斷線: " + nKind + "\n");
            }
            else
            {
                richTextBox1.AppendText("連線狀態事件失敗:" + nKind + "\n");
            }
        }
        void SKQuoteLib_RequestStockList(short sMarketNo)
        {
            m_nCode = m_SKQuote.SKQuoteLib_RequestStockList(sMarketNo);
        }
        void m_SKQuoteLib_OnNotifyCommodityListWithTypeNo(short sMarketNo, string bstrStocListData) 
        {
            string strData = "";
            strData = "[OnNotifyCommodityList]" + bstrStocListData;
            StockList.Items.Add(strData);
        }
        public Form1()
        {
            InitializeComponent();
            m_SKQuote = new SKQuoteLib();
            m_pSKCenter = new SKCenterLib();

            m_pSKCenter.OnLoginMessage += new _ISKCenterLibEvents_OnLoginMessageEventHandler(this.OnLoginMessage);
            m_SKQuote.OnConnection += new _ISKQuoteLibEvents_OnConnectionEventHandler(m_SKQuoteLib_OnConnection);
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

        private void buttonEnterMonitorLONG_click_Click(object sender, EventArgs e)
        {
            m_nCode = m_SKQuote.SKQuoteLib_EnterMonitorLONG();
            if (m_nCode == 0)
            {
                richTextBox1.AppendText(textBox1LoginID.Text.Trim() + " 呼叫連線函式成功\n");
            }
            else
            {
                richTextBox1.AppendText(textBox1LoginID.Text.Trim() + " 呼叫連線函式失敗" + m_nCode + "\n");

            }
        }
    }
}
