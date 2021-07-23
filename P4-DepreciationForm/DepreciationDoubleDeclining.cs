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
            return 333; //test


            //The double declining balance method is an accelerated form of depreciation under which most of the depreciation associated
            //with a fixed asset is recognized during the first few years of its useful life. This approach is reasonable under either of
            //the following two circumstances:
            //--When the utility of an asset is being consumed at a more rapid rate during the early part of its useful life; or
            //--When the intent is to recognize more expense now, thereby shifting profit recognition further into the future
            //(which may be of use for deferring income taxes).

            //etc

            //To calculate depreciation under the double declining method, multiply the asset book value at the beginning of the fiscal
            //year by a multiple of the straight-line rate of depreciation. The double declining balance formula is:

            //Double-declining balance(ceases when the book value = the estimated salvage value)
            //2  ×  Straight-line depreciation rate  ×  Book value at the beginning of the year
            //A variation on this method is the 150% declining balance method, which substitutes 1.5 for the 2.0 figure used in the calculation. The 150% method does not result in as rapid a rate of depreciation at the double declining method.

            //examplee

        }

        //ToString that returns a nicely formatted string, but add the fact that this item uses double declining depreciation.
        public override string ToString()
        {
            return "Title: " + Title +
                " Start Value: " + StartValue +
                " End Value: " + EndValue +
                " Lifetime: " + NumYearsLifetime +
                ". Uses double declining depreciation.";
        }
    }
}
