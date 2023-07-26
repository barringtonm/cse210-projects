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
