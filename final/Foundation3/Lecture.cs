

class Lecutre : Event {

   // Attrinutes 
      private string  _speaker = "";
      private int _maxCapacity = 0;

   // Setters
      public void SetSpeaker(string speaker){
         _speaker = speaker;
      }
      public void SetMaxCapacity(int maxCapacity){
         _maxCapacity = maxCapacity;
      }

   // Getters
     public  string GetSpeaker(){
         return _speaker;
      }
      public int SetMaxCapacity(){
         return _maxCapacity ;
      }   

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