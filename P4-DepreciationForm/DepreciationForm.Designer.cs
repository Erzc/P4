
namespace P4_DepreciationForm
{
    partial class DepreciationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHow = new System.Windows.Forms.TabPage();
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.labelIntroTitle = new System.Windows.Forms.Label();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonStraight = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.labelDateIn = new System.Windows.Forms.Label();
            this.textBoxLifetime = new System.Windows.Forms.TextBox();
            this.textBoxEndValue = new System.Windows.Forms.TextBox();
            this.textBoxStartingValue = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelLifetime = new System.Windows.Forms.Label();
            this.labelEndValue = new System.Windows.Forms.Label();
            this.labelStartingValue = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxCalcInvVal = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageHow.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHow);
            this.tabControl1.Controls.Add(this.tabPageInventory);
            this.tabControl1.Controls.Add(this.tabPageSummary);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHow
            // 
            this.tabPageHow.Controls.Add(this.textBoxInstructions);
            this.tabPageHow.Controls.Add(this.labelIntroTitle);
            this.tabPageHow.Location = new System.Drawing.Point(4, 22);
            this.tabPageHow.Name = "tabPageHow";
            this.tabPageHow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHow.Size = new System.Drawing.Size(728, 425);
            this.tabPageHow.TabIndex = 0;
            this.tabPageHow.Text = "How to use this application";
            this.tabPageHow.UseVisualStyleBackColor = true;
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Location = new System.Drawing.Point(100, 153);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.ReadOnly = true;
            this.textBoxInstructions.Size = new System.Drawing.Size(518, 96);
            this.textBoxInstructions.TabIndex = 1;
            this.textBoxInstructions.Text = "Hello, and welcome to the Super Duper Depreciation Calculator 5000. Enter your in" +
    "ventory in the \"Inventory\" tab. Then go to the \"Summary\" tab to find the value o" +
    "f your inventory.";
            this.textBoxInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIntroTitle
            // 
            this.labelIntroTitle.AutoSize = true;
            this.labelIntroTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntroTitle.Location = new System.Drawing.Point(94, 62);
            this.labelIntroTitle.Name = "labelIntroTitle";
            this.labelIntroTitle.Size = new System.Drawing.Size(524, 31);
            this.labelIntroTitle.TabIndex = 0;
            this.labelIntroTitle.Text = "Super Duper Depreciation Calculator 5000";
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.buttonRemove);
            this.tabPageInventory.Controls.Add(this.buttonAdd);
            this.tabPageInventory.Controls.Add(this.radioButtonDouble);
            this.tabPageInventory.Controls.Add(this.radioButtonStraight);
            this.tabPageInventory.Controls.Add(this.dateTimePickerDateOut);
            this.tabPageInventory.Controls.Add(this.dateTimePickerDateIn);
            this.tabPageInventory.Controls.Add(this.labelDateOut);
            this.tabPageInventory.Controls.Add(this.labelDateIn);
            this.tabPageInventory.Controls.Add(this.textBoxLifetime);
            this.tabPageInventory.Controls.Add(this.textBoxEndValue);
            this.tabPageInventory.Controls.Add(this.textBoxStartingValue);
            this.tabPageInventory.Controls.Add(this.textBoxTitle);
            this.tabPageInventory.Controls.Add(this.labelLifetime);
            this.tabPageInventory.Controls.Add(this.labelEndValue);
            this.tabPageInventory.Controls.Add(this.labelStartingValue);
            this.tabPageInventory.Controls.Add(this.labelTitle);
            this.tabPageInventory.Controls.Add(this.listBoxInventory);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(728, 425);
            this.tabPageInventory.TabIndex = 1;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(32, 358);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(244, 36);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Remove Selected Item From Inventory";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(338, 310);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(272, 36);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add Form Item To Inventory";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(410, 277);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(106, 17);
            this.radioButtonDouble.TabIndex = 14;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "Double Declining";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // radioButtonStraight
            // 
            this.radioButtonStraight.AutoSize = true;
            this.radioButtonStraight.Location = new System.Drawing.Point(410, 253);
            this.radioButtonStraight.Name = "radioButtonStraight";
            this.radioButtonStraight.Size = new System.Drawing.Size(84, 17);
            this.radioButtonStraight.TabIndex = 13;
            this.radioButtonStraight.TabStop = true;
            this.radioButtonStraight.Text = "Straight Line";
            this.radioButtonStraight.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(426, 215);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOut.TabIndex = 12;
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(426, 180);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateIn.TabIndex = 11;
            // 
            // labelDateOut
            // 
            this.labelDateOut.AutoSize = true;
            this.labelDateOut.Location = new System.Drawing.Point(309, 215);
            this.labelDateOut.Name = "labelDateOut";
            this.labelDateOut.Size = new System.Drawing.Size(106, 13);
            this.labelDateOut.TabIndex = 10;
            this.labelDateOut.Text = "Date out of inventory";
            // 
            // labelDateIn
            // 
            this.labelDateIn.AutoSize = true;
            this.labelDateIn.Location = new System.Drawing.Point(309, 180);
            this.labelDateIn.Name = "labelDateIn";
            this.labelDateIn.Size = new System.Drawing.Size(87, 13);
            this.labelDateIn.TabIndex = 9;
            this.labelDateIn.Text = "Date in inventory";
            // 
            // textBoxLifetime
            // 
            this.textBoxLifetime.Location = new System.Drawing.Point(427, 144);
            this.textBoxLifetime.Name = "textBoxLifetime";
            this.textBoxLifetime.Size = new System.Drawing.Size(200, 20);
            this.textBoxLifetime.TabIndex = 8;
            // 
            // textBoxEndValue
            // 
            this.textBoxEndValue.Location = new System.Drawing.Point(427, 107);
            this.textBoxEndValue.Name = "textBoxEndValue";
            this.textBoxEndValue.Size = new System.Drawing.Size(200, 20);
            this.textBoxEndValue.TabIndex = 7;
            // 
            // textBoxStartingValue
            // 
            this.textBoxStartingValue.Location = new System.Drawing.Point(427, 72);
            this.textBoxStartingValue.Name = "textBoxStartingValue";
            this.textBoxStartingValue.Size = new System.Drawing.Size(200, 20);
            this.textBoxStartingValue.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(427, 39);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelLifetime
            // 
            this.labelLifetime.AutoSize = true;
            this.labelLifetime.Location = new System.Drawing.Point(309, 144);
            this.labelLifetime.Name = "labelLifetime";
            this.labelLifetime.Size = new System.Drawing.Size(77, 13);
            this.labelLifetime.TabIndex = 4;
            this.labelLifetime.Text = "Lifetime (years)";
            // 
            // labelEndValue
            // 
            this.labelEndValue.AutoSize = true;
            this.labelEndValue.Location = new System.Drawing.Point(309, 107);
            this.labelEndValue.Name = "labelEndValue";
            this.labelEndValue.Size = new System.Drawing.Size(65, 13);
            this.labelEndValue.TabIndex = 3;
            this.labelEndValue.Text = "End Value $";
            // 
            // labelStartingValue
            // 
            this.labelStartingValue.AutoSize = true;
            this.labelStartingValue.Location = new System.Drawing.Point(309, 72);
            this.labelStartingValue.Name = "labelStartingValue";
            this.labelStartingValue.Size = new System.Drawing.Size(82, 13);
            this.labelStartingValue.TabIndex = 2;
            this.labelStartingValue.Text = "Starting Value $";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(309, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.HorizontalScrollbar = true;
            this.listBoxInventory.Location = new System.Drawing.Point(20, 23);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(268, 329);
            this.listBoxInventory.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.textBoxCalcInvVal);
            this.tabPageSummary.Controls.Add(this.buttonCalculate);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 22);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(728, 425);
            this.tabPageSummary.TabIndex = 2;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(200, 132);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(310, 38);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate Inventory Value";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxCalcInvVal
            // 
            this.textBoxCalcInvVal.Location = new System.Drawing.Point(165, 208);
            this.textBoxCalcInvVal.Multiline = true;
            this.textBoxCalcInvVal.Name = "textBoxCalcInvVal";
            this.textBoxCalcInvVal.ReadOnly = true;
            this.textBoxCalcInvVal.Size = new System.Drawing.Size(373, 52);
            this.textBoxCalcInvVal.TabIndex = 1;
            // 
            // DepreciationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "DepreciationForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHow.ResumeLayout(false);
            this.tabPageHow.PerformLayout();
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHow;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.Label labelIntroTitle;
        private System.Windows.Forms.TextBox textBoxInstructions;
        private System.Windows.Forms.ListBox listBoxInventory;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.Label labelDateIn;
        private System.Windows.Forms.TextBox textBoxLifetime;
        private System.Windows.Forms.TextBox textBoxEndValue;
        private System.Windows.Forms.TextBox textBoxStartingValue;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelLifetime;
        private System.Windows.Forms.Label labelEndValue;
        private System.Windows.Forms.Label labelStartingValue;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonStraight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxCalcInvVal;
    }
}

