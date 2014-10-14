using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.model
{
    class TransactionRecord
    {
        private String currency;//币种
        private String stockName;//证券名称
        private String transactionDate;//成交日期
        private Double transactionPrice;//成交价格
        private Int32 transactionVolumn;//成交数量
        private Double transactionAmount;//发生金额
        private Double fundBalance;//资金余额
        private String contractNumber;//合同编号
        private String bussinessName;//业务名称
        private Double commmisionCharge;//手续费
        private Double stampTax;//印花税
        private Double transferFee;//过户费
        private Double clearingFee;//结算费
        private String stockCode;//证券代码
        private String shareholderCode;//股东代码


        public TransactionRecord(String currency, String stockName, String transactionDate, Double transactionPrice, Int32 transactionVolumn, Double transactionAmount, Double fundBalance,
            String contractNumber, String bussinessName, Double commmisionCharge, Double stampTax, Double transferFee, Double clearingFee, String stockCode, String shareholderCode)
        {
            this.currency = currency;
            this.stockName = stockName;
            this.transactionDate = transactionDate;
            this.transactionPrice = transactionPrice;
            this.transactionVolumn = transactionVolumn;
            this.fundBalance = fundBalance;
            this.contractNumber = contractNumber;
            this.bussinessName = bussinessName;
            this.commmisionCharge = commmisionCharge;
            this.stampTax = stampTax;
            this.transferFee = transferFee;
            this.clearingFee = clearingFee;
            this.stockCode = stockCode;
            this.shareholderCode = shareholderCode;
        }

        public TransactionRecord(){
        }

        public String Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public String StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }

        public String TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }

        public double TransactionPrice
        {
            get { return transactionPrice; }
            set { transactionPrice = value; }
        }

        public int TransactionVolumn
        {
            get { return transactionVolumn; }
            set { transactionVolumn = value; }
        }

        public double TransactionAmount
        {
            get
            { return transactionAmount; }
            set { transactionAmount = value; }
        }

        public double FundBalance
        {
            get { return fundBalance; }
            set { fundBalance = value; }
        }

        public String ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

        public String BussinessName
        {
            get { return bussinessName; }
            set { bussinessName = value; }
        }

        public double CommmisionCharge
        {
            get { return commmisionCharge; }
            set { commmisionCharge = value; }
        }

        public double StampTax
        {
            get { return stampTax; }
            set { stampTax = value; }
        }

        public double TransferFee
        {
            get { return transferFee; }
            set { transferFee = value; }
        }

        public double ClearingFee
        {
            get { return clearingFee; }
            set { clearingFee = value; }
        }

        public String StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        public String ShareholderCode
        {
            get { return shareholderCode; }
            set { shareholderCode = value; }
        }
    }
}
