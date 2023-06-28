using System;

namespace Maths
{
    class Circumference
    {
        const float CIRCLE_PHI = 3.14f;

        public static float CircleCircumference(int radius)
        {
            var formula = (2 * CIRCLE_PHI) * (float) radius;
            return formula;
        }
    }
}