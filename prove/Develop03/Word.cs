
class Word {
    private string _word ;
    private Boolean _visibility;





    // constructors
     public Word (){ 

    }
    public Word (string word , Boolean visibility){   /// van los parametros?
        _word = word ;   // NOTA DEL MAESTRO
        _visibility = visibility;   // NOTA DEL MAESTRO
    }





    //setters and getters
    public void SetWord(string word ){
        _word = word;
    }
    public void SetVisibility(Boolean visibility){
        _visibility = visibility;
    }

    public string GetWord(){
        return _word;
    }
    public Boolean GetWordVisibility(){
        return _visibility;
    }



    // methods

    // NOTA DEL MAESTRO: aqui debe de haber un metodo para cambiar la visibilidad


}


