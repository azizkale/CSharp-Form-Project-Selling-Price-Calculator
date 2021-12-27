using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenYolPriceCalculating
{
    class Product
    {
        public String pName { get; set; }
        public decimal supplyingPrice { get; set; }
        public decimal trenyolComission { get; set; }
        public decimal KDV { get; set; }
        public decimal cargoExpense { get; set; }
        public decimal profitRate { get; set; }
        public decimal sellingingPrice { get; set; }
        
        //Expense Amounts
        public decimal totalExpenseAmount { get; set; }
        public decimal trendyolComissionExpenseAmount { get; set; }
        public decimal kdvExpenseAmount { get; set; }

        //Profit Amount
        public decimal profitAmount { get; set; }

        //Methods
        public decimal calculateSellingPrice()
        {
            this.totalExpenseAmount =
                this.supplyingPrice +
                  (this.supplyingPrice * this.trenyolComission / 100) +
                  (this.supplyingPrice * (this.KDV / 100)) +
                this.cargoExpense;

            this.profitAmount = this.totalExpenseAmount * this.profitRate/100;

            this.sellingingPrice = this.profitAmount + this.totalExpenseAmount;

            return this.sellingingPrice;
        }

        public decimal calculateTrendyolComisssionExpenseAmount()
        {
            this.trendyolComissionExpenseAmount = this.supplyingPrice * this.trenyolComission/100;
            return trendyolComissionExpenseAmount;
        }

        public decimal calculateKDVExpenseAmount()
        {
            this.kdvExpenseAmount = this.supplyingPrice * this.KDV/100;
            return this.kdvExpenseAmount;
        }

        public decimal calculateprofitAmount()
        {
            this.profitAmount =  this.totalExpenseAmount * this.profitRate/100;
            return this.profitAmount;
        }      
    }
}
