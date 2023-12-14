class Reception : Event {

   // Attrinutes 
      private string _emailRSVP = "";

   // Constructors  
      public Reception(){}  
      public Reception(string title, string description, string date, string time, Address address, string emailRSVP)  : base(title, description, date, time, address)
      {
          _emailRSVP = emailRSVP;
      }

   // Setters
      
      public void SetEmailRSVP(string emailRSVP){
         _emailRSVP = emailRSVP;
      }

   // Getters



   // Methods

      public  string  DisplayEventInfo(){
         return   ( "Registered by (RSVP) email: " + _emailRSVP);
      }
 

}