using System;
namespace Foundation4Encap
{
        class Product
    {
        private string _name;
        private string _product;
        private string _price;
        private int _quantity;

        public string _shippingLabel;
        public string _ProductName;

        QuantityOfProduct()
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("\nQuantity : {0}, products.Quantity");

            products.Add( new product() { _ProductName = "Music box",ProductId = 1234});
            products.Add(new product() { _ProductName = "Dining table", ProductId = 1334 });
            products.Add(new product() { _ProductName = "Dining chairs", ProductId = 1434 });
            products.Add(new product() { _ProductName = "Table cloth", ProductId = 1634 });

            Console.WriteLine();
            foreach (var item in products)
            {
                Console.WriteLine(item);   
            }

            Console.WriteLine("\nQuantity: {0}", products.Quantity);
            Console.WriteLine("\nCount: {0}", products.Count);




            

        }    

            public void priceOfProduct()
            {
            priceOfProduct = _price * _QuantityOfProduct;
            return;
            } 
     }   
}
