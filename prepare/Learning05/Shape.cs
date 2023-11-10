public abstract class Shape {

    private string _color = "";


    // consturctors
    public Shape() {

    }

    // setters and getters
    public void SetColor(string color){
        _color = color;        
    }

    public string GetColor(){
        return _color;
    }


// methods
public abstract double GetArea();


} // end class