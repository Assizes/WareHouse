namespace WarehouseSystem
{
    partial class Warehouse
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
            this.btnAddAisle = new System.Windows.Forms.Button();
            this.btnEditAisle = new System.Windows.Forms.Button();
            this.btnDeleteAisle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(413, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddAisle
            // 
            this.btnAddAisle.Location = new System.Drawing.Point(485, 51);
            this.btnAddAisle.Name = "btnAddAisle";
            this.btnAddAisle.Size = new System.Drawing.Size(113, 30);
            this.btnAddAisle.TabIndex = 1;
            this.btnAddAisle.Text = "Add Aisle";
            this.btnAddAisle.UseVisualStyleBackColor = true;
            this.btnAddAisle.Click += new System.EventHandler(this.btnAddAisle_Click);
            // 
            // btnEditAisle
            // 
            this.btnEditAisle.Location = new System.Drawing.Point(485, 109);
            this.btnEditAisle.Name = "btnEditAisle";
            this.btnEditAisle.Size = new System.Drawing.Size(113, 30);
            this.btnEditAisle.TabIndex = 2;
            this.btnEditAisle.Text = "Edit Aisle";
            this.btnEditAisle.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAisle
            // 
            this.btnDeleteAisle.Location = new System.Drawing.Point(485, 202);
            this.btnDeleteAisle.Name = "btnDeleteAisle";
            this.btnDeleteAisle.Size = new System.Drawing.Size(113, 30);
            this.btnDeleteAisle.TabIndex = 3;
            this.btnDeleteAisle.Text = "Delete Aisle";
            this.btnDeleteAisle.UseVisualStyleBackColor = true;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 397);
            this.Controls.Add(this.btnDeleteAisle);
            this.Controls.Add(this.btnEditAisle);
            this.Controls.Add(this.btnAddAisle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Activated += new System.EventHandler(this.Warehouse_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAisle;
        private System.Windows.Forms.Button btnEditAisle;
        private System.Windows.Forms.Button btnDeleteAisle;
    }
}