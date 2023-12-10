    class Outdoor : Event {

    // Attributes
        private string _weather = "" ;

    // Setters

    // Getters


    // Constructors
        public Outdoor(){}
        public Outdoor(string weather){
            _weather = weather;
        }

    // Methods

      public  string  DisplayEventInfo(){
        return   "Weather: " +  _weather;;
      }



} // Class

