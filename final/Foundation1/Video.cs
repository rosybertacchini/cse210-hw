using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video {

// Attributes
    private string _title  = "";
    private string _author  = "";
    private Int32 _lenghtInSecods = 0 ;
    private List<Comment> _comments  = new List<Comment>{};

// Consturctors
    public Video() {
    }
    public Video(string title, string author, Int32 lengthInSeconds, List<Comment> comments ) { 
        _title = title;
        _author = author;
        _lenghtInSecods = lengthInSeconds;
        _comments = comments;
    }



// Setters and Getters
    public void SetTitle(string title){
        _title = title;
    }
    public void SetAuthor(string author){
        _author = author;
    }
    public void SetLengthInSeconds(Int32 lengthInSeconds){
        _lenghtInSecods = lengthInSeconds;
    }
    public string GetTitle(){
        return _title ;
    }
    public string GetAuthor(){
        return _author ;
    }
    public Int32 GetLengthInSeconds(){
        return _lenghtInSecods ;
    }
    public Int32 GetNumberOfComments(){
        return _comments.Count();
    }

// Methods
    public void DisplayVideoDetails(){
        


    }




}