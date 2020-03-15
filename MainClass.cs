using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();

            try
            {
                Console.WriteLine("Input Format Type: 1. Simple(hh:mm:ss) ");
                String inputTimeFormat = Console.ReadLine();
                ITimeFormat inputFormat = factory.SetTimeFormat(inputTimeFormat);
                try
                {
                    Console.WriteLine("Enter Time:");
                    String t = Console.ReadLine();
                    Time inputTime = inputFormat.SetInput(t);
                    try
                    {
                        Console.WriteLine("Output Format Type:\n 1. Default \n2. BerlinClock");
                        String outputTimeFormat = Console.ReadLine();
                        ITimeFormat outputFormat = factory.GetTimeFormat(outputTimeFormat);
                        Console.WriteLine("\nOutput Time:");
                        Console.WriteLine(outputFormat.GetOutput(inputTime));
                    }
                    catch (Exception eee)
                    {
                        Console.WriteLine(eee.Message);
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


