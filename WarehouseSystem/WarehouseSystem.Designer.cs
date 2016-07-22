namespace WarehouseSystem
{
    partial class WarehouseSystem
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
            this.loginScreen = new System.Windows.Forms.Panel();
            this.passInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signBtn = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginScreen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginScreen.Controls.Add(this.passInput);
            this.loginScreen.Controls.Add(this.loginInput);
            this.loginScreen.Controls.Add(this.passwordLabel);
            this.loginScreen.Controls.Add(this.signBtn);
            this.loginScreen.Controls.Add(this.loginLabel);
            this.loginScreen.Location = new System.Drawing.Point(237, 154);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(361, 255);
            this.loginScreen.TabIndex = 1;
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInput.Location = new System.Drawing.Point(114, 100);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(144, 23);
            this.passInput.TabIndex = 2;
            // 
            // loginInput
            // 
            this.loginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(114, 58);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(144, 23);
            this.loginInput.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(13, 100);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // signBtn
            // 
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signBtn.Location = new System.Drawing.Point(92, 182);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(166, 39);
            this.signBtn.TabIndex = 3;
            this.signBtn.Text = "Sign in";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(43, 58);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 20);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.toolStripUsersMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.clientsToolStripMenuItem.Text = "Customers";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Enabled = false;
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // toolStripUsersMenu
            // 
            this.toolStripUsersMenu.Enabled = false;
            this.toolStripUsersMenu.Name = "toolStripUsersMenu";
            this.toolStripUsersMenu.Size = new System.Drawing.Size(47, 20);
            this.toolStripUsersMenu.Text = "Users";
            this.toolStripUsersMenu.Click += new System.EventHandler(this.toolStripUsersMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 20);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Visible = false;
            // 
            // WarehouseSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "WarehouseSystem";
            this.Text = "WarehouseSystem";
            this.Load += new System.EventHandler(this.WarehouseSystem_Load);
            this.SizeChanged += new System.EventHandler(this.WarehouseSystem_SizeChanged);
            this.loginScreen.ResumeLayout(false);
            this.loginScreen.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsersMenu;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

