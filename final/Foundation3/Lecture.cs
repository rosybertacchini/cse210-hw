

class Lecutre : Event {

   // Attrinutes 
      private string  _speaker = "";
      private int _maxCapacity = 0;

   // Setters


   // Getters
  

   // Constructors

      public Lecutre(){}
      public Lecutre(string speaker , int maxCapacity){
         _speaker = speaker;
         _maxCapacity = maxCapacity;
      }

   // // Methods

      public  string  DisplayEventInfo(){
         return  "Speaker: " + _speaker + ", " + "MaxCapacity: " + _maxCapacity;
      }



}