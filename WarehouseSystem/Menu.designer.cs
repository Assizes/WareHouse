namespace WarehouseSystem
{
    partial class menuForm
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
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.imgChanges = new System.Windows.Forms.PictureBox();
            this.imgWaiting = new System.Windows.Forms.PictureBox();
            this.imgParking = new System.Windows.Forms.PictureBox();
            this.imgLockers = new System.Windows.Forms.PictureBox();
            this.imgTenant = new System.Windows.Forms.PictureBox();
            this.imgBuildings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLockers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuildings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse System";
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventory.Location = new System.Drawing.Point(14, 196);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(106, 23);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClients
            // 
            this.btnClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClients.Location = new System.Drawing.Point(147, 196);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(106, 23);
            this.btnClients.TabIndex = 8;
            this.btnClients.Text = "Tenants";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(280, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Storage Lockers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(413, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Parking Lot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(546, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Waiting List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(680, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Changes Made";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // imgChanges
            // 
            this.imgChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgChanges.Location = new System.Drawing.Point(680, 84);
            this.imgChanges.Name = "imgChanges";
            this.imgChanges.Size = new System.Drawing.Size(106, 106);
            this.imgChanges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgChanges.TabIndex = 6;
            this.imgChanges.TabStop = false;
            this.imgChanges.Click += new System.EventHandler(this.imgChanges_Click);
            // 
            // imgWaiting
            // 
            this.imgWaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgWaiting.Location = new System.Drawing.Point(546, 84);
            this.imgWaiting.Name = "imgWaiting";
            this.imgWaiting.Size = new System.Drawing.Size(106, 106);
            this.imgWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWaiting.TabIndex = 5;
            this.imgWaiting.TabStop = false;
            this.imgWaiting.Click += new System.EventHandler(this.imgWaiting_Click);
            // 
            // imgParking
            // 
            this.imgParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgParking.Location = new System.Drawing.Point(413, 84);
            this.imgParking.Name = "imgParking";
            this.imgParking.Size = new System.Drawing.Size(106, 106);
            this.imgParking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgParking.TabIndex = 4;
            this.imgParking.TabStop = false;
            this.imgParking.Click += new System.EventHandler(this.imgParking_Click);
            // 
            // imgLockers
            // 
            this.imgLockers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLockers.Location = new System.Drawing.Point(280, 84);
            this.imgLockers.Name = "imgLockers";
            this.imgLockers.Size = new System.Drawing.Size(106, 106);
            this.imgLockers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLockers.TabIndex = 3;
            this.imgLockers.TabStop = false;
            this.imgLockers.Click += new System.EventHandler(this.imgLockers_Click);
            // 
            // imgTenant
            // 
            this.imgTenant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgTenant.Location = new System.Drawing.Point(147, 84);
            this.imgTenant.Name = "imgTenant";
            this.imgTenant.Size = new System.Drawing.Size(106, 106);
            this.imgTenant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTenant.TabIndex = 2;
            this.imgTenant.TabStop = false;
            this.imgTenant.Click += new System.EventHandler(this.imgTenant_Click);
            // 
            // imgBuildings
            // 
            this.imgBuildings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgBuildings.Location = new System.Drawing.Point(14, 84);
            this.imgBuildings.Name = "imgBuildings";
            this.imgBuildings.Size = new System.Drawing.Size(106, 106);
            this.imgBuildings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuildings.TabIndex = 1;
            this.imgBuildings.TabStop = false;
            this.imgBuildings.Click += new System.EventHandler(this.imgBuildings_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.imgChanges);
            this.Controls.Add(this.imgWaiting);
            this.Controls.Add(this.imgParking);
            this.Controls.Add(this.imgLockers);
            this.Controls.Add(this.imgTenant);
            this.Controls.Add(this.imgBuildings);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menuForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.menuForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.imgChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLockers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuildings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBuildings;
        private System.Windows.Forms.PictureBox imgTenant;
        private System.Windows.Forms.PictureBox imgLockers;
        private System.Windows.Forms.PictureBox imgParking;
        private System.Windows.Forms.PictureBox imgWaiting;
        private System.Windows.Forms.PictureBox imgChanges;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

