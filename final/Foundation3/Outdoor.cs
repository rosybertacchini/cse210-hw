    class Outdoor : Event {

    // Attributes
        private string _weather = "" ;

    // Setters

    // Getters

    // Constructors
      public Outdoor(){}
      public Outdoor(string title, string description, string date, string time, Address address, string weather)  : base(title, description, date, time, address)
      {
            _weather = weather;
      }

    // Methods

      public  string  DisplayEventInfo(){
        return   "Weather: " +  _weather;;
      }



} // Class

