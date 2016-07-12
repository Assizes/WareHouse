namespace WarehouseSystem
{
    partial class AddEditInventory
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
            this.grpbxAddItem = new System.Windows.Forms.GroupBox();
            this.cmbItemCustomer = new System.Windows.Forms.ComboBox();
            this.lblItemCustomer = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblAddCustomerLName = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.grpItemProperties = new System.Windows.Forms.GroupBox();
            this.rdoExpirationNo = new System.Windows.Forms.RadioButton();
            this.rdoExpirationYes = new System.Windows.Forms.RadioButton();
            this.cmbUnitofMeasurement = new System.Windows.Forms.ComboBox();
            this.datetimeItemExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblExpirationDateQuestion = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.txtItemWeight = new System.Windows.Forms.TextBox();
            this.txtItemHeight = new System.Windows.Forms.TextBox();
            this.txtItemWidth = new System.Windows.Forms.TextBox();
            this.txtItemLength = new System.Windows.Forms.TextBox();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblItemWeight = new System.Windows.Forms.Label();
            this.lblItemHeight = new System.Windows.Forms.Label();
            this.lblItemWidth = new System.Windows.Forms.Label();
            this.lblItemLength = new System.Windows.Forms.Label();
            this.grpbxItemLocation = new System.Windows.Forms.GroupBox();
            this.cmbItemBin = new System.Windows.Forms.ComboBox();
            this.cmbItemShelf = new System.Windows.Forms.ComboBox();
            this.cmbItemAisle = new System.Windows.Forms.ComboBox();
            this.btnItemLocation = new System.Windows.Forms.Button();
            this.lblItemBin = new System.Windows.Forms.Label();
            this.lblItemShelf = new System.Windows.Forms.Label();
            this.lblItemAisle = new System.Windows.Forms.Label();
            this.btnItemAddSave = new System.Windows.Forms.Button();
            this.btnItemResetCancel = new System.Windows.Forms.Button();
            this.grpbxAddItem.SuspendLayout();
            this.grpItemProperties.SuspendLayout();
            this.grpbxItemLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxAddItem
            // 
            this.grpbxAddItem.Controls.Add(this.cmbItemCustomer);
            this.grpbxAddItem.Controls.Add(this.lblItemCustomer);
            this.grpbxAddItem.Controls.Add(this.cmbItemCategory);
            this.grpbxAddItem.Controls.Add(this.lblItemCategory);
            this.grpbxAddItem.Controls.Add(this.txtItemDescription);
            this.grpbxAddItem.Controls.Add(this.txtItemName);
            this.grpbxAddItem.Controls.Add(this.lblAddCustomerLName);
            this.grpbxAddItem.Controls.Add(this.lblItemName);
            this.grpbxAddItem.Location = new System.Drawing.Point(12, 12);
            this.grpbxAddItem.Name = "grpbxAddItem";
            this.grpbxAddItem.Size = new System.Drawing.Size(687, 175);
            this.grpbxAddItem.TabIndex = 1;
            this.grpbxAddItem.TabStop = false;
            this.grpbxAddItem.Text = "Item";
            // 
            // cmbItemCustomer
            // 
            this.cmbItemCustomer.FormattingEnabled = true;
            this.cmbItemCustomer.Location = new System.Drawing.Point(513, 88);
            this.cmbItemCustomer.Name = "cmbItemCustomer";
            this.cmbItemCustomer.Size = new System.Drawing.Size(142, 21);
            this.cmbItemCustomer.TabIndex = 35;
            // 
            // lblItemCustomer
            // 
            this.lblItemCustomer.AutoSize = true;
            this.lblItemCustomer.Location = new System.Drawing.Point(458, 91);
            this.lblItemCustomer.Name = "lblItemCustomer";
            this.lblItemCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblItemCustomer.TabIndex = 34;
            this.lblItemCustomer.Text = "Customer";
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(308, 29);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(104, 21);
            this.cmbItemCategory.TabIndex = 33;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(257, 32);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(49, 13);
            this.lblItemCategory.TabIndex = 6;
            this.lblItemCategory.Text = "Category";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(112, 61);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(300, 99);
            this.txtItemDescription.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(112, 29);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(112, 20);
            this.txtItemName.TabIndex = 4;
            // 
            // lblAddCustomerLName
            // 
            this.lblAddCustomerLName.AutoSize = true;
            this.lblAddCustomerLName.Location = new System.Drawing.Point(26, 64);
            this.lblAddCustomerLName.Name = "lblAddCustomerLName";
            this.lblAddCustomerLName.Size = new System.Drawing.Size(60, 13);
            this.lblAddCustomerLName.TabIndex = 1;
            this.lblAddCustomerLName.Text = "Description";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(59, 32);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(27, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item";
            // 
            // grpItemProperties
            // 
            this.grpItemProperties.Controls.Add(this.rdoExpirationNo);
            this.grpItemProperties.Controls.Add(this.rdoExpirationYes);
            this.grpItemProperties.Controls.Add(this.cmbUnitofMeasurement);
            this.grpItemProperties.Controls.Add(this.datetimeItemExpiration);
            this.grpItemProperties.Controls.Add(this.lblExpirationDate);
            this.grpItemProperties.Controls.Add(this.lblExpirationDateQuestion);
            this.grpItemProperties.Controls.Add(this.txtItemQuantity);
            this.grpItemProperties.Controls.Add(this.txtItemWeight);
            this.grpItemProperties.Controls.Add(this.txtItemHeight);
            this.grpItemProperties.Controls.Add(this.txtItemWidth);
            this.grpItemProperties.Controls.Add(this.txtItemLength);
            this.grpItemProperties.Controls.Add(this.lblItemQuantity);
            this.grpItemProperties.Controls.Add(this.lblItemWeight);
            this.grpItemProperties.Controls.Add(this.lblItemHeight);
            this.grpItemProperties.Controls.Add(this.lblItemWidth);
            this.grpItemProperties.Controls.Add(this.lblItemLength);
            this.grpItemProperties.Location = new System.Drawing.Point(12, 193);
            this.grpItemProperties.Name = "grpItemProperties";
            this.grpItemProperties.Size = new System.Drawing.Size(687, 190);
            this.grpItemProperties.TabIndex = 15;
            this.grpItemProperties.TabStop = false;
            this.grpItemProperties.Text = "Properties";
            // 
            // rdoExpirationNo
            // 
            this.rdoExpirationNo.AutoSize = true;
            this.rdoExpirationNo.Checked = true;
            this.rdoExpirationNo.Location = new System.Drawing.Point(243, 122);
            this.rdoExpirationNo.Name = "rdoExpirationNo";
            this.rdoExpirationNo.Size = new System.Drawing.Size(39, 17);
            this.rdoExpirationNo.TabIndex = 34;
            this.rdoExpirationNo.TabStop = true;
            this.rdoExpirationNo.Text = "No";
            this.rdoExpirationNo.UseVisualStyleBackColor = true;
            // 
            // rdoExpirationYes
            // 
            this.rdoExpirationYes.AutoSize = true;
            this.rdoExpirationYes.Location = new System.Drawing.Point(194, 122);
            this.rdoExpirationYes.Name = "rdoExpirationYes";
            this.rdoExpirationYes.Size = new System.Drawing.Size(43, 17);
            this.rdoExpirationYes.TabIndex = 33;
            this.rdoExpirationYes.TabStop = true;
            this.rdoExpirationYes.Text = "Yes";
            this.rdoExpirationYes.UseVisualStyleBackColor = true;
            // 
            // cmbUnitofMeasurement
            // 
            this.cmbUnitofMeasurement.FormattingEnabled = true;
            this.cmbUnitofMeasurement.Location = new System.Drawing.Point(274, 76);
            this.cmbUnitofMeasurement.Name = "cmbUnitofMeasurement";
            this.cmbUnitofMeasurement.Size = new System.Drawing.Size(55, 21);
            this.cmbUnitofMeasurement.TabIndex = 32;
            // 
            // datetimeItemExpiration
            // 
            this.datetimeItemExpiration.Location = new System.Drawing.Point(137, 156);
            this.datetimeItemExpiration.Name = "datetimeItemExpiration";
            this.datetimeItemExpiration.Size = new System.Drawing.Size(200, 20);
            this.datetimeItemExpiration.TabIndex = 31;
            this.datetimeItemExpiration.TabStop = false;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(45, 162);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpirationDate.TabIndex = 30;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblExpirationDateQuestion
            // 
            this.lblExpirationDateQuestion.AutoSize = true;
            this.lblExpirationDateQuestion.Location = new System.Drawing.Point(5, 124);
            this.lblExpirationDateQuestion.Name = "lblExpirationDateQuestion";
            this.lblExpirationDateQuestion.Size = new System.Drawing.Size(174, 13);
            this.lblExpirationDateQuestion.TabIndex = 27;
            this.lblExpirationDateQuestion.Text = "Does item have an expiration date?";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(214, 76);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(54, 20);
            this.txtItemQuantity.TabIndex = 26;
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.Location = new System.Drawing.Point(93, 76);
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(54, 20);
            this.txtItemWeight.TabIndex = 25;
            // 
            // txtItemHeight
            // 
            this.txtItemHeight.Location = new System.Drawing.Point(349, 34);
            this.txtItemHeight.Name = "txtItemHeight";
            this.txtItemHeight.Size = new System.Drawing.Size(54, 20);
            this.txtItemHeight.TabIndex = 24;
            // 
            // txtItemWidth
            // 
            this.txtItemWidth.Location = new System.Drawing.Point(214, 34);
            this.txtItemWidth.Name = "txtItemWidth";
            this.txtItemWidth.Size = new System.Drawing.Size(54, 20);
            this.txtItemWidth.TabIndex = 23;
            // 
            // txtItemLength
            // 
            this.txtItemLength.Location = new System.Drawing.Point(95, 34);
            this.txtItemLength.Name = "txtItemLength";
            this.txtItemLength.Size = new System.Drawing.Size(54, 20);
            this.txtItemLength.TabIndex = 22;
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Location = new System.Drawing.Point(162, 79);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblItemQuantity.TabIndex = 21;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // lblItemWeight
            // 
            this.lblItemWeight.AutoSize = true;
            this.lblItemWeight.Location = new System.Drawing.Point(45, 79);
            this.lblItemWeight.Name = "lblItemWeight";
            this.lblItemWeight.Size = new System.Drawing.Size(41, 13);
            this.lblItemWeight.TabIndex = 20;
            this.lblItemWeight.Text = "Weight";
            // 
            // lblItemHeight
            // 
            this.lblItemHeight.AutoSize = true;
            this.lblItemHeight.Location = new System.Drawing.Point(305, 37);
            this.lblItemHeight.Name = "lblItemHeight";
            this.lblItemHeight.Size = new System.Drawing.Size(38, 13);
            this.lblItemHeight.TabIndex = 19;
            this.lblItemHeight.Text = "Height";
            // 
            // lblItemWidth
            // 
            this.lblItemWidth.AutoSize = true;
            this.lblItemWidth.Location = new System.Drawing.Point(173, 37);
            this.lblItemWidth.Name = "lblItemWidth";
            this.lblItemWidth.Size = new System.Drawing.Size(35, 13);
            this.lblItemWidth.TabIndex = 18;
            this.lblItemWidth.Text = "Width";
            // 
            // lblItemLength
            // 
            this.lblItemLength.AutoSize = true;
            this.lblItemLength.Location = new System.Drawing.Point(46, 37);
            this.lblItemLength.Name = "lblItemLength";
            this.lblItemLength.Size = new System.Drawing.Size(40, 13);
            this.lblItemLength.TabIndex = 17;
            this.lblItemLength.Text = "Length";
            // 
            // grpbxItemLocation
            // 
            this.grpbxItemLocation.Controls.Add(this.cmbItemBin);
            this.grpbxItemLocation.Controls.Add(this.cmbItemShelf);
            this.grpbxItemLocation.Controls.Add(this.cmbItemAisle);
            this.grpbxItemLocation.Controls.Add(this.btnItemLocation);
            this.grpbxItemLocation.Controls.Add(this.lblItemBin);
            this.grpbxItemLocation.Controls.Add(this.lblItemShelf);
            this.grpbxItemLocation.Controls.Add(this.lblItemAisle);
            this.grpbxItemLocation.Location = new System.Drawing.Point(12, 389);
            this.grpbxItemLocation.Name = "grpbxItemLocation";
            this.grpbxItemLocation.Size = new System.Drawing.Size(687, 73);
            this.grpbxItemLocation.TabIndex = 16;
            this.grpbxItemLocation.TabStop = false;
            this.grpbxItemLocation.Text = "Location";
            // 
            // cmbItemBin
            // 
            this.cmbItemBin.FormattingEnabled = true;
            this.cmbItemBin.Location = new System.Drawing.Point(474, 34);
            this.cmbItemBin.Name = "cmbItemBin";
            this.cmbItemBin.Size = new System.Drawing.Size(55, 21);
            this.cmbItemBin.TabIndex = 37;
            // 
            // cmbItemShelf
            // 
            this.cmbItemShelf.FormattingEnabled = true;
            this.cmbItemShelf.Location = new System.Drawing.Point(372, 34);
            this.cmbItemShelf.Name = "cmbItemShelf";
            this.cmbItemShelf.Size = new System.Drawing.Size(55, 21);
            this.cmbItemShelf.TabIndex = 36;
            // 
            // cmbItemAisle
            // 
            this.cmbItemAisle.FormattingEnabled = true;
            this.cmbItemAisle.Location = new System.Drawing.Point(269, 34);
            this.cmbItemAisle.Name = "cmbItemAisle";
            this.cmbItemAisle.Size = new System.Drawing.Size(55, 21);
            this.cmbItemAisle.TabIndex = 35;
            // 
            // btnItemLocation
            // 
            this.btnItemLocation.Location = new System.Drawing.Point(29, 32);
            this.btnItemLocation.Name = "btnItemLocation";
            this.btnItemLocation.Size = new System.Drawing.Size(153, 23);
            this.btnItemLocation.TabIndex = 26;
            this.btnItemLocation.Text = "Generate Available Location";
            this.btnItemLocation.UseVisualStyleBackColor = true;
            // 
            // lblItemBin
            // 
            this.lblItemBin.AutoSize = true;
            this.lblItemBin.Location = new System.Drawing.Point(446, 37);
            this.lblItemBin.Name = "lblItemBin";
            this.lblItemBin.Size = new System.Drawing.Size(22, 13);
            this.lblItemBin.TabIndex = 2;
            this.lblItemBin.Text = "Bin";
            // 
            // lblItemShelf
            // 
            this.lblItemShelf.AutoSize = true;
            this.lblItemShelf.Location = new System.Drawing.Point(335, 37);
            this.lblItemShelf.Name = "lblItemShelf";
            this.lblItemShelf.Size = new System.Drawing.Size(31, 13);
            this.lblItemShelf.TabIndex = 1;
            this.lblItemShelf.Text = "Shelf";
            // 
            // lblItemAisle
            // 
            this.lblItemAisle.AutoSize = true;
            this.lblItemAisle.Location = new System.Drawing.Point(234, 37);
            this.lblItemAisle.Name = "lblItemAisle";
            this.lblItemAisle.Size = new System.Drawing.Size(29, 13);
            this.lblItemAisle.TabIndex = 0;
            this.lblItemAisle.Text = "Aisle";
            // 
            // btnItemAddSave
            // 
            this.btnItemAddSave.Location = new System.Drawing.Point(624, 479);
            this.btnItemAddSave.Name = "btnItemAddSave";
            this.btnItemAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnItemAddSave.TabIndex = 17;
            this.btnItemAddSave.Text = "Add Item";
            this.btnItemAddSave.UseVisualStyleBackColor = true;
            this.btnItemAddSave.Click += new System.EventHandler(this.btnItemAddSave_Click);
            // 
            // btnItemResetCancel
            // 
            this.btnItemResetCancel.Location = new System.Drawing.Point(527, 479);
            this.btnItemResetCancel.Name = "btnItemResetCancel";
            this.btnItemResetCancel.Size = new System.Drawing.Size(75, 23);
            this.btnItemResetCancel.TabIndex = 18;
            this.btnItemResetCancel.Text = "Reset";
            this.btnItemResetCancel.UseVisualStyleBackColor = true;
            this.btnItemResetCancel.Click += new System.EventHandler(this.btnItemReset_Click);
            // 
            // AddEditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 518);
            this.Controls.Add(this.btnItemResetCancel);
            this.Controls.Add(this.btnItemAddSave);
            this.Controls.Add(this.grpbxItemLocation);
            this.Controls.Add(this.grpItemProperties);
            this.Controls.Add(this.grpbxAddItem);
            this.Name = "AddEditInventory";
            this.Text = "Item";
            this.grpbxAddItem.ResumeLayout(false);
            this.grpbxAddItem.PerformLayout();
            this.grpItemProperties.ResumeLayout(false);
            this.grpItemProperties.PerformLayout();
            this.grpbxItemLocation.ResumeLayout(false);
            this.grpbxItemLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxAddItem;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblAddCustomerLName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.GroupBox grpItemProperties;
        private System.Windows.Forms.Label lblItemLength;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.TextBox txtItemWeight;
        private System.Windows.Forms.TextBox txtItemHeight;
        private System.Windows.Forms.TextBox txtItemWidth;
        private System.Windows.Forms.TextBox txtItemLength;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblItemWeight;
        private System.Windows.Forms.Label lblItemHeight;
        private System.Windows.Forms.Label lblItemWidth;
        private System.Windows.Forms.Label lblExpirationDateQuestion;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker datetimeItemExpiration;
        private System.Windows.Forms.GroupBox grpbxItemLocation;
        private System.Windows.Forms.Label lblItemBin;
        private System.Windows.Forms.Label lblItemShelf;
        private System.Windows.Forms.Label lblItemAisle;
        private System.Windows.Forms.Button btnItemLocation;
        private System.Windows.Forms.Button btnItemAddSave;
        private System.Windows.Forms.Button btnItemResetCancel;
        private System.Windows.Forms.RadioButton rdoExpirationNo;
        private System.Windows.Forms.RadioButton rdoExpirationYes;
        private System.Windows.Forms.ComboBox cmbUnitofMeasurement;
        private System.Windows.Forms.ComboBox cmbItemBin;
        private System.Windows.Forms.ComboBox cmbItemShelf;
        private System.Windows.Forms.ComboBox cmbItemAisle;
        private System.Windows.Forms.ComboBox cmbItemCustomer;
        private System.Windows.Forms.Label lblItemCustomer;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.Label lblItemCategory;
    }
}