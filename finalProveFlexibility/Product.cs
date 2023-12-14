using System.Dynamic;

class Product {

    // Attributes
        private int _productID = 0;
        private string _productName = "";
        private double _price = 0;
        private int _qty = 0;
        private double _discount = 0; 

    // Setters
        public void SetProductID(int productID){
            _productID = productID;
        }
        public void SetProductName(string productName){
            _productName = productName;
        }
        public void SetProductPrice(double price){
            _price = price;
        }
        public void SetProductQty(int qty){
            _qty = qty;
        }

        public void SetDiscount(double discount){  
            _discount = discount;
        }
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
        public Product(int productID , string productName , double price , int qty , double discount){
            _productID = productID;
            _productName = productName;
            _price = price;
            _qty = qty;
            _discount = discount;
        }


    // Methods 
    
    public double  GetTotalPrice(){
        return (_discount > 0 ?   (_qty *  GetPriceDiscount())     : ( _price  * _qty) ) ;
        
    }

    public double  GetPriceDiscount(){     // for test 
        return (_discount > 0 ?   (_price - ( _price  * ( _discount / 100)))     : 0) ;
    }
}