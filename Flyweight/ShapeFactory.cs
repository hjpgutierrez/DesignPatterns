using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase) && !shapeMap.TryGetValue("circle", out shape))
            {
                shape = new Circle();
                shapeMap.Add("circle", shape);
                Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
            }

            return shape;
        }
    }
}
