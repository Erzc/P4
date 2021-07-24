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

        //Overrides the Calc method to use the Double Declining Depreciation methodology
        public override void Calc()
        {
            //If-else statement needed for when get numYearsLifeTime hasn't been called yet
            if (numYearsLifetime != 0.0M)
            {
                decimal doubleDepreciationRate = ((1.0M / NumYearsLifetime * 2.0M) * 100.0M);

                AnnualDepreciation = StartValue * (doubleDepreciationRate / 100.0M);
            }
            else
            {
                AnnualDepreciation = 2;
            }
        }

        //Auto-property - decimal for the annual double declining depreciation
        public override decimal AnnualDepreciation { get; set; }

        //ToString that returns a formatted string, text to indicate double declining depreciation
        public override string ToString()
        {
            return base.ToString() + ". Uses double declining depreciation.";
        }
    }
}