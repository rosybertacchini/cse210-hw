using System.Net.Http.Headers;

class Order {


    // Attributes
        private int _customerID;
        List<Product> _products = new List<Product>{};
        // private double _shipingCostInUSA = 0;
        // private double _shipingCostOutUSA = 0;
        
    // Setters
        public void SetCustomerID(int customerID){
            _customerID = customerID;
        }
        public  void SetProducts(List<Product> products){
            _products = products ;
        }
    // Gettres    
        public int GetCustomerID(){
            return _customerID;
        }
        public List<Product> GetProducts(){
            return _products;
        }

    // Constructors
        public Order(){ }
        public Order(int customerID , List<Product> products ){
            _customerID = customerID;
            _products = new List<Product>();
        }


    // Methods

        public double SubTotalCostOfTheOrder(){
                double subTotal = 0;
                foreach(Product p in GetProducts()){
                    subTotal += p.GetProductPrice() * p.GetProductQty();
                }
               return subTotal;
        } 
        public string PackingList(){
            string PackingStr = "";
            foreach(Product p in GetProducts()){
                PackingStr += "\t" +  p.GetProductID() +"\t" + p.GetProductName() + "\t\t" + p.GetProductQty() + "\t" + p.GetProductPrice() + "\n";
            }
            return PackingStr;
        }

        public string ShippingLabel(Customer c){
            string shippingStr = "";
            shippingStr += "\t*****************************\n";
            shippingStr += "\t" + c.GetCustomerName() + "\n";
            shippingStr += c.DisplayAddress() + "\n";
            shippingStr += "\t*****************************\n";
            return shippingStr;

        }

} // End Class