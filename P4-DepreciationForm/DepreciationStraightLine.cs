using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DepreciationForm
{
    public class DepreciationStraightLine
    {
        //Declare variables
        private string title; //
        private DateTime dateTimeAddedToInventory;
        private DateTime dateTimeRemovedFromInventory;
        private decimal startValue;
        private decimal endValue;
        private int numYearsLifetime;

        //Properties for a string title for the item, the DateTime values for the date the item
        //goes into and out of inventory, decimal values for the start value and end of life value, an int for the number of years
        //of lifetime. 

        //Public gettable and settable properties. Set part calls calc method

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
                Calc();
            }
        }

        public DateTime DateTimeIn
        {
            get
            {
                return this.dateTimeAddedToInventory;
            }
            set
            {
                this.dateTimeAddedToInventory = value;
                Calc();
            }
        }

        public DateTime DateTimeOut
        {
            get
            {
                return this.dateTimeRemovedFromInventory;
            }
            set
            {
                this.dateTimeRemovedFromInventory = value;
                Calc();
            }
        }

        public decimal StartValue
        {
            get
            {
                return this.startValue;
            }
            set
            {
                this.startValue = value;
                Calc();
            }
        }

        public decimal EndValue
        {
            get
            {
                return this.endValue;
            }
            set
            {
                this.endValue = value;
                Calc();
            }
        }

        public int NumYearsLifetime
        {
            get
            {
                return this.numYearsLifetime;
            }
            set
            {
                this.numYearsLifetime = value;
                Calc();
            }
        }

        //Method calculates the salvage value using straight line depreciation methodology
        public virtual decimal Calc() //virtual???
        {
            return 555; //test

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

            /*
            Pensive Corporation purchases the Procrastinator Deluxe machine for $60,000. It has an estimated salvage value of $10,000
            and a useful life of five years. Pensive calculates the annual straight-line depreciation for the machine as:

            Purchase cost of $60,000 – estimated salvage value of $10,000 = Depreciable asset cost of $50,000
            1 / 5-year useful life = 20% depreciation rate per year
            20% depreciation rate x $50,000 depreciable asset cost = $10,000 annual depreciation

             */

        }

        //ToString that returns a nicely formatted string
        public override string ToString()
        {
            return "Title: " + Title +
                " Start Value: " + StartValue +
                " End Value: " + EndValue +
                " Lifetime: " + NumYearsLifetime;
        }
    }
}
