namespace EthanShipleyCPRG200Lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPwrConsump = new System.Windows.Forms.Label();
            this.txtPwrConsump = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCalcChrg = new System.Windows.Forms.Label();
            this.txtCalcChrg = new System.Windows.Forms.TextBox();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.txtOffPk = new System.Windows.Forms.TextBox();
            this.lblOffPk = new System.Windows.Forms.Label();
            this.lblPkPwr = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.txtTotNoCust = new System.Windows.Forms.TextBox();
            this.txtChrgSum = new System.Windows.Forms.TextBox();
            this.txtSumRes = new System.Windows.Forms.TextBox();
            this.txtSumCom = new System.Windows.Forms.TextBox();
            this.txtSumInd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPwrConsump
            // 
            this.lblPwrConsump.AutoSize = true;
            this.lblPwrConsump.BackColor = System.Drawing.Color.Transparent;
            this.lblPwrConsump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwrConsump.Location = new System.Drawing.Point(12, 125);
            this.lblPwrConsump.Name = "lblPwrConsump";
            this.lblPwrConsump.Size = new System.Drawing.Size(233, 24);
            this.lblPwrConsump.TabIndex = 0;
            this.lblPwrConsump.Text = "Power consumption (kWh)";
            // 
            // txtPwrConsump
            // 
            this.txtPwrConsump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwrConsump.Location = new System.Drawing.Point(259, 122);
            this.txtPwrConsump.Name = "txtPwrConsump";
            this.txtPwrConsump.Size = new System.Drawing.Size(121, 29);
            this.txtPwrConsump.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(149, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCalcChrg
            // 
            this.lblCalcChrg.AutoSize = true;
            this.lblCalcChrg.BackColor = System.Drawing.Color.Transparent;
            this.lblCalcChrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcChrg.Location = new System.Drawing.Point(12, 231);
            this.lblCalcChrg.Name = "lblCalcChrg";
            this.lblCalcChrg.Size = new System.Drawing.Size(162, 24);
            this.lblCalcChrg.TabIndex = 0;
            this.lblCalcChrg.Text = "Calculated charge";
            // 
            // txtCalcChrg
            // 
            this.txtCalcChrg.Enabled = false;
            this.txtCalcChrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcChrg.Location = new System.Drawing.Point(259, 228);
            this.txtCalcChrg.Name = "txtCalcChrg";
            this.txtCalcChrg.Size = new System.Drawing.Size(121, 29);
            this.txtCalcChrg.TabIndex = 999999;
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.BackColor = System.Drawing.Color.Transparent;
            this.radRes.Checked = true;
            this.radRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes.Location = new System.Drawing.Point(15, 269);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(120, 28);
            this.radRes.TabIndex = 5;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = false;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.BackColor = System.Drawing.Color.Transparent;
            this.radCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCom.Location = new System.Drawing.Point(149, 270);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(129, 28);
            this.radCom.TabIndex = 6;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = false;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged);
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.BackColor = System.Drawing.Color.Transparent;
            this.radInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInd.Location = new System.Drawing.Point(283, 269);
            this.radInd.Name = "radInd";
            this.radInd.Size = new System.Drawing.Size(102, 28);
            this.radInd.TabIndex = 7;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = false;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged);
            // 
            // txtOffPk
            // 
            this.txtOffPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPk.Location = new System.Drawing.Point(259, 176);
            this.txtOffPk.Name = "txtOffPk";
            this.txtOffPk.Size = new System.Drawing.Size(121, 29);
            this.txtOffPk.TabIndex = 4;
            // 
            // lblOffPk
            // 
            this.lblOffPk.AutoSize = true;
            this.lblOffPk.BackColor = System.Drawing.Color.Transparent;
            this.lblOffPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPk.Location = new System.Drawing.Point(12, 169);
            this.lblOffPk.Name = "lblOffPk";
            this.lblOffPk.Size = new System.Drawing.Size(174, 48);
            this.lblOffPk.TabIndex = 0;
            this.lblOffPk.Text = "Off-peak power \nconsumption (kWh)";
            // 
            // lblPkPwr
            // 
            this.lblPkPwr.AutoSize = true;
            this.lblPkPwr.BackColor = System.Drawing.Color.Transparent;
            this.lblPkPwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkPwr.Location = new System.Drawing.Point(11, 108);
            this.lblPkPwr.Name = "lblPkPwr";
            this.lblPkPwr.Size = new System.Drawing.Size(174, 48);
            this.lblPkPwr.TabIndex = 0;
            this.lblPkPwr.Text = "Peak power \nconsumption (kWh)";
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(437, 19);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(361, 121);
            this.lstCustomer.TabIndex = 9999999;
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAcctNo.Location = new System.Drawing.Point(12, 23);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(156, 24);
            this.lblAcctNo.TabIndex = 10000000;
            this.lblAcctNo.Text = "Account number:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCustName.Location = new System.Drawing.Point(12, 74);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(149, 24);
            this.lblCustName.TabIndex = 10000000;
            this.lblCustName.Text = "Customer name:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(259, 71);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(121, 29);
            this.txtCustName.TabIndex = 2;
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNo.Location = new System.Drawing.Point(259, 20);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(121, 29);
            this.txtAcctNo.TabIndex = 1;
            // 
            // txtTotNoCust
            // 
            this.txtTotNoCust.Enabled = false;
            this.txtTotNoCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotNoCust.Location = new System.Drawing.Point(677, 153);
            this.txtTotNoCust.Name = "txtTotNoCust";
            this.txtTotNoCust.Size = new System.Drawing.Size(121, 29);
            this.txtTotNoCust.TabIndex = 999999;
            // 
            // txtChrgSum
            // 
            this.txtChrgSum.Enabled = false;
            this.txtChrgSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChrgSum.Location = new System.Drawing.Point(677, 188);
            this.txtChrgSum.Name = "txtChrgSum";
            this.txtChrgSum.Size = new System.Drawing.Size(121, 29);
            this.txtChrgSum.TabIndex = 999999;
            // 
            // txtSumRes
            // 
            this.txtSumRes.Enabled = false;
            this.txtSumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumRes.Location = new System.Drawing.Point(677, 223);
            this.txtSumRes.Name = "txtSumRes";
            this.txtSumRes.Size = new System.Drawing.Size(121, 29);
            this.txtSumRes.TabIndex = 999999;
            // 
            // txtSumCom
            // 
            this.txtSumCom.Enabled = false;
            this.txtSumCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumCom.Location = new System.Drawing.Point(677, 258);
            this.txtSumCom.Name = "txtSumCom";
            this.txtSumCom.Size = new System.Drawing.Size(121, 29);
            this.txtSumCom.TabIndex = 999999;
            // 
            // txtSumInd
            // 
            this.txtSumInd.Enabled = false;
            this.txtSumInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumInd.Location = new System.Drawing.Point(677, 293);
            this.txtSumInd.Name = "txtSumInd";
            this.txtSumInd.Size = new System.Drawing.Size(121, 29);
            this.txtSumInd.TabIndex = 999999;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total number customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sum of all charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sum of residents charges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sum of commercial charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sum of industrial charges";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 365);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.radInd);
            this.Controls.Add(this.radCom);
            this.Controls.Add(this.radRes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOffPk);
            this.Controls.Add(this.txtSumInd);
            this.Controls.Add(this.txtSumCom);
            this.Controls.Add(this.txtSumRes);
            this.Controls.Add(this.txtChrgSum);
            this.Controls.Add(this.txtTotNoCust);
            this.Controls.Add(this.txtCalcChrg);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtPwrConsump);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalcChrg);
            this.Controls.Add(this.lblPkPwr);
            this.Controls.Add(this.lblOffPk);
            this.Controls.Add(this.lblPwrConsump);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Power Cost Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwrConsump;
        private System.Windows.Forms.TextBox txtPwrConsump;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCalcChrg;
        private System.Windows.Forms.TextBox txtCalcChrg;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.TextBox txtOffPk;
        private System.Windows.Forms.Label lblOffPk;
        private System.Windows.Forms.Label lblPkPwr;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.TextBox txtTotNoCust;
        private System.Windows.Forms.TextBox txtChrgSum;
        private System.Windows.Forms.TextBox txtSumRes;
        private System.Windows.Forms.TextBox txtSumCom;
        private System.Windows.Forms.TextBox txtSumInd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

