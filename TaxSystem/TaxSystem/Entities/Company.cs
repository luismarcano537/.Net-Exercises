using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TaxSystem.Entities
{
    internal class Company : TaxPayer
    {
        public int numberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualincome, int numberofemployees) : base(name, anualincome)
        {
            numberOfEmployees = numberofemployees;
        }

        public override double Tax()
        {
            if (numberOfEmployees > 10)
            {
                return anualIncome * 0.14;
            }
            else
            {
                return anualIncome * 0.16;
            }
        }
    }
}
