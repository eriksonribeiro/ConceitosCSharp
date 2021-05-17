namespace AbstractClassExercise.Entities
{
    class Company : Payer
    {
        public int EmployeeNumber { get; set; }
        public Company(string name, double anualIncome, int employeeNumber)
            : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }
        public override double TaxesCalculation()
        {
            if (EmployeeNumber > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;

        }
    }
}
