using System;

namespace RicardoMid214_002
{
    class PurchaseApp
    {
        static void Main(string[] args)
        {

            string vNexInvoice = "y";

            while(vNexInvoice == "y")
            {



                purchase();
                Console.WriteLine("Enter next Invoice (Y/N)");
                vNexInvoice =  Console.ReadLine().ToLower();



            }

            Console.WriteLine("Press any key to finish the APP");
            Console.ReadKey();


        }

        static void purchase ()
        {

            int vInvoiceNumber;
            String sInvoiceNumber;
            double vSaleAmout = 0.00;
            int vNumber_itens_purchase = 0;
            ;
            Console.WriteLine("Enter purchase details**************");
            Console.WriteLine();
            Console.WriteLine("Enter invoice number :");

            sInvoiceNumber = Console.ReadLine();


            //Check if valid invoice number
            while (true)
            {
                int i = 0;
                //check if is number
                if (int.TryParse(sInvoiceNumber, out i) == false) 
                {
                    Console.WriteLine("Invalid data entered for invoice"); ;
                    Console.WriteLine("Enter a invoice number between 1000 and 9000 :");
                    sInvoiceNumber = Console.ReadLine();
                } // check if the number still on the ranger
                else if (Convert.ToInt32(sInvoiceNumber) < 1000 || Convert.ToInt32(sInvoiceNumber) > 9000)
                {

                    Console.WriteLine("Invalid data entered for invoice"); ;
                    Console.WriteLine("Enter a invoice number between 1000 and 9000 :");
                    sInvoiceNumber = Console.ReadLine();

                } else
                {
                    break;
                }
            }


            vInvoiceNumber = Convert.ToInt32(sInvoiceNumber);

            Console.WriteLine("Enter the sales amount :");
            vSaleAmout = Convert.ToDouble(Console.ReadLine());

            // check if value is negative
            while (true)
            {

                if (vSaleAmout < 0)
                {
                    Console.WriteLine("Invalid data entered for sales amount, please enter a nonnegative value");
                    vSaleAmout = Convert.ToDouble(Console.ReadLine());


                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Enter number of items purchased :");
            vNumber_itens_purchase = Convert.ToInt32(Console.ReadLine());

            Purchase purchase = new Purchase(vInvoiceNumber, vSaleAmout, vNumber_itens_purchase);

            Console.WriteLine(purchase.ToString());

        }

    }
}
