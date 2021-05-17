﻿namespace InheritanceEmployeesExample.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        { 
        }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base (name, hours, valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * this.AdditionalCharge;
        }

    }
}
