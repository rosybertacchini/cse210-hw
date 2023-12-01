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

            //---------------------------------------------------------------
            //this class has:
             Speed = _speed;
            
            // We need to calculate: Distance
            // formula: distance = speed x time  (_speed in in km/hr, we divided by 60 to convert to minutos because time (GetLenght()) is in minutes
             Distance =  (_speed / 60 )  * (double) this.GetLength() ;

            // We need to calculate Pace
             Pace = 60 / Speed ;
           //  no    Pace = 60 /   (  Speed / 60 );   // ?
           //---------------------------------------------------------------

        }





}