

class Reception : Event {

   // Attrinutes 
      private string _emailRSVP = "";

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