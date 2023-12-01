using System.Reflection.Metadata.Ecma335;

public abstract  class Activity {

    //Attributes 
        private DateTime _date;
        private int _length; // minutes

    // Setters 
 
    // Getters
        public DateTime GetDate(){
            return _date;
        }
        public int GetLength(){
            return _length;
        }

    // Constructors
        public Activity(){}
        public Activity(DateTime date, int length) {
            _date = date;
            _length = length;
        }

    // Methods

        public   void GetSummary(){
                double Distance = 0;
                double Speed = 0; 
                double Pace = 0;

                // Check if the object is an instance of the Swimming class
                 if (this is Swimming activitySwimming) {
                    activitySwimming.DoCalculations(ref Distance, ref Speed, ref Pace);
                }
                // Check if the object is an instance of the Outdoor class
                else if (this is Running activityRunning){
                    activityRunning.DoCalculations(ref Distance, ref Speed, ref Pace);
                }
                // Check if the object is an instance of the Lecutre class
                else if (this is Cycling activityCycling){
                    activityCycling.DoCalculations(ref Distance, ref Speed, ref Pace);
                }

          
                //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
                Console.WriteLine($" {this.GetDate().ToString("dd MMM yyyy")} - {this.GetType().ToString().ToUpper()} ({this.GetLength()} min): Distance {Distance.ToString("N3")}  km, Speed: {Speed.ToString("N3")} kph, Pace: {Pace.ToString("N3")} min per km" );
        }

        public abstract void  DoCalculations(ref double Distance, ref double Speed, ref double Pace);



//03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
//https://www.calculatorsoup.com/calculators/math/speed-distance-time-calculator.php
// distance = speed x time

}