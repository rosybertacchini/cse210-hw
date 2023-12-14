class Customer {

    // Attributes
        private int _customerID = 0;
        private string _customerName = "";
        private Address _customerAddress = new Address();

    // Setters
       

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
            return (_customerAddress.IsAddressInUSA() ? true  : false );
        }
        /* - - - - - - - - - - - */
        public string DisplayAddress(){
            return _customerAddress.BuildStrCompleateAddress();
        }

        /* - - - - - - - - - - - */


}