namespace WarehouseSystem
{
    partial class Inventory
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 14);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(533, 305);
            this.dgvInventory.TabIndex = 0;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(574, 113);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(104, 23);
            this.btnAddInventory.TabIndex = 2;
            this.btnAddInventory.Text = "Add Inventory";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.Location = new System.Drawing.Point(574, 157);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(104, 23);
            this.btnEditInventory.TabIndex = 3;
            this.btnEditInventory.Text = "Edit Inventory";
            this.btnEditInventory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Location = new System.Drawing.Point(574, 205);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteInventory.TabIndex = 4;
            this.btnDeleteInventory.Text = "Delete Inventory";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 329);
            this.Controls.Add(this.btnDeleteInventory);
            this.Controls.Add(this.btnEditInventory);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.dgvInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Button btnDeleteInventory;
    }
}