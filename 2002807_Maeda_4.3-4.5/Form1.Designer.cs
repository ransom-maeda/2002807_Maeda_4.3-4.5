namespace _2002807_Maeda_4._3_4._5
{
    partial class Form1
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
            this.exit = new System.Windows.Forms.Button();
            this.boxTransaction = new System.Windows.Forms.GroupBox();
            this.serviceCharge = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.RadioButton();
            this.deposit = new System.Windows.Forms.RadioButton();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.balanceT = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Button();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            this.depositAmountOutput = new System.Windows.Forms.TextBox();
            this.labelDepositGain = new System.Windows.Forms.Label();
            this.totalDepositAmount = new System.Windows.Forms.TextBox();
            this.checkAmountOutput = new System.Windows.Forms.TextBox();
            this.totalCheckDollar = new System.Windows.Forms.TextBox();
            this.labelCheckGain = new System.Windows.Forms.Label();
            this.labelCheckAmount = new System.Windows.Forms.Label();
            this.boxTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // boxTransaction
            // 
            this.boxTransaction.Controls.Add(this.serviceCharge);
            this.boxTransaction.Controls.Add(this.check);
            this.boxTransaction.Controls.Add(this.deposit);
            this.boxTransaction.Location = new System.Drawing.Point(12, 12);
            this.boxTransaction.Name = "boxTransaction";
            this.boxTransaction.Size = new System.Drawing.Size(116, 123);
            this.boxTransaction.TabIndex = 1;
            this.boxTransaction.TabStop = false;
            this.boxTransaction.Text = "Transaction Type";
            // 
            // serviceCharge
            // 
            this.serviceCharge.AutoSize = true;
            this.serviceCharge.Location = new System.Drawing.Point(6, 97);
            this.serviceCharge.Name = "serviceCharge";
            this.serviceCharge.Size = new System.Drawing.Size(98, 17);
            this.serviceCharge.TabIndex = 2;
            this.serviceCharge.Text = "Service Charge";
            this.serviceCharge.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(6, 58);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(56, 17);
            this.check.TabIndex = 1;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            // 
            // deposit
            // 
            this.deposit.AutoSize = true;
            this.deposit.Checked = true;
            this.deposit.Location = new System.Drawing.Point(6, 19);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(61, 17);
            this.deposit.TabIndex = 0;
            this.deposit.TabStop = true;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(242, 14);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 2;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(134, 17);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(102, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Transaction Amount";
            // 
            // calculate
            // 
            this.calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculate.Location = new System.Drawing.Point(18, 151);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(99, 151);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // balanceT
            // 
            this.balanceT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.balanceT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balanceT.Location = new System.Drawing.Point(242, 70);
            this.balanceT.Name = "balanceT";
            this.balanceT.Size = new System.Drawing.Size(100, 20);
            this.balanceT.TabIndex = 6;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(134, 73);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "Balance";
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(180, 151);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(75, 23);
            this.summary.TabIndex = 8;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.AutoSize = true;
            this.labelDepositAmount.Location = new System.Drawing.Point(15, 181);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(100, 13);
            this.labelDepositAmount.TabIndex = 9;
            this.labelDepositAmount.Text = "Number of Deposits";
            // 
            // depositAmountOutput
            // 
            this.depositAmountOutput.Location = new System.Drawing.Point(163, 178);
            this.depositAmountOutput.Name = "depositAmountOutput";
            this.depositAmountOutput.Size = new System.Drawing.Size(100, 20);
            this.depositAmountOutput.TabIndex = 10;
            // 
            // labelDepositGain
            // 
            this.labelDepositGain.AutoSize = true;
            this.labelDepositGain.Location = new System.Drawing.Point(15, 226);
            this.labelDepositGain.Name = "labelDepositGain";
            this.labelDepositGain.Size = new System.Drawing.Size(129, 13);
            this.labelDepositGain.TabIndex = 11;
            this.labelDepositGain.Text = "Dollar Amount of Deposits";
            // 
            // totalDepositAmount
            // 
            this.totalDepositAmount.Location = new System.Drawing.Point(163, 223);
            this.totalDepositAmount.Name = "totalDepositAmount";
            this.totalDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.totalDepositAmount.TabIndex = 12;
            // 
            // checkAmountOutput
            // 
            this.checkAmountOutput.Location = new System.Drawing.Point(163, 268);
            this.checkAmountOutput.Name = "checkAmountOutput";
            this.checkAmountOutput.Size = new System.Drawing.Size(100, 20);
            this.checkAmountOutput.TabIndex = 13;
            // 
            // totalCheckDollar
            // 
            this.totalCheckDollar.Location = new System.Drawing.Point(163, 313);
            this.totalCheckDollar.Name = "totalCheckDollar";
            this.totalCheckDollar.Size = new System.Drawing.Size(100, 20);
            this.totalCheckDollar.TabIndex = 14;
            // 
            // labelCheckGain
            // 
            this.labelCheckGain.AutoSize = true;
            this.labelCheckGain.Location = new System.Drawing.Point(15, 316);
            this.labelCheckGain.Name = "labelCheckGain";
            this.labelCheckGain.Size = new System.Drawing.Size(124, 13);
            this.labelCheckGain.TabIndex = 16;
            this.labelCheckGain.Text = "Dollar Amount of Checks";
            // 
            // labelCheckAmount
            // 
            this.labelCheckAmount.AutoSize = true;
            this.labelCheckAmount.Location = new System.Drawing.Point(15, 271);
            this.labelCheckAmount.Name = "labelCheckAmount";
            this.labelCheckAmount.Size = new System.Drawing.Size(95, 13);
            this.labelCheckAmount.TabIndex = 15;
            this.labelCheckAmount.Text = "Number of Checks";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCheckGain);
            this.Controls.Add(this.labelCheckAmount);
            this.Controls.Add(this.totalCheckDollar);
            this.Controls.Add(this.checkAmountOutput);
            this.Controls.Add(this.totalDepositAmount);
            this.Controls.Add(this.labelDepositGain);
            this.Controls.Add(this.depositAmountOutput);
            this.Controls.Add(this.labelDepositAmount);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.balanceT);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.boxTransaction);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "4.3 - 4.5";
            this.boxTransaction.ResumeLayout(false);
            this.boxTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox boxTransaction;
        private System.Windows.Forms.RadioButton serviceCharge;
        private System.Windows.Forms.RadioButton check;
        private System.Windows.Forms.RadioButton deposit;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox balanceT;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.TextBox depositAmountOutput;
        private System.Windows.Forms.Label labelDepositGain;
        private System.Windows.Forms.TextBox totalDepositAmount;
        private System.Windows.Forms.TextBox checkAmountOutput;
        private System.Windows.Forms.TextBox totalCheckDollar;
        private System.Windows.Forms.Label labelCheckGain;
        private System.Windows.Forms.Label labelCheckAmount;
    }
}

