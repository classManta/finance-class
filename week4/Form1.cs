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
        //新增
        void SKQuoteLib_RequestStocks()
        {
            m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(textBox1StockData.Text.Trim());
        }
        void SKQuoteLib_CancelRequestStocks()
        {
            m_nCode = m_SKQuote.SKQuoteLib_CancelRequestStocks(textBox1StockData.Text.Trim());
        }
        void m_SKQuoteLib_OnNotifyQuote(short sMarketNo, string strStockNo)
        {
            SKSTOCKLONG pSKStockLONG = new SKSTOCKLONG();
            m_SKQuote.SKQuoteLib_GetStockByMarketAndNo(sMarketNo, strStockNo, ref pSKStockLONG);
            OnUpDateDataRow(pSKStockLONG);
        }
        void SKQuoteLib_RequestTicks()
        {
            m_nCode = m_SKQuote.SKQuoteLib_RequestTicks(ref sPage, textBox1StockData.Text.Trim());
        }
        void SKQuoteLib_CancelRequestTicks()
        {
            m_nCode = m_SKQuote.SKQuoteLib_CancelRequestTicks(textBox1StockData.Text.Trim());
        }
        void OnNotifyBest5LONG()
        {
            m_SKQuote.OnNotifyBest5LONG += new _ISKQuoteLibEvents_OnNotifyBest5LONGEventHandler(m_SKQuoteLib_OnNotifyBest5);
        }
        void m_SKQuoteLib_OnNotifyBest5(short sMarketNo, string bstrStockNo,
        int nBestBid1, int nBestBidQty1, int nBestBid2, int nBestBidQty2, int nBestBid3, int nBestBidQty3,
        int nBestBid4, int nBestBidQty4, int nBestBid5, int nBestBidQty5, int nExtendBid, int nExtendBidQty,
        int nBestAsk1, int nBestAskQty1, int nBestAsk2, int nBestAskQty2, int nBestAsk3, int nBestAskQty3,
        int nBestAsk4, int nBestAskQty4, int nBestAsk5, int nBestAskQty5, int nExtendAsk, int nExtendAskQty, int nSimulate)
        {

        }
        void OnNotifyTicksLONG()
        {
            m_SKQuote.OnNotifyTicksLONG += new _ISKQuoteLibEvents_OnNotifyTicksLONGEventHandler(m_SKQuoteLib_OnNotifyTicks);
        }
        void m_SKQuoteLib_OnNotifyTicks(short sMarketNo, string strStockNo, int nPtr, int nDate, int lTimehms, 
        int lTimemillismicros, int nBid, int nAsk, int nClose, int nQty, int nSimulate)
        {

        }
        void OnNotifyHistoryTicksLONG()
        {
            m_SKQuote.OnNotifyHistoryTicksLONG += new _ISKQuoteLibEvents_OnNotifyHistoryTicksLONGEventHandler(m_SKQuoteLib_OnNotifyHistoryTicks);
        }
        void m_SKQuoteLib_OnNotifyHistoryTicks(short sMarketNo,
        string strStockNo, int nPtr, int nDate, int lTimehms,
        int lTimemillismicros, int nBid, int nAsk, int nClose,
        int nQty, int nSimulate)
        {

        }
        public Form1()
        {
            InitializeComponent();
            m_SKQuote = new SKQuoteLib();
            m_pSKCenter = new SKCenterLib();

            m_pSKCenter.OnLoginMessage += new _ISKCenterLibEvents_OnLoginMessageEventHandler(this.OnLoginMessage);
            m_SKQuote.OnConnection += new _ISKQuoteLibEvents_OnConnectionEventHandler(m_SKQuoteLib_OnConnection);
            m_SKQuote.OnNotifyQuoteLONG += new _ISKQuoteLibEvents_OnNotifyQuoteLONGEventHandler(m_SKQuoteLib_OnNotifyQuote);
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
