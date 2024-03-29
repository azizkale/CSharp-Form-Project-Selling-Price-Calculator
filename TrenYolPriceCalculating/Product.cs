﻿using System;
using System.Windows.Forms;
using TrenYolPriceCalculating;

namespace TrenYolPriceCalculating
{
    public class Product
    {
        public string ID { get; set; }
        public string pName { get; set; }
        public decimal supplyingPrice { get; set; }
        public decimal trendyolComissionRate { get; set; }
        public decimal KDV { get; set; }
        public decimal cargoExpense { get; set; }
        public decimal profitRate { get; set; }
        public decimal sellingingPrice { get; set; }

        //Expense Amounts
        public decimal totalExpenseAmount { get; set; }
        public decimal trendyolComissionExpenseAmount { get; set; }
        public decimal kdvExpenseAmount { get; set; }
       
        //request info
        public string requestInfo {get; set; }

        //Profit Amount
        public decimal profitAmount { get; set; }

        //Invoice Amount
        public decimal invoiceAmount;

        //Methods
        public decimal calculateSellingPrice()
        {
            this.totalExpenseAmount =
                this.supplyingPrice +
                  (this.supplyingPrice * this.trendyolComissionRate / 100) +
                  (this.supplyingPrice * (this.KDV / 100)) +
                this.cargoExpense;

            this.profitAmount = this.totalExpenseAmount * this.profitRate/100;

            this.sellingingPrice = this.profitAmount + this.totalExpenseAmount;

            //makes it with 2 digit after komma
            return Decimal.Parse(String.Format("{0:0.##}", this.sellingingPrice));
        }

        public decimal calculateTrendyolComisssionExpenseAmount()
        {
            this.trendyolComissionExpenseAmount = this.supplyingPrice * this.trendyolComissionRate / 100;
            return Decimal.Parse(String.Format("{0:0.##}", this.trendyolComissionExpenseAmount));

        }

        public decimal calculateKDVExpenseAmount()
        {
            this.kdvExpenseAmount = this.supplyingPrice * this.KDV/100;
            return Decimal.Parse(String.Format("{0:0.##}", this.kdvExpenseAmount));
        }

        public decimal calculateprofitAmount()
        {
            this.profitAmount =  this.totalExpenseAmount * this.profitRate/100;
            return Decimal.Parse(String.Format("{0:0.##}", this.profitAmount));
        }

        public decimal calculateInvoice()
        {
            this.invoiceAmount = (this.calculateSellingPrice() * 100) / (100 + this.KDV);
            return this.invoiceAmount;
        }
    }
}

interface IValidator<T>
{
    bool Validate(T t);
}

class ProductValidator : IValidator<Product>
{
    public bool Validate(Product p)
    {
        if (p.pName == null || p.pName =="")
        {
            MessageBox.Show("Lütfen ürün ismi giriniz.");
            return false;
        }
        if (p.supplyingPrice == 0)
        {
            MessageBox.Show("Lütfen ürün alış fiyatı giriniz.");
            return false;
        }
        else
            return true;
    }
}