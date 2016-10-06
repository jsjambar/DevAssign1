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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addCountriesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addCountriesToolStripMenuItem.Text = "View countries";
            this.addCountriesToolStripMenuItem.Click += new System.EventHandler(this.addCountriesToolStripMenuItem_Click);
            // 
            // addCountriesToolStripMenuItem1
            // 
            this.addCountriesToolStripMenuItem1.Name = "addCountriesToolStripMenuItem1";
            this.addCountriesToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
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
            this.viewPostalCodesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewPostalCodesToolStripMenuItem.Text = "View postal codes";
            this.viewPostalCodesToolStripMenuItem.Click += new System.EventHandler(this.viewPostalCodesToolStripMenuItem_Click);
            // 
            // addPostalCodesToolStripMenuItem
            // 
            this.addPostalCodesToolStripMenuItem.Name = "addPostalCodesToolStripMenuItem";
            this.addPostalCodesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addPostalCodesToolStripMenuItem.Text = "Add postal codes";
            this.addPostalCodesToolStripMenuItem.Click += new System.EventHandler(this.addPostalCodesToolStripMenuItem_Click);
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
            this.ControlPlaceholder.Location = new System.Drawing.Point(12, 24);
            this.ControlPlaceholder.Name = "ControlPlaceholder";
            this.ControlPlaceholder.Size = new System.Drawing.Size(976, 371);
            this.ControlPlaceholder.TabIndex = 3;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(66, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            this.viewAddressesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewAddressesToolStripMenuItem.Text = "View addresses";
            // 
            // addAddressesToolStripMenuItem
            // 
            this.addAddressesToolStripMenuItem.Name = "addAddressesToolStripMenuItem";
            this.addAddressesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addAddressesToolStripMenuItem.Text = "Add addresses";
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
            this.viewRolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewRolesToolStripMenuItem.Text = "View roles";
            this.viewRolesToolStripMenuItem.Click += new System.EventHandler(this.viewRolesToolStripMenuItem_Click);
            // 
            // addRolesToolStripMenuItem
            // 
            this.addRolesToolStripMenuItem.Name = "addRolesToolStripMenuItem";
            this.addRolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addRolesToolStripMenuItem.Text = "Add roles";
            this.addRolesToolStripMenuItem.Click += new System.EventHandler(this.addRolesToolStripMenuItem_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 431);
            this.Controls.Add(this.RefreshBtn);
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
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRolesToolStripMenuItem;
    }
}

