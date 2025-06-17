
public class Running : Activity
{
    

    public Running(double time, double distance) : base(time, distance)
    {
        
    }
    public override double GetSpeed()
    {
        double answer = (_distance / _time) * 60;
        double rounded = Math.Round(answer, 2);
        return rounded;
    }
    public override double CalculatePace()
    {
        double answer = _time / _distance;
        double rounded = Math.Round(answer, 2);
        return rounded;
    }
    public override string DisplayActivity()
    {
        return $"{today} Running ({_time} min): Distance {_distance}, Speed: {GetSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}