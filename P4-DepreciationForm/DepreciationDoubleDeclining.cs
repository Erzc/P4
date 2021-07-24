using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DepreciationForm
{
    //Inherits from DepreciationStraightLine class
    class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        //Inherits, so don’t have to repeat creating properties common to both classes

        //DepreciationDoubleDeclining will need to override the Calc method to use the Double Declining Depreciation methodology.


        public override void Calc()
        {
            decimal numYearsLifeTimeDecimal = Convert.ToDecimal(NumYearsLifetime);
            int count = 0;

            while (count < NumYearsLifetime)
            {
                count = count + 1;
                decimal depreciation = (EndValue * (2.0M / numYearsLifeTimeDecimal));
                AnnualStraightLineDepreciation -= depreciation;
            }
        }

        //Read-only auto-property - decimal for the total depreciation value
        public decimal EndValue { get; private set; }

        //ToString that returns a nicely formatted string, but add the fact that this item uses double declining depreciation.
        public override string ToString()
        {
            return base.ToString() + ". Uses double declining depreciation.";
        }
    }
}