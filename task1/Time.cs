public class Time
{
    private int _second;
    private int _minute;
    private int _hour;

    public Time()
    {

    }
    public Time(int second, int minute, int hour)
    {
        _second = second;
        _minute = minute;
        _hour = hour;
    }
    // public int getHour()
    // {
    //     return _hour;
    // }
    public int getHour{get{return _hour;}}
    // public int getMinute()
    // {
    //     return _minute;
    // }
    public int getMinute{get{return _minute;}}
    // public int getSecond()
    // {
    //     return _second;
    // }
    public int getSecond{get{return _second;}}
    public void setHour(int hour)
    {
        if (hour >= 0 && hour <= 23)
        {
            _hour = hour;
        }
    }
    public void setMinute(int minute)
    {
        if (minute >= 0 && minute <= 59)
        {
            _minute = minute;
        }
    }
    public void setSecond(int second)
    {
        if (second >= 0 && second <= 59)
        {
            _second = second;
        }
    }
    public string toString()
    {
        return $"{_hour}:{_minute}:{_second}";
    }
    public void setTime(int second, int minute, int hour)
    {
        if (second >= 0 && second <= 59)
        {
            _second = second;
        }
        if (minute >= 0 && minute <= 59)
        {
            _minute = minute;
        }
        if (hour >= 0 && hour <= 23)
        {
            _hour = hour;
        }
    }
    public Time nextSecond()
    {
        _second++;
        if (_second >= 60)
        {
            _second = 0;
            _minute++;

            if (_minute >= 60)
            {
                _minute = 0;
                _hour++;

                if (_hour >= 24)
                {
                    _hour = 0;
                }
            }
        }
        return this;
    }
}