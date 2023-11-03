public class Circle : Shape {

    private double _radius = 0;
    private double pi = 3.1416;

    // constructor
    public Circle(string color, double radius){
        this.SetColor(color);
        _radius = radius;
    }

    //setters and getters
    public void SetRadius(double radius){
        _radius = radius;
    }
    public double GetRadius(){
        return (pi * (_radius * _radius))/2;
    }





}// end class