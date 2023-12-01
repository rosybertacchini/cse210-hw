    class Outdoor : Event {

    // Attributes
        private string _weather = "" ;

    // Setters
        public void SetWeather(string weather){
            _weather = weather;
        }
    // Getters
        public string GetWeather(){
            return _weather;
        }

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

