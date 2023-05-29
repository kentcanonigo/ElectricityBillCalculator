using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ElectricityBillCalculator
{
    internal class Calculation
    {
        public Calculation(int counter, float monthlyCost, float yearlyCost, string dateCalculated)
        {
            this.counter = counter;
            this.monthlyCost = monthlyCost;
            this.yearlyCost = yearlyCost;
            this.dateCalculated = dateCalculated;
        }

        public override string ToString()
        {
            return dateCalculated;
        }

        int counter;
        public string dateCalculated;
        public float monthlyCost;
        public float yearlyCost;
    }
}
