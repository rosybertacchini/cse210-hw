
public class Reference {

/*
A class for a Reference should likely have at least two different constructors to account for cases 
where there is a single verse or multiple verses. What should they look like? 
 */
    private string _book;
    private string _chapter;
    private string _ini_verse;
    private string _end_verse;



// constructors
     public Reference() {

    }
    public Reference(string _book , string  _chapter, string _ini_verse) {

    }
    public Reference(string _book , string  _chapter, string _ini_verse, string _end_verse) {

    }







    // setters and getters

    public void SetReferenceBook (string book ){
         _book = book;
    }
    public void SetReferenceChapter(string chapter ){
        _chapter = chapter;
    }
    public void SetReferenceIniVerse(string iniVerse ){
        _ini_verse= iniVerse;
    }
    public void SetReferenceEndVerse(string endVerse ){
        _end_verse=endVerse;
    }

    public void SetReference(string book, string chapter, string ini_verse, string end_verse ){

        _book = book;
        _chapter = chapter;
        _ini_verse = ini_verse;
        _end_verse = end_verse;

    }


    public string GetReferenceBook(){
        return _book;
    }

    public string GetReferenceChapter(){
        return _chapter;
    }

    public string GetReferenceIniVerse(){
        return _ini_verse;
    }

    public string GetReferenceEndVerse(){
        return _end_verse;
    }


}


