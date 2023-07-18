using System;

using Systems.Collection.Generic;
namespace Foundation4Encap
{
    
    
        static void Main(string[] args)
        {

            Product product = new product();

            product._name = " ";
            product._price = "";
            product._quantity = " ";
            product._shippingLabel = " ";


            PackingLabel();

            ShippingLabel();

            priceOfProduct();

            USAAddress();
            {
                return;
            }
            AddressNotUSA(Console.Out);



        }
    }      



  