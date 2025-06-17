public abstract class Activity
{
    protected DateTime today = DateTime.Today;
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