namespace WarehouseSystem
{
    partial class AddEditBins
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
            this.dgvBins = new System.Windows.Forms.DataGridView();
            this.btnAddBin = new System.Windows.Forms.Button();
            this.btnEditBin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBins
            // 
            this.dgvBins.AllowUserToAddRows = false;
            this.dgvBins.AllowUserToDeleteRows = false;
            this.dgvBins.AllowUserToResizeRows = false;
            this.dgvBins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBins.Location = new System.Drawing.Point(12, 12);
            this.dgvBins.MultiSelect = false;
            this.dgvBins.Name = "dgvBins";
            this.dgvBins.ReadOnly = true;
            this.dgvBins.RowHeadersVisible = false;
            this.dgvBins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBins.Size = new System.Drawing.Size(427, 413);
            this.dgvBins.TabIndex = 0;
            // 
            // btnAddBin
            // 
            this.btnAddBin.Location = new System.Drawing.Point(503, 100);
            this.btnAddBin.Name = "btnAddBin";
            this.btnAddBin.Size = new System.Drawing.Size(112, 28);
            this.btnAddBin.TabIndex = 1;
            this.btnAddBin.Text = "Add Bin";
            this.btnAddBin.UseVisualStyleBackColor = true;
            this.btnAddBin.Click += new System.EventHandler(this.btnAddBin_Click);
            // 
            // btnEditBin
            // 
            this.btnEditBin.Location = new System.Drawing.Point(503, 153);
            this.btnEditBin.Name = "btnEditBin";
            this.btnEditBin.Size = new System.Drawing.Size(112, 28);
            this.btnEditBin.TabIndex = 2;
            this.btnEditBin.Text = "Edit Bin";
            this.btnEditBin.UseVisualStyleBackColor = true;
            this.btnEditBin.Click += new System.EventHandler(this.btnEditBin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Bin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditBins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 438);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditBin);
            this.Controls.Add(this.btnAddBin);
            this.Controls.Add(this.dgvBins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditBins";
            this.Text = "AddEditBins";
            this.Activated += new System.EventHandler(this.AddEditBins_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditBins_FormClosing);
            this.Load += new System.EventHandler(this.AddEditBins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBins;
        private System.Windows.Forms.Button btnAddBin;
        private System.Windows.Forms.Button btnEditBin;
        private System.Windows.Forms.Button btnDelete;
    }
}