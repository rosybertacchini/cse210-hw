public class Running : Activity {

    //Attributes 
        double _distance = 0;

    // Setters 

    // Getters

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

            // distance = speed x time


            //---------------------------------------------------------------
            //this class has:
             Distance  = _distance;
            
            // We need to calculate: Speed
            // formula: speed =  distance  / time (_distance is in km/hr, we multiply length (GetLenght() is in minutes)  by 60 to convert to to hours 
             Speed = (_distance / (double) this.GetLength()) * 60 ;

            // We need to calculate Pace
            // Pace is Time divided by Distance and represents the amount of time taken to cover a given distance
             Pace = 60 / Speed ;
            //---------------------------------------------------------------
        }


} // Class