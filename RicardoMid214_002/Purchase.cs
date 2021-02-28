using System;
using System.Collections.Generic;
using System.Text;

namespace RicardoMid214_002
{
    class Purchase
    {
        //fields
        private int invoice_number =0;
        private double sales_amout = 0.00;
        private int qty_items = 0;
        const int SALES_TAX = 5;
        //default contructor
        public Purchase()
        {
        }

        public Purchase(int iNumber, double SalesValue, int items)
        {
            invoice_number = iNumber;
            sales_amout = SalesValue;
            qty_items = items;
        }

        public double CalculateSalesTax
        {

            get
            {
                return (sales_amout * SALES_TAX) / 100;
                //return 100.00;
            }

        }

        public double CalculateShippingCharges
        {

           
           get
            {

                if (qty_items < 3)
                {
                    return 3.50;

                }
                else if (qty_items >= 3 && qty_items <= 6)
                {
                    return 5.00;
                }
                else if (qty_items > 6 && qty_items <= 10)
                {
                    return 7.00;
                }
                else if (qty_items > 10)
                {
                    return 10.00;
                }
                else
                    return 0.00;
                
            }

        }

        public double totalAmout
        {
            get
            {
                return sales_amout + CalculateShippingCharges + CalculateSalesTax;
            }
        }

        public override string ToString()
        {
            return "Purchase details " +
              "\nInvoice Number: " + invoice_number +
              "\nSales amount: " + sales_amout.ToString("C") + //fix 
              "\nSales Tax: " + SALES_TAX + "%" +
              "\nSales tax amount: " + CalculateSalesTax.ToString("C") +
              "\nShipping charges: " + CalculateShippingCharges.ToString("C") +
               "\nTotal amount : " + totalAmout.ToString("C");

        }



    }
}
