using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxSystem.Entities
{
    internal class Individual : TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualincome, double healthexpenditures) : base(name, anualincome)
        {
            healthExpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (anualIncome < 20000.00)
            {
                return (anualIncome * 0.15) - (healthExpenditures / 2);
            }
            else
            {
                return (anualIncome * 0.25) - (healthExpenditures / 2);
            }
        }
    }
}
