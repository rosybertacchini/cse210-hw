public class Cycling  : Activity {

    //Attributes 
        double _speed;

    // Setters 
       public void SetSpeed(double speed){
            _speed = speed;
       } 
    // Getters
       public double GetSpeede(){
            return _speed;
       } 
    // Constructors
        public Cycling(){}
        public Cycling(double speed, DateTime date, int length) : base(date, length) {
            _speed = speed;
        }


    // Methods

        public override void DoCalculations(ref double Distance, ref double Speed, ref double Pace){

            // Distance (km) = swimming laps * 50 / 1000
            // Speed (mph or kph) = (distance / minutes) * 60
            // Pace (min per mile or min per km)= minutes / distance
            // Speed = 60 / pace
            // Pace = 60 / speed

            // distance = speed x time            

            //---------------------------------------------------------------
            //this class has:
             Speed = _speed;
            
            // We need to calculate: Distance
            // formula: distance = speed x time  (_speed in in km/hr, we divided by 60 to convert to minutos because time (GetLenght()) is in minutes
             Distance =  (_speed / 60 )  * (double) this.GetLength() ;

            // We need to calculate Pace
            // Pace is Time divided by Distance and represents the amount of time taken to cover a given distance
             Pace = 60 / Speed ;
           //---------------------------------------------------------------

        }





}