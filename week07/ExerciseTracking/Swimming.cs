public class Swimming : Activity
{
    public Swimming(double time, double laps) : base(time, laps)
    {
        
    }
    public double GetDistance()
    {
        double answer = _distance * 50 / 1000 * .62;
        return answer;
    }
    public override double GetSpeed()
    {
        double answer = GetDistance() / _time * 60;
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
        return $"{today} Swimming ({_time} min): Laps {_distance}, Speed: {GetSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}