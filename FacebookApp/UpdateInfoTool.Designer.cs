namespace A21_Ex02_Gaya_206105371_Vladimir_317303071
{
    partial class UpdateInfoTool
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelUpdateYourInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(78, 172);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(216, 32);
            this.textBoxLastName.TabIndex = 23;
            this.textBoxLastName.Text = "Update Last Name";
            this.textBoxLastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxLastName_MouseDown);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(78, 285);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(315, 32);
            this.textBoxEmail.TabIndex = 22;
            this.textBoxEmail.Text = "Update Email";
            this.textBoxEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseDown);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(78, 111);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(216, 32);
            this.textBoxFirstName.TabIndex = 18;
            this.textBoxFirstName.Text = "Update First Name";
            this.textBoxFirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxFirstName_MouseDown);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(74, 234);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(146, 24);
            this.labelBirthday.TabIndex = 16;
            this.labelBirthday.Text = "Update Birthday:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpdate.Location = new System.Drawing.Point(141, 349);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(179, 65);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(226, 228);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(167, 32);
            this.dateTimePickerBirthday.TabIndex = 28;
            // 
            // labelUpdateYourInfo
            // 
            this.labelUpdateYourInfo.Font = new System.Drawing.Font("Calibri Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateYourInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelUpdateYourInfo.Location = new System.Drawing.Point(37, 21);
            this.labelUpdateYourInfo.Name = "labelUpdateYourInfo";
            this.labelUpdateYourInfo.Size = new System.Drawing.Size(395, 66);
            this.labelUpdateYourInfo.TabIndex = 29;
            this.labelUpdateYourInfo.Text = "Update Your Info";
            this.labelUpdateYourInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateInfoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 441);
            this.Controls.Add(this.labelUpdateYourInfo);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelBirthday);
            this.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateInfoTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Info Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelUpdateYourInfo;
    }
}