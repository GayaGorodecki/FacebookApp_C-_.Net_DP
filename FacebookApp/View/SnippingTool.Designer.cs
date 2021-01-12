namespace FacebookApp
{
    partial class SnippingTool
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
            this.picFromFacebook = new System.Windows.Forms.PictureBox();
            this.picTargetImg = new System.Windows.Forms.PictureBox();
            this.buttonSaveToPC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFromFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTargetImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picFromFacebook
            // 
            this.picFromFacebook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFromFacebook.Location = new System.Drawing.Point(23, 23);
            this.picFromFacebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFromFacebook.Name = "picFromFacebook";
            this.picFromFacebook.Size = new System.Drawing.Size(302, 271);
            this.picFromFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFromFacebook.TabIndex = 0;
            this.picFromFacebook.TabStop = false;
            this.picFromFacebook.Click += new System.EventHandler(this.picFromFacebook_Click);
            this.picFromFacebook.Paint += new System.Windows.Forms.PaintEventHandler(this.picFromFacebook_Paint);
            this.picFromFacebook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFromFacebook_MouseDown);
            this.picFromFacebook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFromFacebook_MouseMove);
            this.picFromFacebook.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFromFacebook_MouseUp);
            // 
            // picTargetImg
            // 
            this.picTargetImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTargetImg.Location = new System.Drawing.Point(366, 23);
            this.picTargetImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTargetImg.Name = "picTargetImg";
            this.picTargetImg.Size = new System.Drawing.Size(242, 212);
            this.picTargetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTargetImg.TabIndex = 1;
            this.picTargetImg.TabStop = false;
            // 
            // buttonSaveToPC
            // 
            this.buttonSaveToPC.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSaveToPC.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToPC.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSaveToPC.Location = new System.Drawing.Point(394, 247);
            this.buttonSaveToPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveToPC.Name = "buttonSaveToPC";
            this.buttonSaveToPC.Size = new System.Drawing.Size(189, 46);
            this.buttonSaveToPC.TabIndex = 2;
            this.buttonSaveToPC.Text = "Save to PC";
            this.buttonSaveToPC.UseVisualStyleBackColor = false;
            this.buttonSaveToPC.Click += new System.EventHandler(this.buttonSaveToPC_Click);
            // 
            // SnippingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 322);
            this.Controls.Add(this.buttonSaveToPC);
            this.Controls.Add(this.picTargetImg);
            this.Controls.Add(this.picFromFacebook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SnippingTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snipping Tool";
            ((System.ComponentModel.ISupportInitialize)(this.picFromFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTargetImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFromFacebook;
        private System.Windows.Forms.PictureBox picTargetImg;
        private System.Windows.Forms.Button buttonSaveToPC;
    }
}