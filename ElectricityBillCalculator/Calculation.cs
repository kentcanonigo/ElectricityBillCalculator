using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        int counter;
        float monthlyCost;
        float yearlyCost;
    }
}
