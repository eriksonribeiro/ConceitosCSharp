using AbstractConceptsExample.Entities.Enums;
using System;

namespace AbstractConceptsExample.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius): base (color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
