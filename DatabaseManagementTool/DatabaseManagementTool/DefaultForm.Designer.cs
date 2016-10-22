namespace DatabaseManagementTool
{
    partial class DefaultForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.postalCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPostalCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPostalCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAllTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenInformation = new System.Windows.Forms.Label();
            this.ControlPlaceholder = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(76, 17);
            this.StatusLabel.Text = "Default Form";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.postalCodesToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.viewProjectsToolStripMenuItem,
            this.viewEmployeesToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCountriesToolStripMenuItem,
            this.addCountriesToolStripMenuItem1});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // addCountriesToolStripMenuItem
            // 
            this.addCountriesToolStripMenuItem.Name = "addCountriesToolStripMenuItem";
            this.addCountriesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addCountriesToolStripMenuItem.Text = "View countries";
            this.addCountriesToolStripMenuItem.Click += new System.EventHandler(this.addCountriesToolStripMenuItem_Click);
            // 
            // addCountriesToolStripMenuItem1
            // 
            this.addCountriesToolStripMenuItem1.Name = "addCountriesToolStripMenuItem1";
            this.addCountriesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.addCountriesToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.addCountriesToolStripMenuItem1.Text = "Add countries";
            this.addCountriesToolStripMenuItem1.Click += new System.EventHandler(this.addCountriesToolStripMenuItem1_Click);
            // 
            // postalCodesToolStripMenuItem
            // 
            this.postalCodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPostalCodesToolStripMenuItem,
            this.addPostalCodesToolStripMenuItem});
            this.postalCodesToolStripMenuItem.Name = "postalCodesToolStripMenuItem";
            this.postalCodesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.postalCodesToolStripMenuItem.Text = "Postal codes";
            // 
            // viewPostalCodesToolStripMenuItem
            // 
            this.viewPostalCodesToolStripMenuItem.Name = "viewPostalCodesToolStripMenuItem";
            this.viewPostalCodesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.viewPostalCodesToolStripMenuItem.Text = "View postal codes";
            this.viewPostalCodesToolStripMenuItem.Click += new System.EventHandler(this.viewPostalCodesToolStripMenuItem_Click);
            // 
            // addPostalCodesToolStripMenuItem
            // 
            this.addPostalCodesToolStripMenuItem.Name = "addPostalCodesToolStripMenuItem";
            this.addPostalCodesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.addPostalCodesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addPostalCodesToolStripMenuItem.Text = "Add postal codes";
            this.addPostalCodesToolStripMenuItem.Click += new System.EventHandler(this.addPostalCodesToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAddressesToolStripMenuItem,
            this.addAddressesToolStripMenuItem});
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addressToolStripMenuItem.Text = "Address";
            // 
            // viewAddressesToolStripMenuItem
            // 
            this.viewAddressesToolStripMenuItem.Name = "viewAddressesToolStripMenuItem";
            this.viewAddressesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewAddressesToolStripMenuItem.Text = "View addresses";
            this.viewAddressesToolStripMenuItem.Click += new System.EventHandler(this.viewAddressesToolStripMenuItem_Click);
            // 
            // addAddressesToolStripMenuItem
            // 
            this.addAddressesToolStripMenuItem.Name = "addAddressesToolStripMenuItem";
            this.addAddressesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.addAddressesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addAddressesToolStripMenuItem.Text = "Add addresses";
            this.addAddressesToolStripMenuItem.Click += new System.EventHandler(this.addAddressesToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRolesToolStripMenuItem,
            this.addRolesToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // viewRolesToolStripMenuItem
            // 
            this.viewRolesToolStripMenuItem.Name = "viewRolesToolStripMenuItem";
            this.viewRolesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewRolesToolStripMenuItem.Text = "View roles";
            this.viewRolesToolStripMenuItem.Click += new System.EventHandler(this.viewRolesToolStripMenuItem_Click);
            // 
            // addRolesToolStripMenuItem
            // 
            this.addRolesToolStripMenuItem.Name = "addRolesToolStripMenuItem";
            this.addRolesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.addRolesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addRolesToolStripMenuItem.Text = "Add roles";
            this.addRolesToolStripMenuItem.Click += new System.EventHandler(this.addRolesToolStripMenuItem_Click);
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem});
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewProjectsToolStripMenuItem.Text = "View projects";
            this.viewProjectsToolStripMenuItem.Click += new System.EventHandler(this.viewProjectsToolStripMenuItem_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatabaseToolStripMenuItem,
            this.createAllTablesToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createDatabaseToolStripMenuItem.Text = "Create database";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // createAllTablesToolStripMenuItem
            // 
            this.createAllTablesToolStripMenuItem.Name = "createAllTablesToolStripMenuItem";
            this.createAllTablesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createAllTablesToolStripMenuItem.Text = "Create all tables";
            this.createAllTablesToolStripMenuItem.Click += new System.EventHandler(this.createAllTablesToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // ScreenInformation
            // 
            this.ScreenInformation.AutoSize = true;
            this.ScreenInformation.Location = new System.Drawing.Point(27, 49);
            this.ScreenInformation.Name = "ScreenInformation";
            this.ScreenInformation.Size = new System.Drawing.Size(0, 13);
            this.ScreenInformation.TabIndex = 1;
            // 
            // ControlPlaceholder
            // 
            this.ControlPlaceholder.Location = new System.Drawing.Point(159, 24);
            this.ControlPlaceholder.Name = "ControlPlaceholder";
            this.ControlPlaceholder.Size = new System.Drawing.Size(829, 371);
            this.ControlPlaceholder.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(27, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create countries";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(27, 107);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Create roles";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(27, 145);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(98, 13);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Create postalcodes";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(27, 182);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(91, 13);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Create employees";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(27, 222);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(78, 13);
            this.linkLabel5.TabIndex = 8;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Create projects";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(27, 264);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(78, 13);
            this.linkLabel6.TabIndex = 9;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Create address";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProjectsToolStripMenuItem1,
            this.addProjectsToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // viewProjectsToolStripMenuItem1
            // 
            this.viewProjectsToolStripMenuItem1.Name = "viewProjectsToolStripMenuItem1";
            this.viewProjectsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.viewProjectsToolStripMenuItem1.Text = "View projects";
            this.viewProjectsToolStripMenuItem1.Click += new System.EventHandler(this.viewProjectsToolStripMenuItem1_Click);
            // 
            // addProjectsToolStripMenuItem
            // 
            this.addProjectsToolStripMenuItem.Name = "addProjectsToolStripMenuItem";
            this.addProjectsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addProjectsToolStripMenuItem.Text = "Add projects";
            this.addProjectsToolStripMenuItem.Click += new System.EventHandler(this.addProjectsToolStripMenuItem_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 431);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ControlPlaceholder);
            this.Controls.Add(this.ScreenInformation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DefaultForm";
            this.Text = "Employee Management";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Label ScreenInformation;
        private System.Windows.Forms.FlowLayoutPanel ControlPlaceholder;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAllTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem postalCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPostalCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPostalCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRolesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addProjectsToolStripMenuItem;
    }
}

