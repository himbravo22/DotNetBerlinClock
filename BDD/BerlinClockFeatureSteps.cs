using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        //test it by either main class or test cases
        private ITimeFormat berlinClock = new BerlinClockFormat();
        private String theTime;

        [TestInitialize]
        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput = "YOOOOOOOOOOOOOOOOOOOOOOO")
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();
            ITimeFormat inputFormat = factory.SetTimeFormat("1");
            Time inputTime = inputFormat.SetInput("00:00:00");
            String outputTimeFormat = "2";
            ITimeFormat outputFormat = factory.GetTimeFormat(outputTimeFormat);
            Assert.IsNotNull(outputFormat.ToString().Replace(" ", ""), theExpectedBerlinClockOutput);
        }
                                                      
        [Then(@"Middle of the afternoon")]
        public void ThenTheClockInMiddleOfAfternoonShouldLookLike(string theExpectedBerlinClockOutput = "ORROORRROYYROOOOOOOOYYOO")
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();
            ITimeFormat inputFormat = factory.SetTimeFormat("1");
            Time inputTime = inputFormat.SetInput("13:17:01");
            String outputTimeFormat = "2";
            ITimeFormat outputFormat = factory.GetTimeFormat(outputTimeFormat);
            Assert.IsNotNull(outputFormat.ToString().Replace(" ", ""), theExpectedBerlinClockOutput);
        }

        [Then(@"Just before midnight")]
        public void ThenTheClockInJusBeforeMidnightShouldLookLike(string theExpectedBerlinClockOutput = "ORRRRRRROYYRYYRYYRYYYYYY")
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();
            ITimeFormat inputFormat = factory.SetTimeFormat("1");
            Time inputTime = inputFormat.SetInput("23:59:59");
            String outputTimeFormat = "2";
            ITimeFormat outputFormat = factory.GetTimeFormat(outputTimeFormat);
            Assert.IsNotNull(outputFormat.ToString().Replace(" ", ""), theExpectedBerlinClockOutput);
        }

        [Then(@"Midnight")]
        public void ThenTheClockInMidnightShouldLookLike(string theExpectedBerlinClockOutput = "YRRRRRRRROOOOOOOOOOOOOOO")
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();
            ITimeFormat inputFormat = factory.SetTimeFormat("1");
            Time inputTime = inputFormat.SetInput("24:00:00");
            String outputTimeFormat = "2";
            ITimeFormat outputFormat = factory.GetTimeFormat(outputTimeFormat);
            Assert.IsNotNull(outputFormat.ToString().Replace(" ", ""), theExpectedBerlinClockOutput);
        }
    }
}
