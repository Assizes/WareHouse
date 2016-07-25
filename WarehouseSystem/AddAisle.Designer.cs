namespace WarehouseSystem
{
    partial class AddAisle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtMaxWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAisleName = new System.Windows.Forms.TextBox();
            this.txtShelvesNumber = new System.Windows.Forms.TextBox();
            this.txtBinsNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aisle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Shelves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Bins on Each Shelf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Length";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtMaxWeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bins Characteristics";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(123, 120);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(118, 20);
            this.txtLength.TabIndex = 10;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(123, 92);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(118, 20);
            this.txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(123, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(118, 20);
            this.txtHeight.TabIndex = 8;
            // 
            // txtMaxWeight
            // 
            this.txtMaxWeight.Location = new System.Drawing.Point(123, 31);
            this.txtMaxWeight.Name = "txtMaxWeight";
            this.txtMaxWeight.Size = new System.Drawing.Size(118, 20);
            this.txtMaxWeight.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave);
            // 
            // txtAisleName
            // 
            this.txtAisleName.Location = new System.Drawing.Point(115, 46);
            this.txtAisleName.Name = "txtAisleName";
            this.txtAisleName.Size = new System.Drawing.Size(106, 20);
            this.txtAisleName.TabIndex = 10;
            // 
            // txtShelvesNumber
            // 
            this.txtShelvesNumber.Location = new System.Drawing.Point(406, 46);
            this.txtShelvesNumber.Name = "txtShelvesNumber";
            this.txtShelvesNumber.Size = new System.Drawing.Size(106, 20);
            this.txtShelvesNumber.TabIndex = 11;
            // 
            // txtBinsNumber
            // 
            this.txtBinsNumber.Location = new System.Drawing.Point(197, 107);
            this.txtBinsNumber.Name = "txtBinsNumber";
            this.txtBinsNumber.Size = new System.Drawing.Size(106, 20);
            this.txtBinsNumber.TabIndex = 12;
            // 
            // AddAisle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 402);
            this.Controls.Add(this.txtBinsNumber);
            this.Controls.Add(this.txtShelvesNumber);
            this.Controls.Add(this.txtAisleName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddAisle";
            this.Text = "AddAisle";
            this.Activated += new System.EventHandler(this.AddAisle_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAisle_FormClosing);
            this.Load += new System.EventHandler(this.AddAisle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAisleName;
        private System.Windows.Forms.TextBox txtShelvesNumber;
        private System.Windows.Forms.TextBox txtBinsNumber;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtMaxWeight;
    }
}