using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DepreciationForm
{
    public class DepreciationStraightLine : Depreciation
    {
        //Declare variables
        private string title;
        private DateTime dateTimeAddedToInventory;
        private DateTime dateTimeRemovedFromInventory;
        private decimal startValue;
        private decimal endValue;
        public int numYearsLifetime;

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
                return numYearsLifetime;
            }
            set
            {
                numYearsLifetime = value;
                Calc();
            }
        }

        //Auto-property - decimal for the annual straight line depreciation
        public virtual decimal AnnualDepreciation { get; set; }

        //Virtual method calculates annual straight line depreciation
        public virtual void Calc()
        {
            //If-else statement needed for when get numYearsLifeTime hasn't been called yet
            if (numYearsLifetime != 0.0M)
            {
                AnnualDepreciation = (startValue - endValue) * (1.0M / numYearsLifetime);
            }
            else
            {
                AnnualDepreciation = 5;
            }
        }

        //ToString that returns a formatted string
        public override string ToString()
        {
            return "Title: " + Title +
                " Start Value: " + StartValue +
                " End Value: " + EndValue +
                " Lifetime: " + NumYearsLifetime;
        }
    }
}