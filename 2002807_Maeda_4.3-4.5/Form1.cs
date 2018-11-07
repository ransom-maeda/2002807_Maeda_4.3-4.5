using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_4._3_4._5
{
    public partial class Form1 : Form
    {
        //assigns transactionValue and balance variables
        private decimal transactionValue, depositTotal, checkTotal;
        private decimal balance = 0;
        private int depositNumber, checkNumber;

        public Form1()
        {
            InitializeComponent();
            balanceT.ReadOnly = true;
            depositAmountOutput.Visible = false;
            totalDepositAmount.Visible = false;
            checkAmountOutput.Visible = false;
            totalCheckDollar.Visible = false;
            labelDepositAmount.Visible = false;
            labelCheckAmount.Visible = false;
            labelDepositGain.Visible = false;
            labelCheckGain.Visible = false;
            depositAmountOutput.ReadOnly = true;
            totalDepositAmount.ReadOnly = true;
            checkAmountOutput.ReadOnly = true;
            totalCheckDollar.ReadOnly = true;
        }

        //Sets a function to add a deposit amount to the total balance
        private void processDeposit(decimal depositAmount)
        {
            balance += depositAmount;
            depositNumber++;
            depositTotal += depositAmount;
        }

        //Sets a function to subtract a service charge from the total balance
        private void processServiceCharge(decimal serviceChargeAmount)
        {
            balance -= serviceChargeAmount;
        }
        
        //Sets a function to subtract the check amount from the total balance
        private void processCheck(decimal checkAmount)
        {

            if (checkAmount > balance)
            {
                processServiceCharge(10);
                MessageBox.Show("Insufficient Funds", "Error");
            }
            else
            {
                balance -= checkAmount;
                checkNumber++;
                checkTotal += checkAmount;
            }


        }
        
        //Exits the application
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Sets a function to clear the transaction amount textbox and check the deposit radiobutton
        private void clearForm()
        {
            amountInput.Clear();
            deposit.Checked = true;
        }

        private void calculate_Click(object sender, EventArgs e)
        {

            try
            {

                transactionValue = decimal.Parse(amountInput.Text);
                if (balance < 0)
                {
                    MessageBox.Show("Not enough funds", "Error");
                    balance = 0;
                }                
                else
                {

                    //checks if the deposit radiobutton is checked and increments it to the value
                    if (deposit.Checked == true)
                    {
                        processDeposit(transactionValue);
                    }




                    //checks if the check radiobutton is checked and decrements it from the balance
                    else if (check.Checked == true)
                    {
                        processCheck(transactionValue);

                    }


                    //checks if the service charge radiobutton is checked and decrements it from the balance
                    else if (serviceCharge.Checked == true)
                    {
                        processServiceCharge(transactionValue);
                    }

                    //tells the user to select a transaction type
                    else
                    {
                        MessageBox.Show("Please select a transaction type", "Error");
                    }
                    //sets the balance textbox to the balance value (output)
                    balanceT.Text = balance.ToString("C");

                    //clears the transaction amount textbox and sets the radiobutton to deposit
                    clearForm();

                }
            }

            //if the code has a bad input or no input at all, display a message to the user
            catch
            {
                MessageBox.Show("Please input a valid transaction amount", "Error");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clears the transaction amount textbox and sets the radiobutton to deposit
            clearForm();
        }

        private void summary_Click(object sender, EventArgs e)
        {
            depositAmountOutput.Visible = true;
            totalDepositAmount.Visible = true;
            labelDepositAmount.Visible = true;
            checkAmountOutput.Visible = true;
            labelCheckAmount.Visible = true;
            labelDepositGain.Visible = true;
            totalCheckDollar.Visible = true;
            labelCheckGain.Visible = true;
            depositAmountOutput.Text = depositNumber.ToString();
            totalDepositAmount.Text = depositTotal.ToString("C");
            checkAmountOutput.Text = checkNumber.ToString();
            totalCheckDollar.Text = checkTotal.ToString("C");
        }
    }
}
