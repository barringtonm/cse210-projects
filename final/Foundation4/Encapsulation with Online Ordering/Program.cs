using System;
using Systems.Collection.Generic;
namespace Foundation4Encap
{
        
        class Program 
        {
                static void Main(string[] args)
            {

                Product product = new product();

                product._name = " Music Box; ";
                product ._productid ="1234";
                product._price = " $250";
                product._quantity = "10";
                product._shippingLabel = "   ";

                List<Product> products = new List<Product>();
                Console.WriteLine("\nQuantity : {0}, products.Quantity");

                products.Add( new product(A) { _ProductName = "Music box",ProductId = 1234});
                products.Add(new product(B) { _ProductName = "Dining table", ProductId = 1334 });
                products.Add(new product(C) { _ProductName = "Dining Table chairs", ProductId = 1434 });
                products.Add(new product(D) { _ProductName = "Table cloth", ProductId = 1634 });





               List<Order>OrderList = new List<Order>();

                OrderList.Add(new Order("   "));









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

}         



        
         



  