namespace WarehouseSystem
{
    partial class WarehouseSystem
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
            this.loginScreen = new System.Windows.Forms.Panel();
            this.passInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signBtn = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginScreen.Controls.Add(this.passInput);
            this.loginScreen.Controls.Add(this.loginInput);
            this.loginScreen.Controls.Add(this.passwordLabel);
            this.loginScreen.Controls.Add(this.signBtn);
            this.loginScreen.Controls.Add(this.loginLabel);
            this.loginScreen.Location = new System.Drawing.Point(237, 154);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(361, 255);
            this.loginScreen.TabIndex = 7;
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passInput.Location = new System.Drawing.Point(114, 100);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(144, 23);
            this.passInput.TabIndex = 8;
            // 
            // loginInput
            // 
            this.loginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(114, 58);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(144, 23);
            this.loginInput.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(13, 100);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // signBtn
            // 
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signBtn.Location = new System.Drawing.Point(92, 182);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(166, 39);
            this.signBtn.TabIndex = 4;
            this.signBtn.Text = "Sign in";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(43, 58);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 20);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login:";
            // 
            // WarehouseSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.loginScreen);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "WarehouseSystem";
            this.Text = "WarehouseSystem";
            this.Load += new System.EventHandler(this.WarehouseSystem_Load);
            this.SizeChanged += new System.EventHandler(this.WarehouseSystem_SizeChanged);
            this.loginScreen.ResumeLayout(false);
            this.loginScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label loginLabel;
    }
}

