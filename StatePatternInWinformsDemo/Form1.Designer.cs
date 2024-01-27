namespace StatePatternDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            editToolStripButton = new ToolStripButton();
            deleteToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            tslblTaxpayerID = new ToolStripLabel();
            tscboTaxpayerID = new ToolStripComboBox();
            tslblYear = new ToolStripLabel();
            tscboYear = new ToolStripComboBox();
            tslblAmendmentNo = new ToolStripLabel();
            tscboAmendmentNo = new ToolStripComboBox();
            menuStrip1 = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            purchasesToolStripMenuItem = new ToolStripMenuItem();
            linkLabel1 = new LinkLabel();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, editToolStripButton, deleteToolStripButton, printToolStripButton, tslblTaxpayerID, tscboTaxpayerID, tslblYear, tscboYear, tslblAmendmentNo, tscboAmendmentNo });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1185, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(29, 25);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // editToolStripButton
            // 
            editToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editToolStripButton.Image = (Image)resources.GetObject("editToolStripButton.Image");
            editToolStripButton.ImageTransparentColor = Color.Magenta;
            editToolStripButton.Name = "editToolStripButton";
            editToolStripButton.Size = new Size(29, 25);
            editToolStripButton.Text = "&Edit";
            editToolStripButton.Click += editToolStripButton_Click;
            // 
            // deleteToolStripButton
            // 
            deleteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteToolStripButton.Image = (Image)resources.GetObject("deleteToolStripButton.Image");
            deleteToolStripButton.ImageTransparentColor = Color.Magenta;
            deleteToolStripButton.Name = "deleteToolStripButton";
            deleteToolStripButton.Size = new Size(29, 25);
            deleteToolStripButton.Text = "&Delete";
            deleteToolStripButton.Click += deleteToolStripButton_Click;
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(29, 25);
            printToolStripButton.Text = "&Print";
            printToolStripButton.Click += printToolStripButton_Click;
            // 
            // tslblTaxpayerID
            // 
            tslblTaxpayerID.Name = "tslblTaxpayerID";
            tslblTaxpayerID.Padding = new Padding(80, 0, 0, 0);
            tslblTaxpayerID.Size = new Size(147, 25);
            tslblTaxpayerID.Text = "Taxpayer";
            tslblTaxpayerID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tscboTaxpayerID
            // 
            tscboTaxpayerID.Items.AddRange(new object[] { "ABC Corporation", "XYZ Company" });
            tscboTaxpayerID.Name = "tscboTaxpayerID";
            tscboTaxpayerID.Size = new Size(500, 28);
            // 
            // tslblYear
            // 
            tslblYear.Name = "tslblYear";
            tslblYear.Padding = new Padding(20, 0, 0, 0);
            tslblYear.Size = new Size(57, 25);
            tslblYear.Text = "Year";
            tslblYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tscboYear
            // 
            tscboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            tscboYear.Items.AddRange(new object[] { "2024", "2023", "2022" });
            tscboYear.Name = "tscboYear";
            tscboYear.Size = new Size(80, 28);
            // 
            // tslblAmendmentNo
            // 
            tslblAmendmentNo.Name = "tslblAmendmentNo";
            tslblAmendmentNo.Padding = new Padding(20, 0, 0, 0);
            tslblAmendmentNo.Size = new Size(135, 25);
            tslblAmendmentNo.Text = "Amendment No";
            tslblAmendmentNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tscboAmendmentNo
            // 
            tscboAmendmentNo.DropDownStyle = ComboBoxStyle.DropDownList;
            tscboAmendmentNo.Items.AddRange(new object[] { "2", "1", "0" });
            tscboAmendmentNo.Name = "tscboAmendmentNo";
            tscboAmendmentNo.Size = new Size(75, 28);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, rolesToolStripMenuItem, salesToolStripMenuItem, purchasesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1185, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "&Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(59, 24);
            rolesToolStripMenuItem.Text = "&Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(57, 24);
            salesToolStripMenuItem.Text = "&Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // purchasesToolStripMenuItem
            // 
            purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            purchasesToolStripMenuItem.Size = new Size(87, 24);
            purchasesToolStripMenuItem.Text = "&Purchases";
            purchasesToolStripMenuItem.Click += purchasesToolStripMenuItem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkArea = new LinkArea(19, 15);
            linkLabel1.Location = new Point(407, 286);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(230, 33);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Toolstrip icons by Icons8";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 605);
            Controls.Add(linkLabel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton editToolStripButton;
        private ToolStripButton deleteToolStripButton;
        private ToolStripButton printToolStripButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem purchasesToolStripMenuItem;
        private LinkLabel linkLabel1;
        private ToolStripLabel tslblYear;
        private ToolStripComboBox tscboYear;
        private ToolStripLabel tslblAmendmentNo;
        private ToolStripComboBox tscboAmendmentNo;
        private ToolStripLabel tslblTaxpayerID;
        private ToolStripComboBox tscboTaxpayerID;
    }
}