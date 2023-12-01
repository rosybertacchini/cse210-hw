

class Reception : Event {

   // Attrinutes 
      private string _emailRSVP = "";

   // Setters

      public void SetEmailRSVP(string emailRSVP){
         _emailRSVP = emailRSVP;
      }

   // Getters

      public string GetEmailRSVP(){
         return _emailRSVP;
      }
   // Constructors

      public Reception(){}
      public Reception(string  emailRSVP){
         _emailRSVP = emailRSVP;
      }

   // Methods

      public  string  DisplayEventInfo(){
         return   ( "Registered by (RSVP) email: " + GetEmailRSVP());
      }
 

}