public class Event {

    // Attributes
        private string _title = "";
        private string _description = "";
        private string _date;
        private string  _time = "";    
        private Address _address;

    // Setters
        public void SetTitle(string title){
            _title = title;
        }
        public void SetDescription(string description){
           _description = description;
        }     
        public void SetDate(string date){
           _date = date;
        }             
        public void SetTime(string time){
           _time = time;
        } 
        public void SetAddress(Address address){
           _address = address;
        }         
    // Getters
        public string GetTitle( ){
             return _title ;
        }
  
        public string GetDate(){
            return _date;
        }


    // Constructors
        public Event(){}
        public Event(string title, string description,string date ,  string time, Address address){
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
         }

    // Methods
        /* - - - - - - - - - - - */
        public void DisplayStandardMessage(){
            Console.WriteLine($"\tTitle: {_title},  Description: {_description}\n\tDate: {_date}, Time: { _time}\n\tAddress: {_address.BuildStrCompleateAddress()}");
        }

        /* - - - - - - - - - - - */
        
        public void DisplayFullMessage(){
            DisplayStandardMessage();
            Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
             // Check if the object is an instance of the Reception class
            if (this is Reception receptionEvent){
                    Console.WriteLine($"\t{receptionEvent.DisplayEventInfo()}");
                }
                // Check if the object is an instance of the Outdoor class
                else if (this is Outdoor outdoorEvent){
                     Console.WriteLine($"\t{outdoorEvent.DisplayEventInfo()}");
                }
                // Check if the object is an instance of the Lecutre class
                else if (this is Lecutre lectureEvent){
                    Console.WriteLine($"\t{lectureEvent.DisplayEventInfo()}");
                }
                Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            }
        
        /* - - - - - - - - - - - */
        
        public  void  DisplayShortShortMessage(Event e){
                Console.WriteLine($"\tType of Event: {e.GetType().ToString()},   Title: {e.GetTitle()},    Date: {e.GetDate()}");
        }

}