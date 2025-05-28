
public class Video
{
    private string _creatorName;
    private string _videoTital;
    private int _minLength;
    private int _secLength;
    private int _subs;
    private Coment coment = new Coment();
    public Video(string name, string tital, int subs, int minLength, int secLength)
    {
        
        _creatorName = name;
        _videoTital = tital;
        _subs = subs;
        _minLength = minLength;
        _secLength = secLength;
        coment.CreateCSVFile(_videoTital);  
    }
    
    public void MakeComment(string userName, string userComment)
    {
        coment.CreateComment(_videoTital,userName,userComment);
    }
    public void DisplayVideoComments()
    {
        int commetCount = coment.CountComments(_videoTital);
        Console.WriteLine($"Creator: {_creatorName}\nSubscribed: {_subs}\nVideo: {_videoTital}\n{_minLength}:{_secLength}\n");
        Console.WriteLine($"{commetCount} Comments:\n");
        coment.DisplayVideoComments(_videoTital);
    }

}