using System;
using MathsObj;

namespace Maths
{
    public class Pythagoras
    {
        public static string TriaglePythagoras(PythagorasItem pythagorasItem)
        {
            int formula;
            int squareRoot;
            int powerNum = 2;

            double doubleHypotenus = (double) pythagorasItem.Hypotenuse;
            double doubleBase = (double) pythagorasItem.TriagleBase;
            double doubleHeight = (double) pythagorasItem.TriagleHeight;

            if (pythagorasItem.TriagleBase != 0 && pythagorasItem.TriagleHeight != 0)
            {
                formula = (int)(pythagorasItem.Hypotenuse + (Math.Pow(doubleBase, powerNum) + Math.Pow(doubleHeight, powerNum)));
                squareRoot = (int)Math.Sqrt(formula);
                return $"Hypotenuse of triagle is {squareRoot}";
            }

            if (pythagorasItem.Hypotenuse != 0 && pythagorasItem.TriagleHeight != 0)
            {
                formula = (int)(pythagorasItem.TriagleBase + (Math.Pow(doubleHypotenus, powerNum) - Math.Pow(doubleHeight, powerNum)));
                var positiveNumber = Math.Abs(formula);
                squareRoot = (int)Math.Sqrt(positiveNumber);
                return $"Base of triagle is {squareRoot}";
            }

            if (pythagorasItem.Hypotenuse != 0 && pythagorasItem.TriagleBase != 0)
            {
                formula = (int)(pythagorasItem.TriagleHeight + (Math.Pow(doubleHypotenus, powerNum) - Math.Pow(doubleBase, powerNum)));
                var positiveNumber = Math.Abs(formula);
                squareRoot = (int)Math.Sqrt(positiveNumber);
                return $"Height of triagle is {squareRoot}";
            }

            throw new ArgumentException("Sorry, 1 of the 3 argument must be 0");
        }
    }
}