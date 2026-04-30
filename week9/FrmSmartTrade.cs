using SKCOMLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMSample1
{
    public partial class FrmSmartTrade : Form
    {
        public SKQuoteLib m_SKQuote;
        public static SKOrderLib m_SKOrder;
        //API狀態碼
        public static int m_nCode;
        public static ConcurrentDictionary<string, string> DicStockList = new ConcurrentDictionary<string, string>();
        public static ConcurrentDictionary<string, string> DicSubStockList = new ConcurrentDictionary<string, string>();

        public static ConcurrentQueue<string> DGVQueue = new ConcurrentQueue<string>();//顯示DataGridView訊息的Queue
        public static ManualResetEvent DGVQueueEvent = new ManualResetEvent(false);

        public FrmSmartTrade()
        {
            InitializeComponent();
            m_SKQuote = new SKQuoteLib();
            m_SKOrder = new SKOrderLib();
            //連線主機
            m_SKQuote.OnConnection += new _ISKQuoteLibEvents_OnConnectionEventHandler(m_SKQuoteLib_OnConnection);
            //商品清單查詢
            m_SKQuote.OnNotifyCommodityListWithTypeNo += new _ISKQuoteLibEvents_OnNotifyCommodityListWithTypeNoEventHandler(m_SKQuoteLib_OnNotifyCommodityListWithTypeNo);
            //即時行情
            m_SKQuote.OnNotifyQuoteLONG += new _ISKQuoteLibEvents_OnNotifyQuoteLONGEventHandler(m_SKQuoteLib_OnNotifyQuote);
            //委託回報
            m_SKOrder.OnSocketOrderReport += new _ISKOrderLibEvents_OnSocketOrderReportEventHandler(m_SKOrderLib_OnSocketOrderReport);
            //錯誤回報
            m_SKOrder.OnSocketOrderFailed += new _ISKOrderLibEvents_OnSocketOrderFailedEventHandler(m_SKOrderLib_OnSocketOrderFailed);
            //成交回報
            m_SKOrder.OnSocketFulfillReport += new _ISKOrderLibEvents_OnSocketFulfillReportEventHandler(m_SKOrderLib_OnSocketFulfillReport);


        }

        private void FrmSmartTrade_Load(object sender, EventArgs e)
        {
            try
            {
                Thread threadA1 = new Thread(new ThreadStart(this.GridViewMainControl));
                threadA1.IsBackground = true;
                threadA1.Start();

                InfoFactory.Start();
                OrderFactory.Start();

               //double p =  Convert.ToDouble(StrategyFactory.PriceNTick((decimal)9.79, -1, "00940"));

                cb_marketA.SelectedIndex = 0;
                cb_direction.SelectedIndex = 1;
                cb_bs.SelectedIndex = 0;
                cb_abOrderPriceType.SelectedIndex = 1;
                cb_abOrderCond.SelectedIndex = 0;
                cb_abOrder_Type.SelectedIndex = 0;
                cb_abExchange_Code.SelectedIndex = 0;


                MST_marketA.SelectedIndex = 0;

                cb_MSTbs.SelectedIndex = 0;
                cb_MSTOrderPriceType.SelectedIndex = 1;
                cb_MSTOrderCond.SelectedIndex = 0;
                cb_MSTOrder_Type.SelectedIndex = 0;
                cb_MSTExchange_Code.SelectedIndex = 0;

                cb_DayTradebs.SelectedIndex = 0;
                cb_DayTradeOrderPriceType.SelectedIndex = 1;
                cb_DayTradeOrderCond.SelectedIndex = 0;
                cb_DayTradeOrder_Type.SelectedIndex = 0;
                cb_DayTradeExchange_Code.SelectedIndex = 0;

                //連線報價主機
                m_nCode = m_SKQuote.SKQuoteLib_EnterMonitorLONG();
                if (m_nCode == 0)
                {
                    richTextBox1.AppendText($" 呼叫報價連線函式成功\n");
                }
                else
                {
                    richTextBox1.AppendText($" 呼叫報價連線函式失敗 \n");
                }
            }
            catch (Exception exc)
            {


            }
            //   m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(txtStocks.Text.Trim());
        }

        /// <summary>
        /// 初始化股票清單
        /// </summary>
        public void IniStockList()
        {
            try
            {
                for (Int16 i = 0; i < 2; i++)
                {
                    m_nCode = m_SKQuote.SKQuoteLib_RequestStockList(i);
                    if (m_nCode == 0)
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_RequestStockList][OK][{i}]\n");
                    }
                    else
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_RequestStockList][ERROR][{i}]\n");
                    }
                }

            }
            catch (Exception exc)
            {


            }
        }


        /// <summary>
        /// API連線資訊
        /// </summary>
        /// <param name="nKind"></param>
        /// <param name="nCode"></param>
        void m_SKQuoteLib_OnConnection(int nKind, int nCode)
        {
            if (nKind == 3001)
            {
                richTextBox1.AppendText(" 連線中(尚未完成連線): " + nKind + "\n");
            }
            else if (nKind == 3002)
            {
                richTextBox1.AppendText(" 斷線: " + nKind + "\n");
            }
            else if (nKind == 3003)
            {
                richTextBox1.AppendText(" 連線完成(下載完商品檔): " + nKind + "\n");


                IniStockList();

            }
            else if (nKind == 3033)//異常
            {
                richTextBox1.AppendText(" 與報價主機發生異常斷線: " + nKind + "\n");
            }
            else
            {
                richTextBox1.AppendText(" 連線狀態事件失敗: " + nKind + "\n");
            }
        }
        /// <summary>
        /// API即時行情
        /// </summary>
        /// <param name="sMarketNo"></param>
        /// <param name="strStockNo"></param>
        void m_SKQuoteLib_OnNotifyQuote(short sMarketNo, string strStockNo)
        {
            try
            {
                SKSTOCKLONG pSKStockLONG = new SKSTOCKLONG();
                m_SKQuote.SKQuoteLib_GetStockByMarketAndNo(sMarketNo, strStockNo, ref pSKStockLONG);

                InfoFactory.QuoteQueue.Enqueue(pSKStockLONG);
                if (!InfoFactory.QuoteQueueEvent.WaitOne(0))
                {
                    InfoFactory.QuoteQueueEvent.Set();
                }
            }
            catch (Exception exc)
            {


            }


        }
        /// <summary>
        /// API取得股票清單
        /// </summary>
        /// <param name="sMarketNo"></param>
        /// <param name="bstrStockListData"></param>
        void m_SKQuoteLib_OnNotifyCommodityListWithTypeNo(short sMarketNo, string bstrStockListData)
        {

            try
            {
                //代表完結
                if (!bstrStockListData.Contains("##"))
                {

                    //%1%水泥%1101,台泥;1101B,台泥乙特;1102,亞泥;1103,嘉泥;1104,環泥;1108,幸福;1109,信大;1110,東泥;
                    string[] strL1 = bstrStockListData.Split('%');

                    if (strL1.Length > 3)
                    {
                        string[] strL2 = strL1[3].Split(';');

                        foreach (var item in strL2)
                        {
                            string[] strL3 = item.Split(',');

                            if (strL3.Length > 1)
                            {
                                DicStockList.TryAdd(strL3[0], strL3[1]);
                            }
                        }
                    }
                }
                else
                {

                    richTextBox1.AppendText($"取得基本資料共{DicStockList.Count}筆 \n");

                }
            }
            catch (Exception exc)
            {


            }






        }
        /// <summary>
        /// 委託回報
        /// </summary>
        void m_SKOrderLib_OnSocketOrderReport(int nSeqId, string bstrUserID, string bstrStockNo, int nSide, string bstrPrice, int nQty, string bstrClientOrderId, string bstrComment, int nStatus, string bstrCreateTime)
        {
            string strData = "[" + nSeqId + "]" + bstrUserID + "," + bstrStockNo + "," + nSide + "," + bstrPrice + "," + nQty + "," + bstrClientOrderId + "," + bstrComment + "," + nStatus + "," + bstrCreateTime;
            if (nStatus == 0)
            {
              

                if (OrderFactory.DicOrderMap.ContainsKey(nSeqId))
                {
                    FrmSmartTrade.AddMessage($"收到委託回報 智慧單號[{OrderFactory.DicOrderMap[nSeqId]}]  BS[{nSide}] PRICE[{bstrPrice}] 委託書號[{bstrClientOrderId}]");

                    OrderFactory.DicSmartKeyOrderMap.TryAdd(OrderFactory.DicOrderMap[nSeqId], bstrClientOrderId);

                    //更新策略字典                    
                    if (StrategyFactory.DicStrategyList.ContainsKey(bstrStockNo))
                    {
                        if (StrategyFactory.DicStrategyList[bstrStockNo].ContainsKey(OrderFactory.DicOrderMap[nSeqId]))
                        {
                            StrategyFactory.DicStrategyList[bstrStockNo][OrderFactory.DicOrderMap[nSeqId]].orderID = bstrClientOrderId;
                          

                            StrategyFactory.DicStrategyOrderIDMap.TryAdd(OrderFactory.DicOrderMap[nSeqId], bstrClientOrderId);
                        }
                    }
                }
                else
                {
                    FrmSmartTrade.AddMessage($"{strData}");
                }
                strData = "[新單委託成功]" + strData;
            }
            else
            {
                strData = "[刪單委託成功]" + strData;
            }
            //listMessage.Items.Add(strData);
        }
        /// <summary>
        /// 錯誤回報
        /// </summary>
        void m_SKOrderLib_OnSocketOrderFailed(int nSeqId, string bstrUserID, string bstrStatusCode, string bstrMessage)
        {
            string strData = "[" + nSeqId + "]" + bstrUserID + "," + bstrStatusCode + "," + bstrMessage;
            strData = "[委託失敗]" + strData;

        }
        /// <summary>
        /// 成交回報
        /// </summary>
        void m_SKOrderLib_OnSocketFulfillReport(string bstrUserID, string bstrStockNo, int nSide, string bstrPrice, int nQty, string bstrClientOrderId, string bstrComment, string bstrCreateTime, string bstrDealTime)
        {
            string strData = "[" + bstrClientOrderId + "]" + bstrUserID + "," + bstrStockNo + "," + nSide + "," + bstrPrice + "," + nQty + "," + bstrClientOrderId + "," + bstrComment + "," + bstrCreateTime + "," + bstrDealTime;
            strData = "[成交]" + strData;


            //成交後產生出場智慧單
            try
            {
                int smartKey = StrategyFactory.DicStrategyOrderIDMap.FirstOrDefault(kvp => kvp.Value == bstrClientOrderId).Key;
                FrmSmartTrade.AddMessage($"收到成交回報 智慧單號[{smartKey}] BS[{nSide}] PRICE[{bstrPrice}] 委託書號[{bstrClientOrderId}]");
                //更改為出場狀態
                if (StrategyFactory.DicStrategyList.ContainsKey(bstrStockNo))
                {
                    if (StrategyFactory.DicStrategyList[bstrStockNo].ContainsKey(smartKey)  )
                    {                        
                        StrategyFactory.DicStrategyList[bstrStockNo][smartKey].inOutFlag = 1;
                       // FrmSmartTrade.AddMessage($"收到成交回報 智慧單號[{smartKey}] BS[{nSide}] PRICE[{bstrPrice}] 委託書號[{bstrClientOrderId}]");
                    }
                }

            }
            catch (Exception exc)
            {

                throw;
            }
        }

        /// <summary>
        /// MIT送單按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMIT_Click(object sender, EventArgs e)
        {
            //訂閱商品
            int sk = 0;
            try
            {
                string StockID = txt_commodityidA.Text;

                if (string.IsNullOrEmpty(StockID))
                    return;

                //訂閱行情
                if (!DicSubStockList.ContainsKey(StockID))
                {
                    m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(StockID);
                    if (m_nCode == 0)
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]成功\n");
                        DicSubStockList.TryAdd(StockID, StockID);
                    }
                    else
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]失敗\n");
                        return;
                    }

                }

                //建立策略資料
                StrategyFactory data = new StrategyFactory();
                data.ID = "099";
                data.stockID = StockID;
                data.tradeKind = "0";
                data.triggerPrice = Convert.ToDouble(txt_triggerprice.Text);
                data.direction = cb_direction.SelectedIndex;
                data.bs = cb_bs.SelectedIndex;
                data.orderPriceTy = cb_abOrderPriceType.SelectedIndex;
                data.qty = Convert.ToInt32(txt_qty.Text);
                data.orderCond = cb_abOrderCond.SelectedIndex;
                data.order_Type = cb_abOrder_Type.SelectedIndex;
                data.exchange_Code = cb_abExchange_Code.SelectedIndex;
                data.orderPrice = Convert.ToDouble(txt_orderPrice.Text);
                sk = StrategyFactory.AddStrategy(data);

                txt_abSmarkey.Text = $"{sk}";
                richTextBox1.AppendText($"[{sk}]MIT加入洗價\n");

            }
            catch (Exception exc)
            {


            }

        }


        #region GridViewMain畫面控制 GridViewMainControl()
        public void GridViewMainControl()
        {
            int MsgCount = 0; //目前訊息筆數
            string strMessage;

            while (true)
            {
                if (FrmSmartTrade.DGVQueue.Count > 0)
                {
                    try
                    {
                        if (DGVQueue.TryDequeue(out strMessage))
                        {
                            SetControlDataGridViewMain(strMessage);
                        }
                    }
                    catch (Exception exc)
                    {


                    }
                }
                else
                {
                    DGVQueueEvent.Reset();
                    DGVQueueEvent.WaitOne();
                }
            }
        }

        delegate void SetDataGridViewMainCallback(string myMessage);
        public void SetControlDataGridViewMain(string myMessage)
        {
            try
            {
                //進行資料委派
                if (richTextBox1.InvokeRequired)
                {
                    SetDataGridViewMainCallback d = new SetDataGridViewMainCallback(SetControlDataGridViewMain);
                    this.Invoke(d, myMessage);
                }
                else
                {
                    richTextBox1.AppendText($"{myMessage}\n");
                }
            }
            catch (Exception exc)
            {


            }
        }
        #endregion

        public static void AddMessage(string message)
        {
            FrmSmartTrade.DGVQueue.Enqueue(message);
            if (!FrmSmartTrade.DGVQueueEvent.WaitOne(0))
            {
                FrmSmartTrade.DGVQueueEvent.Set();
            }
        }

        private void btnDeleteMIT_Click(object sender, EventArgs e)
        {
            try
            {
                int nSeqId = 0;
                int deleSmartkey = Convert.ToInt32(txt_abSmarkey.Text.Trim());

                //stop smart order

                if (StrategyFactory.DicStrategyStockMap.ContainsKey(deleSmartkey))
                {
                    if (StrategyFactory.DicStrategyList.ContainsKey(StrategyFactory.DicStrategyStockMap[deleSmartkey]))
                    {
                        if (StrategyFactory.DicStrategyList[StrategyFactory.DicStrategyStockMap[deleSmartkey]].ContainsKey(deleSmartkey))
                        {
                            StrategyFactory.DicStrategyList[StrategyFactory.DicStrategyStockMap[deleSmartkey]].Remove(deleSmartkey);
                            richTextBox1.AppendText($"智慧單[{deleSmartkey}]移除成功" + "\n");
                        }

                    }
                }

                if (OrderFactory.DicSmartKeyOrderMap.ContainsKey(deleSmartkey))
                {

                    m_nCode = m_SKOrder.SendStockSocketAlter(ref nSeqId, "099", OrderFactory.DicSmartKeyOrderMap[deleSmartkey], "");

                    if (m_nCode == 0)
                    {
                        richTextBox1.AppendText($"[{deleSmartkey}][{OrderFactory.DicSmartKeyOrderMap[deleSmartkey]}] 呼叫刪單函式" + "\n");
                    }
                    else
                    {
                        richTextBox1.AppendText($"[{deleSmartkey}][{OrderFactory.DicSmartKeyOrderMap[deleSmartkey]}] 呼叫刪單函式失敗!錯誤代碼:{m_nCode}\n");
                    }
                }
            }
            catch (Exception exc)
            {


            }
        }

        private void btnSendMST_Click(object sender, EventArgs e)
        {

            //訂閱商品
            int sk = 0;
            try
            {
                string StockID = txt_MSTcommodityidA.Text;

                if (string.IsNullOrEmpty(StockID))
                    return;

                //訂閱行情
                if (!DicSubStockList.ContainsKey(StockID))
                {
                    m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(StockID);
                    if (m_nCode == 0)
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]成功\n");
                        DicSubStockList.TryAdd(StockID, StockID);
                    }
                    else
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]失敗\n");
                        return;
                    }

                }

                //建立策略資料
                StrategyFactory data = new StrategyFactory();
                data.ID = "099";
                data.stockID = StockID;
                data.tradeKind = "1";
                // data.triggerPrice = Convert.ToDouble(txt_triggerprice.Text);
                // data.direction = cb_direction.SelectedIndex;
                data.bs = cb_MSTbs.SelectedIndex;
                data.orderPriceTy = cb_MSTOrderPriceType.SelectedIndex;
                data.qty = Convert.ToInt32(txt_MSTqty.Text);
                data.orderCond = cb_MSTOrderCond.SelectedIndex;
                data.order_Type = cb_MSTOrder_Type.SelectedIndex;
                data.exchange_Code = cb_MSTExchange_Code.SelectedIndex;
                data.orderPrice = Convert.ToDouble(txt_MSTorderPrice.Text);
                data.movePoint = Convert.ToInt32(txt_movepoint_mst.Text);
                data.basePrice = 0;
                sk = StrategyFactory.AddStrategy(data);

                txt_abSmarkey.Text = $"{sk}";
                richTextBox1.AppendText($"[{sk}]MST加入洗價\n");

            }
            catch (Exception exc)
            {


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //訂閱商品
            int sk = 0;
            try
            {
                string StockID = txt_DayTradecommodityidA.Text;

                if (string.IsNullOrEmpty(StockID))
                    return;

                //訂閱行情
                if (!DicSubStockList.ContainsKey(StockID))
                {
                    m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(StockID);
                    if (m_nCode == 0)
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]成功\n");
                        DicSubStockList.TryAdd(StockID, StockID);
                    }
                    else
                    {
                        richTextBox1.AppendText($"[SKQuoteLib_ReqStocks][{StockID}]失敗\n");
                        return;
                    }

                }

                //建立策略資料
                StrategyFactory data = new StrategyFactory();
                data.ID = "099";
                data.stockID = StockID;
                data.tradeKind = "2";
                // data.triggerPrice = Convert.ToDouble(txt_triggerprice.Text);
                // data.direction = cb_direction.SelectedIndex;
                data.bs = cb_DayTradebs.SelectedIndex;
                data.orderPriceTy = cb_DayTradeOrderPriceType.SelectedIndex;
                data.qty = Convert.ToInt32(txt_DayTradeqty.Text);
                data.orderCond = cb_DayTradeOrderCond.SelectedIndex;
                data.order_Type = cb_DayTradeOrder_Type.SelectedIndex;
                data.exchange_Code = cb_DayTradeExchange_Code.SelectedIndex;
                data.orderPrice = Convert.ToDouble(txt_DayTradeorderPrice.Text);
                data.outtriggerPrice= Convert.ToDouble(txt_Outtriggerprice.Text);

                sk = StrategyFactory.AddStrategy(data);

                txt_abSmarkey.Text = $"{sk}";
                richTextBox1.AppendText($"[{sk}]DayTrade加入洗價\n");

            }
            catch (Exception exc)
            {


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SKSTOCKLONG pSKStockLONG = new SKSTOCKLONG();

                pSKStockLONG.bstrStockNo = textBox2.Text;
                pSKStockLONG.nClose = Convert.ToInt32(textBox1.Text)*100;
                pSKStockLONG.sDecimal = 2;

                InfoFactory.QuoteQueue.Enqueue(pSKStockLONG);
                if(!InfoFactory.QuoteQueueEvent.WaitOne(0))
                {
                    InfoFactory.QuoteQueueEvent.Set();
                }

            }
            catch (Exception exc )
            {

                throw;
            }
        }
    }
}
