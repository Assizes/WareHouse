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
            this.dgvShelves = new System.Windows.Forms.DataGridView();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.btnEditShelf = new System.Windows.Forms.Button();
            this.btnDeleteShelf = new System.Windows.Forms.Button();
            this.btnAddAisle = new System.Windows.Forms.Button();
            this.btnDeleteAisle = new System.Windows.Forms.Button();
            this.dgvAisles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAisles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShelves
            // 
            this.dgvShelves.AllowUserToAddRows = false;
            this.dgvShelves.AllowUserToDeleteRows = false;
            this.dgvShelves.AllowUserToResizeRows = false;
            this.dgvShelves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShelves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShelves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelves.Location = new System.Drawing.Point(21, 22);
            this.dgvShelves.Name = "dgvShelves";
            this.dgvShelves.ReadOnly = true;
            this.dgvShelves.RowHeadersVisible = false;
            this.dgvShelves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShelves.Size = new System.Drawing.Size(387, 347);
            this.dgvShelves.TabIndex = 0;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShelf.Location = new System.Drawing.Point(21, 386);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(88, 30);
            this.btnAddShelf.TabIndex = 1;
            this.btnAddShelf.Text = "Add Shelf";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // btnEditShelf
            // 
            this.btnEditShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditShelf.Location = new System.Drawing.Point(124, 386);
            this.btnEditShelf.Name = "btnEditShelf";
            this.btnEditShelf.Size = new System.Drawing.Size(88, 30);
            this.btnEditShelf.TabIndex = 2;
            this.btnEditShelf.Text = "Edit Shelf";
            this.btnEditShelf.UseVisualStyleBackColor = true;
            this.btnEditShelf.Click += new System.EventHandler(this.btnEditShelf_Click);
            // 
            // btnDeleteShelf
            // 
            this.btnDeleteShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteShelf.Location = new System.Drawing.Point(320, 386);
            this.btnDeleteShelf.Name = "btnDeleteShelf";
            this.btnDeleteShelf.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteShelf.TabIndex = 3;
            this.btnDeleteShelf.Text = "Delete Shelf";
            this.btnDeleteShelf.UseVisualStyleBackColor = true;
            this.btnDeleteShelf.Click += new System.EventHandler(this.btnDeleteShelf_Click);
            // 
            // btnAddAisle
            // 
            this.btnAddAisle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAisle.Location = new System.Drawing.Point(18, 386);
            this.btnAddAisle.Name = "btnAddAisle";
            this.btnAddAisle.Size = new System.Drawing.Size(88, 30);
            this.btnAddAisle.TabIndex = 5;
            this.btnAddAisle.Text = "Add Aisle";
            this.btnAddAisle.UseVisualStyleBackColor = true;
            this.btnAddAisle.Click += new System.EventHandler(this.btnAddAisle_Click);
            // 
            // btnDeleteAisle
            // 
            this.btnDeleteAisle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAisle.Location = new System.Drawing.Point(170, 386);
            this.btnDeleteAisle.Name = "btnDeleteAisle";
            this.btnDeleteAisle.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteAisle.TabIndex = 6;
            this.btnDeleteAisle.Text = "Delete Aisle";
            this.btnDeleteAisle.UseVisualStyleBackColor = true;
            this.btnDeleteAisle.Click += new System.EventHandler(this.btnDeleteAisle_Click);
            // 
            // dgvAisles
            // 
            this.dgvAisles.AllowUserToAddRows = false;
            this.dgvAisles.AllowUserToDeleteRows = false;
            this.dgvAisles.AllowUserToResizeRows = false;
            this.dgvAisles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAisles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAisles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAisles.Location = new System.Drawing.Point(18, 22);
            this.dgvAisles.Name = "dgvAisles";
            this.dgvAisles.ReadOnly = true;
            this.dgvAisles.RowHeadersVisible = false;
            this.dgvAisles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAisles.Size = new System.Drawing.Size(240, 347);
            this.dgvAisles.TabIndex = 7;
            this.dgvAisles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAisles_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAisles);
            this.groupBox1.Controls.Add(this.btnDeleteAisle);
            this.groupBox1.Controls.Add(this.btnAddAisle);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 435);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aisles";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btnDeleteShelf);
            this.groupBox2.Controls.Add(this.btnEditShelf);
            this.groupBox2.Controls.Add(this.btnAddShelf);
            this.groupBox2.Controls.Add(this.dgvShelves);
            this.groupBox2.Location = new System.Drawing.Point(299, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 433);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shelves";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(744, 509);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Activated += new System.EventHandler(this.Warehouse_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_FormClosing);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAisles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShelves;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Button btnEditShelf;
        private System.Windows.Forms.Button btnDeleteShelf;
        private System.Windows.Forms.Button btnAddAisle;
        private System.Windows.Forms.Button btnDeleteAisle;
        private System.Windows.Forms.DataGridView dgvAisles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}