public class MathAssignment : Assignment
{
    private string _sectionName ;
    private string _sectionNum;
    private String _problemName;
    private string _problemNum;


    public MathAssignment(string sectionName, string sectionNum , string problemName, string problemNum )
    {
        _sectionName = sectionName;
        _sectionNum = sectionNum;
        _problemName = problemName;
        _problemNum = problemNum;
    }



    public string GetHomeworkList() {
        return $"{_sectionName}  {_sectionNum} { _problemName} {_problemNum}  ";

    }

}