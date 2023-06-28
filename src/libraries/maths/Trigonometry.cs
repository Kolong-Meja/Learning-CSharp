using System;
using MathsObj;

namespace Maths
{
    public class Trigonometry
    {
        protected static double DegreesIntoRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }

        public static string LengthOfZipeWire(ZipeWireItem zipeWireItem)
        {

            if (zipeWireItem.Distance != 0 || zipeWireItem.Degrees != 0)
            {
                double doubleDistance = (double) zipeWireItem.Distance;
                double doubleDegrees = (double) zipeWireItem.Degrees;

                double angleRadians = DegreesIntoRadians(doubleDegrees);
                double length = doubleDistance / Math.Cos(angleRadians);

                return $"Length of zipe wire is {Math.Round(length, 1, MidpointRounding.AwayFromZero)} meters";
            }           
            
            throw new ArgumentException("Distance or Degrees is null!");
        }

        public static string HeightOfSkyScraper(SkyScraperItem skyScraperItem)
        {
            if (skyScraperItem.ToolLocate != 0 || skyScraperItem.Distance != 0 || skyScraperItem.Degrees !=0)
            {
                double doubleToolLocate = (double) skyScraperItem.ToolLocate;
                double doubleDistance = (double) skyScraperItem.Distance;
                double doubleDegrees = (double) skyScraperItem.Degrees;

                double angleRadians = DegreesIntoRadians(doubleDegrees);
                double heightOfSkyscraper = (Math.Tan(angleRadians) * doubleDistance) + doubleToolLocate;

                return $"Height of Skyscraper is {Math.Round(heightOfSkyscraper, 1, MidpointRounding.AwayFromZero)} meters";
            }

            throw new ArgumentException("Tool Locate or Distance or Degrees is null!");
        }
    }
}