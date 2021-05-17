namespace AbstractConceptsExample.Entities.Enums
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();
       
    }
}
