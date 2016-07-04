namespace WarehouseSystem
{
    partial class Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(352, 354);
            this.dataGridView1.TabIndex = 8;
            // 
            // deleteUser
            // 
            this.deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUser.Location = new System.Drawing.Point(417, 318);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(96, 29);
            this.deleteUser.TabIndex = 7;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            // 
            // editUser
            // 
            this.editUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editUser.Location = new System.Drawing.Point(417, 111);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(96, 29);
            this.editUser.TabIndex = 6;
            this.editUser.Text = "Edit";
            this.editUser.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUser.Location = new System.Drawing.Point(417, 40);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(96, 29);
            this.addUser.TabIndex = 5;
            this.addUser.Text = "Add";
            this.addUser.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.addUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(580, 420);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button addUser;
    }
}