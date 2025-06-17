public abstract class Activity
{
    protected string today = DateTime.Now.ToString("yyyy-MM-dd");
    protected double _time;
    protected double _distance;
    

    public Activity(double time, double distance)
    {
        _time = time;
        _distance = distance;
    }

    public abstract double CalculatePace();
    public abstract double GetSpeed();
    public abstract string DisplayActivity();
}