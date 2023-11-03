public class  Square : Shape {
    private double _side = 0;

    // constructor
    public Square(string color , double side ){
        this.SetColor(color);
        _side = side;
        
    }

    // methods
    public override double GetArea()
    {
        return ( _side * _side) ;
    }

} // end class}