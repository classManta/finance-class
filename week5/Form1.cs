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
        private DataTable m_dtStocks;
        private DataTable m_dtBest5Ask;
        private DataTable m_dtBest5Bid;
        private int kMarketPrice = 0;//Constants.INT32_MIN + 1;//-2147483647;
        private int m_nSimulateStock;


        private DataTable CreateStocksDataTable()
        {
            DataTable myDataTable = new DataTable();

            DataColumn myDataColumn;

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nStockidx";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int16");
            myDataColumn.ColumnName = "m_sDecimal";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int16");
            myDataColumn.ColumnName = "m_sTypeNo";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_cMarketNo";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_caStockNo";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_caName";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nOpen";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nHigh";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nLow";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nClose";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nTickQty";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nRef";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            //myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_nBid";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nBc";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            //myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_nAsk";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nAc";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nTBc";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nTAc";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nFutureOI";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nTQty";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nYQty";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nUp";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nDown";
            myDataTable.Columns.Add(myDataColumn);

            //[-20210719-add-]//
            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nCloseS";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nTickQtyS";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            //myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_nBidS";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_nAskS";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Double");
            myDataColumn.ColumnName = "m_nOddLotPer";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();//[-20240508-Add]
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nDealTime";
            myDataTable.Columns.Add(myDataColumn);

            myDataTable.PrimaryKey = new DataColumn[] { myDataTable.Columns["m_caStockNo"] };

            return myDataTable;
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession) return;

            System.Reflection.PropertyInfo aProp =
                        typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        private DataTable CreateBest5AskTable()
        {
            DataTable myDataTable = new DataTable();

            DataColumn myDataColumn;

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "m_nAskQty";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "m_nAsk";
            myDataTable.Columns.Add(myDataColumn);

            return myDataTable;

        }
        private void OnUpDateDataRow(SKSTOCKLONG pStockLONG)
        {

            string strStockNo = pStockLONG.bstrStockNo;

            DataRow drFind = m_dtStocks.Rows.Find(strStockNo);
            if (drFind == null)
            {
                try
                {
                    DataRow myDataRow = m_dtStocks.NewRow();

                    myDataRow["m_nStockidx"] = pStockLONG.nStockIdx;
                    myDataRow["m_sDecimal"] = pStockLONG.sDecimal;
                    myDataRow["m_sTypeNo"] = pStockLONG.sTypeNo;
                    myDataRow["m_cMarketNo"] = pStockLONG.bstrMarketNo;
                    myDataRow["m_caStockNo"] = pStockLONG.bstrStockNo;
                    myDataRow["m_caName"] = pStockLONG.bstrStockName;
                    myDataRow["m_nOpen"] = pStockLONG.nOpen / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nHigh"] = pStockLONG.nHigh / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nLow"] = pStockLONG.nLow / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nClose"] = pStockLONG.nClose / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nTickQty"] = pStockLONG.nTickQty;
                    myDataRow["m_nRef"] = pStockLONG.nRef / (Math.Pow(10, pStockLONG.sDecimal));

                    if (pStockLONG.nBid == kMarketPrice)
                        myDataRow["m_nBid"] = "市價";
                    else
                        myDataRow["m_nBid"] = (pStockLONG.nBid / (Math.Pow(10, pStockLONG.sDecimal))).ToString();


                    myDataRow["m_nBc"] = pStockLONG.nBc;

                    if (pStockLONG.nAsk == kMarketPrice)
                        myDataRow["m_nAsk"] = "市價";
                    else
                        myDataRow["m_nAsk"] = (pStockLONG.nAsk / (Math.Pow(10, pStockLONG.sDecimal))).ToString();


                    m_nSimulateStock = pStockLONG.nSimulate;                 //成交價/買價/賣價;揭示
                    myDataRow["m_nAc"] = pStockLONG.nAc;
                    myDataRow["m_nTBc"] = pStockLONG.nTBc;
                    myDataRow["m_nTAc"] = pStockLONG.nTAc;
                    myDataRow["m_nFutureOI"] = pStockLONG.nFutureOI;
                    myDataRow["m_nTQty"] = pStockLONG.nTQty;
                    myDataRow["m_nYQty"] = pStockLONG.nYQty;
                    myDataRow["m_nUp"] = pStockLONG.nUp / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nDown"] = pStockLONG.nDown / (Math.Pow(10, pStockLONG.sDecimal));
                    myDataRow["m_nDealTime"] = pStockLONG.nDealTime;//[-20240508-Add]
                    if (pStockLONG.bstrMarketNo == "5" || pStockLONG.bstrMarketNo == "6")
                    {
                        if (m_nSimulateStock == 1) //試算揭示//
                        {
                            myDataRow["m_nCloseS"] = pStockLONG.nClose / (Math.Pow(10, pStockLONG.sDecimal));//"試撮成交價";
                            myDataRow["m_nTickQtyS"] = pStockLONG.nTickQty;//"試撮單量";
                            myDataRow["m_nBidS"] = (pStockLONG.nBid / (Math.Pow(10, pStockLONG.sDecimal))).ToString();//"試撮買價";
                            myDataRow["m_nAskS"] = (pStockLONG.nAsk / (Math.Pow(10, pStockLONG.sDecimal))).ToString();//"試撮賣價";
                        }
                    }
                    m_dtStocks.Rows.Add(myDataRow);

                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                }
            }
            else
            {
                drFind["m_nStockidx"] = pStockLONG.nStockIdx;
                drFind["m_sDecimal"] = pStockLONG.sDecimal;
                drFind["m_sTypeNo"] = pStockLONG.sTypeNo;
                drFind["m_cMarketNo"] = pStockLONG.bstrMarketNo;
                drFind["m_caStockNo"] = pStockLONG.bstrStockNo;
                drFind["m_caName"] = pStockLONG.bstrStockName;
                drFind["m_nOpen"] = pStockLONG.nOpen / (Math.Pow(10, pStockLONG.sDecimal));
                drFind["m_nHigh"] = pStockLONG.nHigh / (Math.Pow(10, pStockLONG.sDecimal));
                drFind["m_nLow"] = pStockLONG.nLow / (Math.Pow(10, pStockLONG.sDecimal));
                drFind["m_nClose"] = pStockLONG.nClose / (Math.Pow(10, pStockLONG.sDecimal));
                drFind["m_nTickQty"] = pStockLONG.nTickQty;
                drFind["m_nRef"] = pStockLONG.nRef / (Math.Pow(10, pStockLONG.sDecimal));

                if (pStockLONG.nBid == kMarketPrice)
                    drFind["m_nBid"] = "市價";
                else
                    drFind["m_nBid"] = (pStockLONG.nBid / (Math.Pow(10, pStockLONG.sDecimal))).ToString();


                drFind["m_nBc"] = pStockLONG.nBc;

                if (pStockLONG.nAsk == kMarketPrice)
                    drFind["m_nAsk"] = "市價";
                else
                    drFind["m_nAsk"] = (pStockLONG.nAsk / (Math.Pow(10, pStockLONG.sDecimal))).ToString();


                drFind["m_nAc"] = pStockLONG.nAc;
                drFind["m_nTBc"] = pStockLONG.nTBc;
                drFind["m_nTAc"] = pStockLONG.nTAc;
                drFind["m_nFutureOI"] = pStockLONG.nFutureOI;
                drFind["m_nTQty"] = pStockLONG.nTQty;
                drFind["m_nYQty"] = pStockLONG.nYQty;
                drFind["m_nUp"] = pStockLONG.nUp / (Math.Pow(10, pStockLONG.sDecimal));
                drFind["m_nDown"] = pStockLONG.nDown / (Math.Pow(10, pStockLONG.sDecimal));
                m_nSimulateStock = pStockLONG.nSimulate;                 //成交價/買價/賣價;揭示
                drFind["m_nDealTime"] = pStockLONG.nDealTime;//[-20240508-Add]

                if (pStockLONG.bstrMarketNo == "5" || pStockLONG.bstrMarketNo == "6")
                {
                    if (m_nSimulateStock == 1) //試算揭示//
                    {
                        drFind["m_nCloseS"] = pStockLONG.nClose / (Math.Pow(10, pStockLONG.sDecimal));//"試撮成交價";
                        drFind["m_nTickQtyS"] = pStockLONG.nTickQty;//"試撮單量";
                        drFind["m_nBidS"] = (pStockLONG.nBid / (Math.Pow(10, pStockLONG.sDecimal))).ToString();//"試撮買價";
                        drFind["m_nAskS"] = (pStockLONG.nAsk / (Math.Pow(10, pStockLONG.sDecimal))).ToString();//"試撮賣價";
                    }
                }


            }
        }

        int m_nCode;
        SKCenterLib m_pSKCenter;
        SKQuoteLib m_SKQuote;
        string m_strUserID;

        void OnLoginMessage(string strUserID, string strStatusCode, string strMessage)
        {
            if (strStatusCode == "0")//成功
            {
                richTextBox1.AppendText("[OnLoginMessage]" + strUserID + " 登入成功!" + "\n");
                m_strUserID = strUserID;
            }
            else
            {
                richTextBox1.AppendText("[OnLoginMessage]" + strUserID + "登入失敗!狀態碼： " + strStatusCode + "錯誤訊息： " + strMessage + "\n");
            }
        }

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
        void m_SKQuoteLib_OnNotifyQuote(short sMarketNo, string strStockNo)
        {
            SKSTOCKLONG pSKStockLONG = new SKSTOCKLONG();
            m_SKQuote.SKQuoteLib_GetStockByMarketAndNo(sMarketNo, strStockNo, ref pSKStockLONG);

            OnUpDateDataRow(pSKStockLONG);
        }
        void m_SKQuoteLib_OnNotifyHistoryTicks(short sMarketNo, string strStockNo, int nPtr, int nDate, int lTimehms, int lTimemillismicros, int nBid, int nAsk, int nClose, int nQty, int nSimulate)
        {
            //[-0219-add Qty-]
            string strData = "";
            strData = strStockNo.ToString() + "," + nPtr.ToString() + "," + nDate.ToString() + " " + lTimehms.ToString() + " " + lTimemillismicros.ToString() + "," + nBid.ToString() + "," + nAsk.ToString() + "," + nClose.ToString() + "," + nQty.ToString();

            listTicks.Items.Add("[OnNotifyHistoryTickLONG]" + strData);
        }
        void m_SKQuoteLib_OnNotifyTicks(short sMarketNo, string strStockNo, int nPtr, int nDate, int lTimehms, int lTimemillismicros, int nBid, int nAsk, int nClose, int nQty, int nSimulate)
        {
            //M價轉換與TS是否含msns一致//
            string strData = "";
            int nMarketPrice = kMarketPrice;

            strData = strStockNo.ToString() + "," + nPtr.ToString() + "," + nDate.ToString() + " " + lTimehms.ToString() + " " + lTimemillismicros.ToString() + "," + nBid.ToString() + "," + nAsk.ToString() + "," + nClose.ToString() + "," + nQty.ToString();

            listTicks.Items.Add("[OnNotifyTicksLONG]" + strData);
        }
        void m_SKQuoteLib_OnNotifyBest5(short sMarketNo, string bstrStockNo, int nBestBid1, int nBestBidQty1, int nBestBid2, int nBestBidQty2, int nBestBid3, int nBestBidQty3, int nBestBid4, int nBestBidQty4, int nBestBid5, int nBestBidQty5, int nExtendBid, int nExtendBidQty, int nBestAsk1, int nBestAskQty1, int nBestAsk2, int nBestAskQty2, int nBestAsk3, int nBestAskQty3, int nBestAsk4, int nBestAskQty4, int nBestAsk5, int nBestAskQty5, int nExtendAsk, int nExtendAskQty, int nSimulate)
        {
            //0:一般;1:試算揭示
            if (nSimulate == 0)
            {
                GridBest5Ask.ForeColor = Color.Black;
                GridBest5Bid.ForeColor = Color.Black;
            }
            else
            {
                GridBest5Ask.ForeColor = Color.Gray;
                GridBest5Bid.ForeColor = Color.Gray;
            }

            double dDigitNum = 0.000;
            string strStockNoTick = txtTick.Text.Trim();

            dDigitNum = 100.00;//default value

            if (m_dtBest5Ask.Rows.Count == 0 && m_dtBest5Bid.Rows.Count == 0)
            {
                DataRow myDataRow;

                myDataRow = m_dtBest5Ask.NewRow();
                myDataRow["m_nAskQty"] = nBestAskQty1;
                if (nBestAsk1 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestAsk1 / dDigitNum).ToString();///100.00;
                m_dtBest5Ask.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Ask.NewRow();
                myDataRow["m_nAskQty"] = nBestAskQty2;

                if (nBestAsk2 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestAsk2 / dDigitNum).ToString();//100.00;
                m_dtBest5Ask.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Ask.NewRow();
                myDataRow["m_nAskQty"] = nBestAskQty3;

                if (nBestAsk3 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestAsk3 / dDigitNum).ToString();//100.00;
                m_dtBest5Ask.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Ask.NewRow();
                myDataRow["m_nAskQty"] = nBestAskQty4;

                if (nBestAsk4 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestAsk4 / dDigitNum).ToString();// 100.00;
                m_dtBest5Ask.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Ask.NewRow();
                myDataRow["m_nAskQty"] = nBestAskQty5;

                if (nBestAsk5 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestAsk5 / dDigitNum).ToString();// 100.00;
                m_dtBest5Ask.Rows.Add(myDataRow);



                myDataRow = m_dtBest5Bid.NewRow();
                myDataRow["m_nAskQty"] = nBestBidQty1;

                if (nBestBid1 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else myDataRow["m_nAsk"] = (nBestBid1 / dDigitNum).ToString();
                m_dtBest5Bid.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Bid.NewRow();
                myDataRow["m_nAskQty"] = nBestBidQty2;
                if (nBestBid2 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else myDataRow["m_nAsk"] = (nBestBid2 / dDigitNum).ToString();
                m_dtBest5Bid.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Bid.NewRow();
                myDataRow["m_nAskQty"] = nBestBidQty3;
                if (nBestBid3 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestBid3 / dDigitNum).ToString();
                m_dtBest5Bid.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Bid.NewRow();
                myDataRow["m_nAskQty"] = nBestBidQty4;
                if (nBestBid4 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestBid4 / dDigitNum).ToString();
                m_dtBest5Bid.Rows.Add(myDataRow);

                myDataRow = m_dtBest5Bid.NewRow();
                myDataRow["m_nAskQty"] = nBestBidQty5;
                if (nBestBid5 == kMarketPrice)
                    myDataRow["m_nAsk"] = "M";
                else
                    myDataRow["m_nAsk"] = (nBestBid5 / dDigitNum).ToString();
                m_dtBest5Bid.Rows.Add(myDataRow);

            }
            else
            {
                m_dtBest5Ask.Rows[0]["m_nAskQty"] = nBestAskQty1;
                if (nBestAsk1 == kMarketPrice) m_dtBest5Ask.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Ask.Rows[0]["m_nAsk"] = (nBestAsk1 / dDigitNum).ToString();

                m_dtBest5Ask.Rows[1]["m_nAskQty"] = nBestAskQty2;
                if (nBestAsk2 == kMarketPrice) m_dtBest5Ask.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Ask.Rows[1]["m_nAsk"] = (nBestAsk2 / dDigitNum).ToString();

                m_dtBest5Ask.Rows[2]["m_nAskQty"] = nBestAskQty3;
                if (nBestAsk3 == kMarketPrice) m_dtBest5Ask.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Ask.Rows[2]["m_nAsk"] = (nBestAsk3 / dDigitNum).ToString();

                m_dtBest5Ask.Rows[3]["m_nAskQty"] = nBestAskQty4;
                if (nBestAsk4 == kMarketPrice) m_dtBest5Ask.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Ask.Rows[3]["m_nAsk"] = (nBestAsk4 / dDigitNum).ToString();

                m_dtBest5Ask.Rows[4]["m_nAskQty"] = nBestAskQty5;
                if (nBestAsk5 == kMarketPrice) m_dtBest5Ask.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Ask.Rows[4]["m_nAsk"] = (nBestAsk5 / dDigitNum).ToString();


                m_dtBest5Bid.Rows[0]["m_nAskQty"] = nBestBidQty1;
                if (nBestBid1 == kMarketPrice) m_dtBest5Bid.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Bid.Rows[0]["m_nAsk"] = (nBestBid1 / dDigitNum).ToString();

                m_dtBest5Bid.Rows[1]["m_nAskQty"] = nBestBidQty2;
                if (nBestBid2 == kMarketPrice) m_dtBest5Bid.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Bid.Rows[1]["m_nAsk"] = (nBestBid2 / dDigitNum).ToString();

                m_dtBest5Bid.Rows[2]["m_nAskQty"] = nBestBidQty3;
                if (nBestBid3 == kMarketPrice) m_dtBest5Bid.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Bid.Rows[2]["m_nAsk"] = (nBestBid3 / dDigitNum).ToString();

                m_dtBest5Bid.Rows[3]["m_nAskQty"] = nBestBidQty4;
                if (nBestBid4 == kMarketPrice) m_dtBest5Bid.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Bid.Rows[3]["m_nAsk"] = (nBestBid4 / dDigitNum).ToString();

                m_dtBest5Bid.Rows[4]["m_nAskQty"] = nBestBidQty5;
                if (nBestBid5 == kMarketPrice) m_dtBest5Bid.Rows[0]["m_nAsk"] = "M";
                else m_dtBest5Bid.Rows[4]["m_nAsk"] = (nBestBid5 / dDigitNum).ToString();
            }

        }

        void m_SKQuoteLib_OnNotifyCommodityListWithTypeNo(short sMarketNo, string bstrStockListData)
        {

            string strData = "";
            strData = "[OnNotifyCommodityList]" + bstrStockListData;

            StockList.Items.Add(strData);

            Size size = TextRenderer.MeasureText(bstrStockListData, StockList.Font);
            if (StockList.HorizontalExtent < size.Width)
                StockList.HorizontalExtent = size.Width + 200;
        } 
        public Form1()
        {
            InitializeComponent();
            m_pSKCenter = new SKCenterLib();
            m_SKQuote = new SKQuoteLib();

            m_pSKCenter.OnLoginMessage += new _ISKCenterLibEvents_OnLoginMessageEventHandler(this.OnLoginMessage);
            m_SKQuote.OnConnection += new _ISKQuoteLibEvents_OnConnectionEventHandler(m_SKQuoteLib_OnConnection);
            m_SKQuote.OnNotifyQuoteLONG += new _ISKQuoteLibEvents_OnNotifyQuoteLONGEventHandler(m_SKQuoteLib_OnNotifyQuote);

            m_SKQuote.OnNotifyHistoryTicksLONG += new _ISKQuoteLibEvents_OnNotifyHistoryTicksLONGEventHandler(m_SKQuoteLib_OnNotifyHistoryTicks);
            m_SKQuote.OnNotifyTicksLONG += new _ISKQuoteLibEvents_OnNotifyTicksLONGEventHandler(m_SKQuoteLib_OnNotifyTicks);
            m_SKQuote.OnNotifyBest5LONG += new _ISKQuoteLibEvents_OnNotifyBest5LONGEventHandler(m_SKQuoteLib_OnNotifyBest5);
            m_SKQuote.OnNotifyCommodityListWithTypeNo += new _ISKQuoteLibEvents_OnNotifyCommodityListWithTypeNoEventHandler(m_SKQuoteLib_OnNotifyCommodityListWithTypeNo);

        }

        private void button1Login_Click(object sender, EventArgs e)
        {
            int nSeqId = 0;
            m_nCode = m_pSKCenter.SKCenterLib_SocketLogin(ref nSeqId, textBox1LoginID.Text.Trim().ToUpper(), textBox2Password.Text.Trim());
            if (m_nCode == 0)
            {
                richTextBox1.AppendText("[SKCenterLib_SocketLogin]" + textBox1LoginID.Text.Trim() + " 呼叫登入函式" + "\n");
            }
            else
            {
                richTextBox1.AppendText("[SKCenterLib_SocketLogin]" + textBox1LoginID.Text.Trim() + " 呼叫登入函式失敗!錯誤代碼:" + m_nCode + "\n");
            }
        }

        private void buttonEnterMonitorLONG_Click(object sender, EventArgs e)
        {
            m_nCode = m_SKQuote.SKQuoteLib_EnterMonitorLONG();
            if (m_nCode == 0)
            {
                richTextBox1.AppendText(textBox1LoginID.Text.Trim() + " 呼叫連線函式成功" + "\n");
            }
            else
            {
                richTextBox1.AppendText(textBox1LoginID.Text.Trim() + " 呼叫連線函式失敗" + m_nCode + "\n");
            }
        }

        private void btnQueryStocks_Click(object sender, EventArgs e)
        {
            m_dtStocks.Clear();
            gridStocks.ClearSelection();

            gridStocks.DataSource = m_dtStocks;

            gridStocks.Columns["m_nStockidx"].Visible = false;
            gridStocks.Columns["m_sDecimal"].Visible = false;
            gridStocks.Columns["m_sTypeNo"].Visible = false;
            gridStocks.Columns["m_cMarketNo"].Visible = false;
            gridStocks.Columns["m_caStockNo"].HeaderText = "代碼";
            gridStocks.Columns["m_caName"].HeaderText = "名稱";
            gridStocks.Columns["m_nOpen"].HeaderText = "開盤價";
            //gridStocks.Columns["m_nHigh"].Visible = false;
            gridStocks.Columns["m_nHigh"].HeaderText = "最高";
            //gridStocks.Columns["m_nLow"].Visible = false;
            gridStocks.Columns["m_nLow"].HeaderText = "最低";
            gridStocks.Columns["m_nClose"].HeaderText = "成交價";
            gridStocks.Columns["m_nTickQty"].HeaderText = "單量";
            gridStocks.Columns["m_nRef"].HeaderText = "昨收價";
            gridStocks.Columns["m_nBid"].HeaderText = "買價";
            //gridStocks.Columns["m_nBc"].Visible = false;
            gridStocks.Columns["m_nBc"].HeaderText = "買量";
            gridStocks.Columns["m_nAsk"].HeaderText = "賣價";
            //gridStocks.Columns["m_nAc"].Visible = false;
            gridStocks.Columns["m_nAc"].HeaderText = "賣量";
            //gridStocks.Columns["m_nTBc"].Visible = false;
            gridStocks.Columns["m_nTBc"].HeaderText = "買盤量";
            //gridStocks.Columns["m_nTAc"].Visible = false;
            gridStocks.Columns["m_nTAc"].HeaderText = "賣盤量";
            gridStocks.Columns["m_nFutureOI"].Visible = false;
            //gridStocks.Columns["m_nTQty"].Visible = false;
            gridStocks.Columns["m_nTQty"].HeaderText = "總量";
            //gridStocks.Columns["m_nYQty"].Visible = false;
            gridStocks.Columns["m_nYQty"].HeaderText = "昨量";
            //gridStocks.Columns["m_nUp"].Visible = false;
            gridStocks.Columns["m_nUp"].HeaderText = "漲停";
            //gridStocks.Columns["m_nDown"].Visible = false;
            gridStocks.Columns["m_nDown"].HeaderText = "跌停";
            gridStocks.Columns["m_nDealTime"].HeaderText = "成交時間";//[-20240508-Add]

            gridStocks.Columns[0].Frozen = true;

            m_nCode = m_SKQuote.SKQuoteLib_ReqStocks(txtStocks.Text.Trim());
            richTextBox1.AppendText("[SKQuoteLib_ReqStocks]" +  m_nCode + "\n");
        }

        private void btnCancelStocks_Click(object sender, EventArgs e)
        {
            m_nCode = m_SKQuote.SKQuoteLib_CancelRequestStocks(txtStocks.Text.Trim());
            richTextBox1.AppendText("[SKQuoteLib_CancelRequestStocks]" + m_nCode + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dtStocks = CreateStocksDataTable();
            m_dtBest5Ask = CreateBest5AskTable();
            m_dtBest5Bid = CreateBest5AskTable();
            SetDoubleBuffered(gridStocks);
        }

        private void btnTicks_Click(object sender, EventArgs e)
        {
            short sPage;

            if (short.TryParse(txtTickPageNo.Text, out sPage) == false)
                return;
            listTicks.Items.Clear();
            m_dtBest5Ask.Clear();
            m_dtBest5Bid.Clear();
            GridBest5Ask.DataSource = m_dtBest5Ask;
            GridBest5Bid.DataSource = m_dtBest5Bid;

            GridBest5Ask.Columns["m_nAskQty"].HeaderText = "張數";
            GridBest5Ask.Columns["m_nAskQty"].Width = 60;
            GridBest5Ask.Columns["m_nAsk"].HeaderText = "賣價";
            GridBest5Ask.Columns["m_nAsk"].Width = 60;

            GridBest5Bid.Columns["m_nAskQty"].HeaderText = "張數";
            GridBest5Bid.Columns["m_nAskQty"].Width = 60;
            GridBest5Bid.Columns["m_nAsk"].HeaderText = "買價";
            GridBest5Bid.Columns["m_nAsk"].Width = 60;

            m_nCode = m_SKQuote.SKQuoteLib_RequestTicks(ref sPage, txtTick.Text.Trim());
            richTextBox1.AppendText("[SKQuoteLib_RequestTicks]" + m_nCode + "\n");
        }

        private void btnTickStop_Click(object sender, EventArgs e)
        {
            m_nCode = m_SKQuote.SKQuoteLib_CancelRequestTicks(txtTick.Text.Trim());
            richTextBox1.AppendText("[SKQuoteLib_CancelRequestTicks]" + m_nCode + "\n");
        }

        private void RequestStockListBtn_Click(object sender, EventArgs e)
        {
            StockList.Items.Clear();
            short sMarketNo = Convert.ToInt16(MarketNo_txt.Text.Trim());

            m_nCode = m_SKQuote.SKQuoteLib_RequestStockList(sMarketNo);
            richTextBox1.AppendText("[SKQuoteLib_RequestStockList]" + m_nCode + "\n");
        }
    }
}
