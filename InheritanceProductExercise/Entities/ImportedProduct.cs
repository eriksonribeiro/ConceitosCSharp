namespace InheritanceProductExercise.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base (name, price)
        {
            this.CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return this.Price + this.CustomsFee; 
        }
        public override string priceTag()
        {
            return $"{this.Name} $ {TotalPrice():f2} (Customs Fee: $ {this.CustomsFee:f2} )";
        }
    }
}
