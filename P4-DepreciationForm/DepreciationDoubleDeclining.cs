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


        public override decimal Calc()
        {
            decimal numYearsLifeTimeDecimal = Convert.ToDecimal(NumYearsLifetime);
            int count = 0;

            while (count < NumYearsLifetime)
            {
                count = count + 1;
                decimal depreciation = (EndValue * (2 / numYearsLifeTimeDecimal));
                EndValue -= depreciation;

                return EndValue;
            }

            return 0;
        }

        //ToString that returns a nicely formatted string, but add the fact that this item uses double declining depreciation.
        public override string ToString()
        {
            return base.ToString() + ". Uses double declining depreciation.";
        }
    }
}