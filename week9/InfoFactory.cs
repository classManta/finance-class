using SKCOMLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COMSample1
{
    internal class InfoFactory
    {
        public static ConcurrentQueue<SKSTOCKLONG> QuoteQueue = new ConcurrentQueue<SKSTOCKLONG>();
        public static ManualResetEvent QuoteQueueEvent = new ManualResetEvent(false);

        /// <summary>
        /// 行情程序
        /// </summary>
        public static void Start()
        {
            try
            {
                Thread threaQuote = new Thread(new ThreadStart(ParseQuote));
                threaQuote.IsBackground = true;
                threaQuote.Start();

            }
            catch (Exception exc )
            {

                
            }
     

        }
        /// <summary>
        /// 解析行情
        /// </summary>
        public static void ParseQuote()
        {
            while (true)
            {
                try
                {
                    while (QuoteQueue.TryDequeue(out SKSTOCKLONG QuoteObj))
                    {
                        double dealPrice = QuoteObj.nClose / (Math.Pow(10, QuoteObj.sDecimal));

                        Console.WriteLine($" Simulate[{QuoteObj.nSimulate}] StockNo[{QuoteObj.bstrStockNo}] StockName[{QuoteObj.bstrStockName}] DealPrice[{dealPrice}]");
                        //非試算揭示
                        if(QuoteObj.nSimulate==0)
                        {
                            if (dealPrice > 0)
                            {
                                //洗價
                                if (StrategyFactory.DicStrategyList.TryGetValue(QuoteObj.bstrStockNo, out SortedDictionary<int, StrategyFactory> _dicStrategy))
                                {
                                    foreach (var item in _dicStrategy)
                                    {
                                        if (!item.Value.isTriggerFlag)
                                        {
                                            item.Value.DoProcess(QuoteObj);
                                        }
                                    }
                                }
                            }

                        }
                    }
                    QuoteQueueEvent.Reset();
                    QuoteQueueEvent.WaitOne();
                }
                catch (Exception exc )
                {

                 
                }             
            }
        }













    }
}
