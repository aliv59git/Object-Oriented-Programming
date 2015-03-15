using System;
class AlarmClock
{
    private int hours = 8;
    private int minutes = 0;

    public AlarmClock()
    {
    }

    public AlarmClock(int hours, int minutes)
    {
        this.hours = hours;
        this.minutes = minutes;
    }

    public int Hours
    {
        get { return this.hours; }
        set { this.hours = value; }
    }

    public int Minutes
    {
        get { return this.minutes; }
        set { this.minutes = value; }
    }

}
