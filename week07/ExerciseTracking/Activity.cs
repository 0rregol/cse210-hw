using System;

public abstract class Activity
{
    private DateTime date;
    private int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public DateTime Date => date;
    public int LengthInMinutes => lengthInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min) - Distance: {GetDistance():0.0} kilometer, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per kilometer";
    }
}