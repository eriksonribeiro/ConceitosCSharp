namespace AbstractClassExercise.Entities
{    abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payer(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }

        public abstract double TaxesCalculation();

        public override string ToString()
        {
            return $"{Name}: $ {TaxesCalculation():f2}";
        }
    }
}
