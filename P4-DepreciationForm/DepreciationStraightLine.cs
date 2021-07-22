using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DepreciationForm
{
    public class DepreciationStraightLine
    {
        //DepreciationStraightLine will have properties for a string title for the item, the DateTime values for the date the item
        //goes into and out of inventory, decimal values for the start value and end of life value, an int for the number of years
        //of lifetime. 
        //The set part of properties should call a calc method that calculates the salvage value using straight line depreciation
        //methodology. There should also be a ToString that date returns a nicely formatted string that has the title, start value,
        //end value and lifetime.

        //-----

        //Straight line depreciation is used to recognize the carrying amount of a fixed asset evenly over its useful life.
        //It is employed when there is no particular pattern to the manner in which an asset is to be utilized over time. 

        /*
        straight-line calculation steps are:
        1.	Determine the initial cost of the asset that has been recognized as a fixed asset.
        2.	Subtract the estimated salvage value of the asset from the amount at which it is recorded on the books.
        3.	Determine the estimated useful life of the asset. It is easiest to use a standard useful life for each class of assets.
        4.	Divide the estimated useful life (in years) into 1 to arrive at the straight-line depreciation rate.
        5.	Multiply the depreciation rate by the asset cost (less salvage value).
        */

        //Once calculated, depreciation expense is recorded in the accounting records as a debit to the depreciation expense account
        //and a credit to the accumulated depreciation account. Accumulated depreciation is a contra asset account, which means that
        //it is paired with and reduces the fixed asset account.

        //example
    }
}
