using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_DepreciationForm
{
    public partial class DepreciationForm : Form
    {
        //Initilizes list of Depreciation class objects and list of depreciation calculations
        private List<Depreciation> depreciationsList = new List<Depreciation>();
        private List<decimal> depreciationCalcs = new List<decimal>();

        public DepreciationForm()
        {
            InitializeComponent();
        }

        //
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //If straight line or double declining radio button checked, new instance of respective class, adds to list, refreshes list box
            if (radioButtonStraight.Checked)
            {
                //Instantiates a new instance of the DepreciationStraightLine class
                DepreciationStraightLine depreciationStraightLine = new DepreciationStraightLine();

                //Uses textbox/datetimepicker for the arguments needed in properties
                depreciationStraightLine.Title = textBoxTitle.Text;
                depreciationStraightLine.StartValue = Convert.ToDecimal(textBoxStartingValue.Text);
                depreciationStraightLine.EndValue = Convert.ToDecimal(textBoxEndValue.Text);
                depreciationStraightLine.NumYearsLifetime = Convert.ToInt32(textBoxLifetime.Text);
                depreciationStraightLine.DateTimeIn = dateTimePickerDateIn.Value;
                depreciationStraightLine.DateTimeOut = dateTimePickerDateOut.Value;

                //Adds new instance to class object list and decimal value to calculations list
                depreciationsList.Add(depreciationStraightLine);
                depreciationCalcs.Add(depreciationStraightLine.AnnualDepreciation);

                //Uses DataSource property to identify a collection object that the LIstBox will display
                //Refreshes the list box, points it to null then re-assigns it to cause the list box to refresh
                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList;
            }
  
            else if (radioButtonDouble.Checked)
            {
                DepreciationDoubleDeclining depreciationDoubleDeclining = new DepreciationDoubleDeclining();

                depreciationDoubleDeclining.Title = textBoxTitle.Text;
                depreciationDoubleDeclining.StartValue = Convert.ToDecimal(textBoxStartingValue.Text);
                depreciationDoubleDeclining.EndValue = Convert.ToDecimal(textBoxEndValue.Text);
                depreciationDoubleDeclining.NumYearsLifetime = Convert.ToInt32(textBoxLifetime.Text);
                depreciationDoubleDeclining.DateTimeIn = dateTimePickerDateIn.Value;
                depreciationDoubleDeclining.DateTimeOut = dateTimePickerDateOut.Value;

                depreciationsList.Add(depreciationDoubleDeclining);
                depreciationCalcs.Add(depreciationDoubleDeclining.AnnualDepreciation);

                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList;
            }
        }

        //Removes selected item in listBoxInventory after button click, doesn't remove list items yet -E
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxInventory.Items.Count > 0 && listBoxInventory.SelectedValue != null)
            {
                //implicit type var
                var inventoryItems = (List<Depreciation>)listBoxInventory.DataSource;
                var selectedInventoryItem = (Depreciation)listBoxInventory.SelectedValue;

                listBoxInventory.DataSource = null;
                listBoxInventory.Items.Clear();
                inventoryItems.Remove(selectedInventoryItem);
                listBoxInventory.DataSource = inventoryItems;
            }
        }

        //On calculate button click, totals list of calculations to display below button.
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Total of all depreciation calculations
            decimal calcTotal = 0;
                foreach (decimal item in depreciationCalcs)
                {
                    calcTotal += item;
                }

            //Prints final sum to final textbox
            textBoxCalcInvVal.Text = "The total of all depreciation calculations is: " + Convert.ToString(calcTotal);
        }
    }
}