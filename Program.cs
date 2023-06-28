/* THIS IS PLACE FOR LEARNIG C SHARP */
using static Maths.Pythagoras;
using static Maths.Trigonometry;
using MathsObj;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipeWireItem zipeWireItem = new ZipeWireItem
            {
                Distance = 10,
                Degrees = 50
            };

            SkyScraperItem skyScraperItem = new SkyScraperItem
            {
                ToolLocate = 1,
                Distance = 50,
                Degrees = 82
            };
            Console.WriteLine(HeightOfSkyScraper(skyScraperItem));
        }
    }
}
