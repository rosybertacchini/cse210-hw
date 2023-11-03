public class Rectangle : Shape{

    private double _length = 0;
    private double _width = 0;

    // constructor
    public Rectangle(string color, double length, double width){
        this.SetColor(color);
        _length = length;
        _width = width;

    }

    // methods
    public override double GetArea()
    {
        return _length * _width;
    }





}// end class