using System;
using System.Collections.Generic;
namespace Foundation4Encap
{

    public class Order
    {
        private string _customerName;
        private string _productsName;
        private string _productid;
        private decimal _price;
        private string _shippingLabel;
        private decimal _totalPrice;
        private decimal _shippingCost;

        public Order(string _customerName, string _productsName, string _productid, decimal _price, string _shippingLabel, decimal _totalPrice, decimal _shippingCost)
        {
            this._customerName = _customerName;
            this._productsName = _productsName;
            this._productid = _productid;
            this._price = _price;
            this._shippingLabel = _shippingLabel;

            }
                
                
    }        
                
}                        




        