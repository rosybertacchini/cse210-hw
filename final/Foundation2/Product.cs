using System.Dynamic;

class Product {

    // Attributes
        private int _productID = 0;
        private string _productName = "";
        private double _price = 0;
        private int _qty = 0;

    // Setters


    //Getters
        public int GetProductID(){
            return _productID;
        }
        public string GetProductName(){
            return _productName ;
        }
        public double GetProductPrice(){
            return _price ;
        }
        public int GetProductQty(){
            return _qty ;
        }

    // Constructors
        public Product(){    }
        public Product(int productID , string productName , double price , int qty ){
            _productID = productID;
            _productName = productName;
            _price = price;
            _qty = qty;
        }


    // Methods 
    
    public double  GetTotalPrice(){
        return  _price  * _qty;
    }


}