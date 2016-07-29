namespace WarehouseSystem
{
    partial class CustomerItem
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
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.btnCustomerItemClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Location = new System.Drawing.Point(12, 9);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(171, 13);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "Place Holder for Customer\'s Name ";
            // 
            // btnCustomerItemClose
            // 
            this.btnCustomerItemClose.Location = new System.Drawing.Point(635, 167);
            this.btnCustomerItemClose.Name = "btnCustomerItemClose";
            this.btnCustomerItemClose.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerItemClose.TabIndex = 2;
            this.btnCustomerItemClose.Text = "Close";
            this.btnCustomerItemClose.UseVisualStyleBackColor = true;
            this.btnCustomerItemClose.Click += new System.EventHandler(this.btnCustomerItemClose_Click);
            // 
            // CustomerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 336);
            this.Controls.Add(this.btnCustomerItemClose);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerItem";
            this.Text = "Customer\'s Items";
            this.Load += new System.EventHandler(this.CustomerItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.Button btnCustomerItemClose;
    }
}