using SKCOMLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMSample1
{
    internal class OrderFactory
    {
        public static ConcurrentDictionary<int, int> DicOrderMap = new ConcurrentDictionary<int, int>(); //下單號碼，智慧單號
        public static ConcurrentDictionary<int, string> DicSmartKeyOrderMap = new ConcurrentDictionary<int, string>(); //智慧單號，委託書號

        public static ConcurrentQueue<StrategyFactory> OrderQueue = new ConcurrentQueue<StrategyFactory>();
        public static ManualResetEvent OrderQueueEvent = new ManualResetEvent(false);


        public static void Start()
        {
            try
            {
                Thread threaQuote = new Thread(new ThreadStart(SendOrder));
                threaQuote.IsBackground = true;
                threaQuote.Start();
            }
            catch (Exception exc )
            {

                
            }
        }

        public static void AddOrder(StrategyFactory vData)
        {
            try
            {
                OrderQueue.Enqueue(vData);
                if(!OrderQueueEvent.WaitOne(0))
                {
                    OrderQueueEvent.Set();
                }
            }
            catch (Exception exc )
            {

                
            }
        }


        public static void SendOrder()
        {
            while (true)
            {
                try
                {
                    while (OrderQueue.TryDequeue(out StrategyFactory vData))
                    {

                        string strStockNo;
                        int nBidAsk;
                        string strPrice;
                        int nQty;
                        string strComment;

                    
                        strStockNo = vData.stockID;                     
                        nBidAsk = vData.bs;                                              
                        strPrice = vData.orderPrice.ToString();
                        nQty = vData.qty;
                       

                        strComment = "";

                        int nSeqId = 0;


                       int m_nCode = FrmSmartTrade.m_SKOrder.SendStockSocketOrder(ref nSeqId, vData.ID, strStockNo, nBidAsk, strPrice, nQty, strComment);

                        if (m_nCode == 0)
                        {
                            DicOrderMap.TryAdd(nSeqId, vData.smartKey); //如果要用smarkey帶刪單
                            //richTextBox1.AppendText("[SendStockSocketOrder]" + m_strUserID + " 呼叫下單函式" + "\n");
                        }
                        else
                        {
                            //richTextBox1.AppendText("[SendStockSocketOrder]" + m_strUserID + " 呼叫下單函式失敗!錯誤代碼:" + m_nCode + "\n");
                        }

                    }
                    OrderQueueEvent.Reset();
                    OrderQueueEvent.WaitOne();
                }
                catch (Exception exc)
                {


                }
            }
         

        }






        public OrderFactory()
        {


        }



    }
}
