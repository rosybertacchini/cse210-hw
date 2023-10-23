public class WritingAssignment : Assignment{

    private string _title;
    private string _subtitle;

    public WritingAssignment(string title, string subtitle)
    {
    _title = title;
    _subtitle = subtitle;


}
    public string GetWritingAssignment(){
        return   $"  {_title} {_subtitle}";
    }


}