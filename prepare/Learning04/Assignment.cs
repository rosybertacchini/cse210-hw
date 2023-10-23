public class  Assignment
{

    private string _studentName; 
    private string _topic;


     // constructors
    public Assignment()
    {
 
    }
   public Assignment(string studentName, string  topic){
            _studentName = studentName;
            _topic = topic;   
    }


    // methods

    public string GetSummary(){
            return $"{_studentName} {_topic}";
    }

public void SetStudentName(string studentName){
        _studentName = studentName;
}
public string GetStudentName(){
        return _studentName;
}



}