public class Shape {

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

public virtual double  GetArea(){

    return 1.0;

}


} // end class