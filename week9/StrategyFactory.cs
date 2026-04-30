using SKCOMLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMSample1
{
    internal class StrategyFactory
    {
        public static int Smartkey = 0;
        public static object SmartkeyObj = new object();
        //key :StockID
        public static ConcurrentDictionary<string, SortedDictionary<int, StrategyFactory>> DicStrategyList = new ConcurrentDictionary<string, SortedDictionary<int, StrategyFactory>>();
        public static ConcurrentDictionary<int, string> DicStrategyStockMap = new ConcurrentDictionary<int, string>();
        public static ConcurrentDictionary<int, string> DicStrategyOrderIDMap = new ConcurrentDictionary<int, string>();
        /// <summary>
        /// 加入洗價清單
        /// </summary>
        /// <param name="vData"></param>
        /// <returns></returns>
        public static int AddStrategy(StrategyFactory vData)
        {
            try
            {
                lock (SmartkeyObj)
                {
                    Smartkey++;

                    vData.smartKey = Smartkey;
                    if (DicStrategyList.ContainsKey(vData.stockID))
                    {
                        if (!DicStrategyList[vData.stockID].ContainsKey(Smartkey))
                        {
                            DicStrategyList[vData.stockID].Add(Smartkey, vData);
                        }
                    }
                    else
                    {
                        SortedDictionary<int, StrategyFactory> tmpSlist = new SortedDictionary<int, StrategyFactory>();                       
                        tmpSlist.Add(Smartkey, vData);
                        DicStrategyList.TryAdd(vData.stockID, tmpSlist);
                    }

                    DicStrategyStockMap.TryAdd(Smartkey, vData.stockID);

                    //當沖進場單下單
                    if(vData.tradeKind=="2")
                    {
                        //先送一張委託
                        OrderFactory.OrderQueue.Enqueue(vData);
                        if (!OrderFactory.OrderQueueEvent.WaitOne(0))
                        {
                            OrderFactory.OrderQueueEvent.Set();
                        }
                    }

                    //test

                }

            }
            catch (Exception exc)
            {


            }

            return Smartkey;
        }

        public string ID = "";         //下單帳號
        public int smartKey = 0;       //智慧單號
        public string stockID = "";    //股票代號
        public string tradeKind = "";  //0:MIT 1:MST 2:DayTrade
        public double triggerPrice = 0; //觸發價
        public int direction = 0;//觸發方向 0:大於等於 1:小於等於

        public int bs = 0; //買賣別 0:買 1:賣
        public int orderPriceTy = 0;//委託價類型 0:市價 1 :限價 
        public double orderPrice = 0; //委託價格 
        public int qty = 0;//委託數量
        public int orderCond = 0;// 委託時效 0:ROD 1:IOC 2:FOK
        public int order_Type = 0; //0:現股 1:融資 2:融券 3:無券賣
        public int exchange_Code = 0;// 0:一般

        public string orderID = ""; //下單委託書號
        public bool isTriggerFlag = false; //觸發註記

        public int movePoint = 0; //移動點數-MST用
        public double basePrice = 0; //觸發基準價-MST用
        public double markePrice = 0; //市價

        //當沖單
        public double outtriggerPrice = 0; //出場觸發價
        public int inOutFlag = 0 ; //0:進場 1:出場
        

        public StrategyFactory()
        {

        }

        /// <summary>
        /// 洗價
        /// </summary>
        /// <param name="QuoteObj"></param>
        public void DoProcess(SKSTOCKLONG QuoteObj)
        {
            try
            {
                int _Signal = 0;
                double dealPrice = QuoteObj.nClose / (Math.Pow(10, QuoteObj.sDecimal));
                FrmSmartTrade.AddMessage($"行情：{dealPrice} ");
                switch (tradeKind)
                {
                    case "0": //MIT
                        _Signal = direction == 1 ? -1 : 1;  //判斷觸價方向
                        if (dealPrice * _Signal >= triggerPrice * _Signal)
                        {
                            isTriggerFlag = true;
                            //觸發後帶下單
                            OrderFactory.AddOrder(this);
                            FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 觸發");
                        }
                        break;
                    case "1": //MST

                        int nTick = (bs == 0 ? Convert.ToInt32(movePoint) : Convert.ToInt32(movePoint * -1));  //買 +tick 賣 -tick
                        _Signal = bs == 1 ? -1 : 1;  //判斷觸價方向 B 1 S-1 買>大於等於 賣>小於等於
                        if (basePrice != 0)
                        {
                          
                            if (dealPrice * _Signal >= triggerPrice * _Signal)
                            {
                                isTriggerFlag = true;
                                //觸發後帶下單
                                OrderFactory.AddOrder(this);
                                FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 觸發");

                            }
                            else
                            {
                                //觸發價移動判斷(當下市價與上一次市價
                                if (dealPrice * _Signal < basePrice * _Signal) //買單 價格跌時移動(跟跌不跟漲)，賣單價格漲的時候移動(跟漲不跟跌)
                                {
                                    //更新觸發價與記憶體市價
                                    FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 更新觸發價OLD{triggerPrice}");                                    
                                    decimal tmpprice = Convert.ToDecimal(dealPrice);
                                    triggerPrice = Convert.ToDouble(PriceNTick(tmpprice, nTick, stockID));
                                    basePrice = dealPrice;
                                    FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 更新觸發價NEW{triggerPrice}");
                                }
                            }
                        }
                        else
                        {
                            //計算第一次觸發價
                            basePrice = dealPrice;                          
                            triggerPrice = Convert.ToDouble(PriceNTick(Convert.ToDecimal( basePrice), nTick, stockID));
                            
                            FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 更新觸發價{triggerPrice}");
                        }
                        break;
                    case "2": //當沖                        
                        //出場中才加入洗價
                        if(inOutFlag==1)
                        {
                            _Signal = bs == 1 ? -1 : 1;  //判斷觸價方向 B 1 S-1 買>大於等於 賣>小於等於
                            if (dealPrice * _Signal >= outtriggerPrice * _Signal)
                            {
                                isTriggerFlag = true;
                                //觸發後帶下單
                                switch (this.bs)
                                {
                                    case 0:
                                        this.bs = 1;
                                        break;
                                    case 1:
                                        this.bs = 0;
                                        break;
                                    default:
                                        break;
                                }
                                this.orderPrice = outtriggerPrice;

                                OrderFactory.AddOrder(this);
                                FrmSmartTrade.AddMessage($"智慧單號：{smartKey} 出場觸發");
                            }
                        }
                        break;
                    default:
                        break;
                }





            }
            catch (Exception exc)
            {


            }
        }


        public static decimal PriceNTick(decimal Price, int nTick, string vStockID)
        {
            int GapIdx = 0;
            int sTick = nTick;
            decimal newPrice = Price;
            decimal[] priceGap;
            decimal[] tickGap;
            const decimal PriceNull = -999999;

            //ETF
            if (vStockID.IndexOf("00") == 0)
            {
                priceGap = new decimal[] { 50, 100000 };
                tickGap = new decimal[] { 0.01M, 0.05M };
            }
            else if (vStockID[0] >= '0' && vStockID[0] <= '9')// if (p.priceGap)
            {
                priceGap = new decimal[] { 10, 50, 100, 500, 1000, 100000 };
                tickGap = new decimal[] { 0.01M, 0.05M, 0.10M, 0.50M, 1.00M, 5.00M };
            }
            else
            {
                priceGap = new decimal[] { 100000 };
                tickGap = new decimal[] { 1M };
            }



            try
            {
                if (nTick > 0)
                {
                    while (Price >= priceGap[GapIdx])
                        GapIdx++;
                    while (sTick > 0)
                    {
                        newPrice = Price + (sTick * tickGap[GapIdx]);
                        //超過tick範圍
                        if (newPrice > priceGap[GapIdx])
                        {
                            //ymca Variables.DEF_FLOAT
                            sTick = sTick - (int)((priceGap[GapIdx] - Price) / tickGap[GapIdx]);
                            Price = priceGap[GapIdx];
                            if (++GapIdx >= tickGap.Length)
                            {
                                // Logger.ErrorLog($"PriceNTick ID[{ProductID}] Price[{Price}] nTick[{nTick}] GapIdx[{GapIdx}] ERROR msg[陣列索引超過範圍]");
                                return PriceNull;
                            }
                        }
                        else
                        {
                            Price = newPrice;
                            break;
                        }
                    }
                }
                else
                {
                    while (Price > priceGap[GapIdx])
                        GapIdx++;
                    while (sTick < 0)
                    {
                        newPrice = Price + (sTick * tickGap[GapIdx]);
                        if (GapIdx > 0 && newPrice < priceGap[GapIdx - 1])
                        {
                            //ymca Variables.DEF_FLOAT
                            sTick = sTick + (int)((Price - priceGap[GapIdx - 1]) / tickGap[GapIdx]);
                            Price = priceGap[GapIdx - 1];
                            --GapIdx;
                            //if (--GapIdx < 1)
                            //{
                            //    Logger.SendLogAsync($"PriceNTick ERROR ProductID[{ProductID}] Price[{Price}] nTick[{nTick}] msg[陣列索引超過範圍]", _Kind: "ERROR");
                            //    return -999999;
                            //}
                        }
                        else
                        {
                            Price = newPrice;
                            break;
                        }
                    }
                }
                //if (newPrice > Puplim)
                //    Price = Puplim;
                //else if (newPrice < Pdownlim)
                //    Price = Pdownlim;

                return Price;
            }
            catch (Exception e)
            {
                //Logger.ErrorLog($"PriceNTick ERROR MarketNo[M{MarketNo}] ProductID[{ProductID}] Price[{Price}] nTick[{nTick}] msg[{e.ToString()}]");
                return PriceNull;
            }
        }//PriceNTick
    }
}
