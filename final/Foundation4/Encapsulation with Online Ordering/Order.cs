using System;
using system.Collections.Generic;
namespace Foundation4Encap 
{

    public class Order
    {
    private string _customerName;
    private string _productsName;
    private string _productid;
    public decimal _price;
    private string _shippingLabel;
    private decimal _totalPrice;
    private decimal _shippingCost;



    }

        public Order (string _customerName,string _productsName, string _productid, decimal _price, string _shippingLabel, decimal _totalPrice, decimal _shippingCost)
        {
            this._customerName = _customerName;
            this._productsName = _productsName;
            this._productid = _productid;
            this._price =_price;
            this._shippingLabel =_shippingLabel;

        }
        
        public string _customerName 
        {
            get{return _customerName;}
            set{CustomerName = value;}
        }
       
  
        public string _productName
        {
            get{return  _productName;}
            set{_productName = value;}
        }
        

        public string _productid
        {
            get{return _productId;}
            set{_productId = value;}
        }

        public decimal _price 
        {
            get{return _price;}  
            set{_price =value;}   

        }

         public string _shippingLabel  
         {
            get{return _shippingLabel;}
            set{_shippingLabel = value;}
         }
        

        public decimal _totalPrice
        {
            get{return _totalPrice;}
            set{_totalPrice = value;}

        }


        public decimal _shippingCost 
        {
            get{return _totalPrice;}
            set{_totalPrice = value;}
        }


        public TotalPrice()
        {
            
        }





}                    