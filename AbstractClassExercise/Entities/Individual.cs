namespace AbstractClassExercise.Entities
{
    class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxesCalculation()
        {
            double taxes  = 0.00;
            double refund = 0.00;

            if (AnualIncome < 20000.00 )
                taxes = AnualIncome * 0.15;
            else
                taxes = AnualIncome * 0.25;

            if (HealthExpenditures > 0.00)
                refund = HealthExpenditures * 0.5;

            return taxes - refund;
        }

    }
}
