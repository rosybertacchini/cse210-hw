using System.Runtime.CompilerServices;

public class Swimming  : Activity {

    //Attributes 
        int _numberOfLaps;
    // Setters 
       public void SetNumberOfLaps(int numberOfLaps){
            _numberOfLaps = numberOfLaps;
       } 
    // Getters
       public double GetNumberOfLapse(){
            return _numberOfLaps;
       } 

       
    // Constructors
        public Swimming(){}
        public Swimming(int numberOfLaps, DateTime date, int length) : base(date, length) {
            _numberOfLaps = numberOfLaps;
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
             Distance = (double) _numberOfLaps * 50 / 1000;
             Speed = (Distance / (double)this.GetLength() ) * 60 ;
             Pace = 60 / Speed ;
             //Pace = (double)this.GetLength()  / Distance;

             //---------------------------------------------------------------
        }



}