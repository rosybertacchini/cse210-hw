class Customer {

    // Attributes
        private int _customerID = 0;
        private string _customerName = "";
        private Address _customerAddress = new Address();

    // Setters
        public void SetCustomerID(int customerID ){
            _customerID = customerID;
        } 
        public void SetCustomerName(string customerName){
            _customerName = customerName;
        }
        public void SetAddress( Address customerAddress){
            _customerAddress = customerAddress ;
        }  
        

    // Getters
        public string GetCustomerName(){
        return  _customerName;
        }
        public Address GetCustomerAddress(){
            return _customerAddress;
        }


    // Constructors
        public Customer(){
            _customerAddress = new Address();
        }
        public Customer(int customerID , string customerName, Address customerAddress){
            _customerID = customerID;
            _customerName = customerName;
            _customerAddress = customerAddress;
        }


    // Methods
        /* - - - - - - - - - - - */
        public Boolean LiveInUSA()  {
            return ( GetCustomerAddress().IsAddressInUSA() ? true  : false );
        }
        /* - - - - - - - - - - - */
        public string DisplayAddress(){
            return  GetCustomerAddress().BuildStrCompleateAddress();
        }

        /* - - - - - - - - - - - */


}