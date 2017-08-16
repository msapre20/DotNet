using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandwichSelectorr
{
    public partial class frmOrder : Form
    {
        private int BreadChoice, Cheesechoice,Ordernumber;

        public frmOrder()
        {
            //Initiallize Bread and Cheese choice
            InitializeComponent();
            BreadChoice = 1;
            Cheesechoice = 0;
            Ordernumber = 1;
          
        }
        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {
            // White Bread selected
            BreadChoice = 1;

        }

        private void rdoItalian_CheckedChanged(object sender, EventArgs e)
        {
            // Italian Bread selected
            BreadChoice = 2;
        }
        private void rdoWheat_CheckedChanged(object sender, EventArgs e)
        {
            // Wheat Bread selected
            BreadChoice = 3;
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            // None selected
            Cheesechoice = 0;
        }

        private void rdoAmerican_CheckedChanged(object sender, EventArgs e)
        {
            // American cheese selected
            Cheesechoice = 1;
        }

        private void rdoCheddar_CheckedChanged(object sender, EventArgs e)
        {
            // Cheddar cheese selected
            Cheesechoice = 2;
        }

        private void rdoPepperJack_CheckedChanged(object sender, EventArgs e)
        {
            //PepperJack cheese selected
            Cheesechoice = 3;
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            txtOrder.Text = "Sandwich Order:";
            txtOrder.Text = txtOrder.Text + Ordernumber;
            //Start order with Bread type

            switch (BreadChoice)
            {
                case 1:
                    txtOrder.Text = txtOrder.Text + "\nWhite Bread";
                    break;
                case 2:
                    txtOrder.Text = txtOrder.Text + "\nItalian Bread";
                    break;
                case 3:
                    txtOrder.Text = txtOrder.Text + "\nWheat Bread";
                    break;
            }
            switch (Cheesechoice)
            {
                case 0:
                    txtOrder.Text = txtOrder.Text + "\nNo Cheese";
                    break;
                case 1:
                    txtOrder.Text = txtOrder.Text + "\nAmerican Cheese";
                    break;
                case 2:
                    txtOrder.Text = txtOrder.Text + "\nCheddar cheese ";
                    break;
                case 3:
                    txtOrder.Text = txtOrder.Text + "\nPepperJack Cheese";
                    break;
            }

            //Add meat

             if (chkNone.Checked)
                  {
                      // In case of None set all other reset all other checkboxes if checked
                      chkFriedChicken.Checked = false;
                      chkRoastedBeef.Checked = false;
                      chkSalami.Checked = false;
                      txtOrder.Text = txtOrder.Text + "\nNo meat selected";
                  }
                  if (chkFriedChicken.Checked)
                  {

                      txtOrder.Text = txtOrder.Text + "\nFried Chicken";
                  }
                  if (chkRoastedBeef.Checked)
                  {

                      txtOrder.Text = txtOrder.Text + "\nRoasted Beef";
                  }
                  if (chkSalami.Checked)
                  {

                      txtOrder.Text = txtOrder.Text + "\nSalami";
                  }
            // Add Condiments
            foreach (Control ctrl in this.grpCondiments.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chkTemp = (CheckBox)ctrl;
                    if (chkTemp.Checked)
                    {
                        txtOrder.Text = txtOrder.Text + "\n" + chkTemp.Text;

                    }
                }
            }              
                         
          }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // set bread choice to white
            BreadChoice = 1;
            rdoWhite.Checked = true;

            // set CheeseChoice to None
            Cheesechoice = 0;
            rdoNone.Checked = true;

            // clear all meat and condiment choices
            foreach (Control ctrl in this.grpCondiments.Controls)
            {
                if (ctrl is CheckBox)
                {
                     CheckBox chkTemp1 = (CheckBox)ctrl;
                     chkTemp1.Checked = false;                   
                }
            }
            foreach (Control ctrl in this.grpMeats.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chkTemp1 = (CheckBox)ctrl;
                    chkTemp1.Checked = false;
                }
            }
            // clear text box
            txtOrder.Text = "";
            //Increment order number
            Ordernumber = Ordernumber + 1;
        }
    }
}
