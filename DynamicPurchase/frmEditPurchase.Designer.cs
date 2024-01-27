namespace DynamicPurchase
{
    partial class frmEditPurchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierTIN = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPercentageTax = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // txtSupplierTIN
            // 
            this.txtSupplierTIN.Location = new System.Drawing.Point(137, 47);
            this.txtSupplierTIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierTIN.Name = "txtSupplierTIN";
            this.txtSupplierTIN.Size = new System.Drawing.Size(223, 27);
            this.txtSupplierTIN.TabIndex = 1;
            this.txtSupplierTIN.Validated += new System.EventHandler(this.txtSupplierTIN_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(733, 482);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblVAT
            // 
            this.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVAT.Location = new System.Drawing.Point(167, 377);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(183, 34);
            this.lblVAT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percentage Tax";
            // 
            // lblPercentageTax
            // 
            this.lblPercentageTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPercentageTax.Location = new System.Drawing.Point(625, 377);
            this.lblPercentageTax.Name = "lblPercentageTax";
            this.lblPercentageTax.Size = new System.Drawing.Size(183, 34);
            this.lblPercentageTax.TabIndex = 5;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(137, 82);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(287, 27);
            this.txtSupplierName.TabIndex = 7;
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(829, 82);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(83, 27);
            this.txtDocNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doc No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "TIN";
            // 
            // frmEditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPercentageTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSupplierTIN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierTIN;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPercentageTax;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

