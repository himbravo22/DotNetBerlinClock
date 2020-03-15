namespace BerlinClock
{
    public abstract class TimeFormatCreator
    {
        //Gets the Input Time Format
        public abstract ITimeFormat SetTimeFormat(string format);

        //Gets the Output Time Format
        public abstract ITimeFormat GetTimeFormat(string format);
    }
}
