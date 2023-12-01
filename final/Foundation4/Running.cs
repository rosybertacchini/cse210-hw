public class Running : Activity {

    //Attributes 
        double _distance = 0;

    // Setters 
       public void SetDistance(double distance){
            _distance = distance;
       } 
    // Getters
       public double GetDistance(){
            return _distance;
       } 
    // Constructors
        public Running(){}
        public Running(double distance, DateTime date, int length) : base(date, length) {
            _distance = distance;
        }


    // Methods

 
        public override void  DoCalculations(ref double Distance, ref double Speed, ref double Pace){

        // Distance (km) = swimming laps * 50 / 1000
        // Speed (mph or kph) = (distance / minutes) * 60
        // Pace (min per mile or min per km)= minutes / distance
        // Speed = 60 / pace
        // Pace = 60 / speed
        
            
            //double theDistance = _distance;


            //---------------------------------------------------------------
            //this class has:
             Distance  = _distance;
            
            // We need to calculate: Speed
            // formula: speed =  distance  / time (_distance is in km/hr, we multiply length (GetLenght() is in minutes)  by 60 to convert to to hours 
             Speed = (_distance / (double)this.GetLength()) * 60 ;

            // We need to calculate Pace
             Pace = 60 / Speed ;
        //---------------------------------------------------------------


            //Pace = (double)this.GetLength() / _distance;
            //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km


        }


}