namespace WarehouseSystem
{
    partial class Customers
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
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(574, 205);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteCustomers.TabIndex = 8;
            this.btnDeleteCustomers.Text = "Delete Customers";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Location = new System.Drawing.Point(574, 157);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(104, 23);
            this.btnEditCustomers.TabIndex = 7;
            this.btnEditCustomers.Text = "Edit Customers";
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(574, 113);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(104, 23);
            this.btnAddCustomers.TabIndex = 6;
            this.btnAddCustomers.Text = "Add Customers";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 14);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(533, 305);
            this.dgvCustomers.TabIndex = 5;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 329);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnEditCustomers);
            this.Controls.Add(this.btnAddCustomers);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}