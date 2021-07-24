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

        private List<Depreciation> depreciationsList = new List<Depreciation>();

        private List<decimal> depreciationCalcs = new List<decimal>();

        public DepreciationForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonStraight.Checked)
            {

                DepreciationStraightLine depreciationStraightLine = new DepreciationStraightLine();

                depreciationStraightLine.Title = textBoxTitle.Text;
                depreciationStraightLine.StartValue = Convert.ToDecimal(textBoxStartingValue.Text);
                depreciationStraightLine.EndValue = Convert.ToDecimal(textBoxEndValue.Text);
                depreciationStraightLine.NumYearsLifetime = Convert.ToInt32(textBoxLifetime.Text);
                depreciationStraightLine.DateTimeIn = dateTimePickerDateIn.Value;
                depreciationStraightLine.DateTimeOut = dateTimePickerDateOut.Value;

                //A depreciations list of Depretiation class objects
                depreciationsList.Add(depreciationStraightLine);

                depreciationCalcs.Add(depreciationStraightLine.AnnualStraightLineDepreciation);

                //Uses DataSource property to identify a collection object that the LIstBox will display
                //Refreshes the list box, points it to null then re-assigns it to cause the list box to refresh
                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList; //CHANGE THIS FOR TOSTRING STUFF???
            }
  
            else if (radioButtonDouble.Checked)
            {
                //Adds DepreciationDoubleDeclining polymorphically
                DepreciationDoubleDeclining depreciationDoubleDeclining = new DepreciationDoubleDeclining();

                depreciationsList.Add(depreciationDoubleDeclining);

                depreciationCalcs.Add(depreciationDoubleDeclining.AnnualStraightLineDepreciation);

                //Refreshes the list box
                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList;
            }
        }

        //Removes selected item in listBoxInventory after button click
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
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //testingstuff //sets total calculations ~~~~~~~~~~~~~~~~
            //decimal[] scoreIntArrays = depreciationCalcs.ToArray();

            int scoreTotal = 0;
                foreach (int score in depreciationCalcs)
                {
                    scoreTotal += score;
                }

            //Displays total in textBoxCalcInvVal
            //textBoxCalcInvVal.Text = Convert.ToString(scoreTotal);

            //.............just list
            textBoxCalcInvVal.Text = String.Join(Environment.NewLine, depreciationCalcs);
        }
    }
}