
public class Job    
{
    public string _company;
    public string _jobTital;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_company}");
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTital} ({_company}) {_startYear} - {_endYear}");
    }
}