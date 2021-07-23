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

        private List<DepreciationStraightLine> depreciationsList = new List<DepreciationStraightLine>();

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

                //Uses DataSource property to identify a collection object that the LIstBox will display
                //Refreshes the list box, points it to null then re-assigns it to cause the list box to refresh
                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList; //CHANGE THIS FOR TOSTRING STUFF???

            }
  
            else if (radioButtonDouble.Checked)
            {
                //Adds DepreciationDoubleDeclining value polymorphically
                DepreciationDoubleDeclining depreciationDoubleDeclining = new DepreciationDoubleDeclining();

                depreciationsList.Add(depreciationStraightLine);

                //Refreshes the list box
                listBoxInventory.DataSource = null;
                listBoxInventory.DataSource = depreciationsList;
            
            }
        }
    }
}