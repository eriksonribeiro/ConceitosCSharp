using System;

namespace InheritanceProductExercise.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
          : base(name, price)
        {
            this.ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{this.Name} (used) $ {this.Price:f2} (Manufacture Date: {this.ManufactureDate.ToString("dd/MM/yyyy")} )";
        }
    }
}
