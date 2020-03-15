namespace BerlinClock
{
    public class ConcereteTimeFormatCreator : TimeFormatCreator
    {
        //Dependency Injection for Setting the input Time Format
        public override ITimeFormat SetTimeFormat(string format)
        {
            switch (format)
            {
                case "1": return new SimpleFormat();
                default: return new DefaultFormat();
            }
        }

        //Dependency Injection for Setting the output Time Format
        public override ITimeFormat GetTimeFormat(string format)
        {
            switch (format)
            {
                case "1": return new SimpleFormat();
                case "2": return new BerlinClockFormat();
                default: return new DefaultFormat();
            }
        }
    }
}
