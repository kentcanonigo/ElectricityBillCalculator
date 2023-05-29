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
        public Calculation(int counter, float monthlyCost, float yearlyCost)
        {
            this.counter = counter;
            this.monthlyCost = monthlyCost;
            this.yearlyCost = yearlyCost;
        }

        public override string ToString()
        {
            return counter.ToString();
        }

        int counter;
        public float monthlyCost;
        public float yearlyCost;
    }
}
