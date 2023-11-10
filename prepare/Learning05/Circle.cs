public class Circle : Shape {

    private double _radius = 0;


    // constructor
    public Circle(string color, double radius){
        this.SetColor(color);
        _radius = radius;
    }



    public override double GetArea(){
        return (Math.PI * (_radius * _radius));
    }





}// end class