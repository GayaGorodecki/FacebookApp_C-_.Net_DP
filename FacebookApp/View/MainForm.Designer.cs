namespace FacebookApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            this.tabControlUpdateInfo = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.tabFindByLocation = new System.Windows.Forms.TabPage();
            this.buttonCropAndSaveImg = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.comboBoxLocationType = new System.Windows.Forms.ComboBox();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.panelPostsInfo = new System.Windows.Forms.Panel();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.timerSlideShow = new System.Windows.Forms.Timer(this.components);
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            this.tabControlUpdateInfo.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabFindByLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            this.tabPagePosts.SuspendLayout();
            this.panelPostsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(12, 25);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(124, 24);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(12, 77);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(86, 24);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // tabControlUpdateInfo
            // 
            this.tabControlUpdateInfo.Controls.Add(this.tabProfile);
            this.tabControlUpdateInfo.Controls.Add(this.tabFindByLocation);
            this.tabControlUpdateInfo.Controls.Add(this.tabPagePosts);
            this.tabControlUpdateInfo.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUpdateInfo.Location = new System.Drawing.Point(12, 36);
            this.tabControlUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlUpdateInfo.Name = "tabControlUpdateInfo";
            this.tabControlUpdateInfo.SelectedIndex = 0;
            this.tabControlUpdateInfo.Size = new System.Drawing.Size(856, 351);
            this.tabControlUpdateInfo.TabIndex = 0;
            this.tabControlUpdateInfo.Visible = false;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.labelLastName);
            this.tabProfile.Controls.Add(this.textBoxLastName);
            this.tabProfile.Controls.Add(this.buttonChangeInfo);
            this.tabProfile.Controls.Add(this.textBoxEmail);
            this.tabProfile.Controls.Add(this.labelEmail);
            this.tabProfile.Controls.Add(this.textBoxGender);
            this.tabProfile.Controls.Add(this.textBoxBirthday);
            this.tabProfile.Controls.Add(this.textBoxFirstName);
            this.tabProfile.Controls.Add(this.labelGender);
            this.tabProfile.Controls.Add(this.labelBirthday);
            this.tabProfile.Controls.Add(this.labelFirstName);
            this.tabProfile.Controls.Add(this.profilePictureBox);
            this.tabProfile.Location = new System.Drawing.Point(4, 33);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProfile.Size = new System.Drawing.Size(848, 314);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(281, 41);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 24);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(389, 38);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(150, 32);
            this.textBoxLastName.TabIndex = 13;
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonChangeInfo.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangeInfo.Location = new System.Drawing.Point(206, 232);
            this.buttonChangeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(161, 60);
            this.buttonChangeInfo.TabIndex = 11;
            this.buttonChangeInfo.Text = "Change Info";
            this.buttonChangeInfo.UseVisualStyleBackColor = false;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(125, 169);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(412, 32);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(16, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 24);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(387, 104);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(150, 32);
            this.textBoxGender.TabIndex = 6;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(125, 104);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(150, 32);
            this.textBoxBirthday.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(125, 38);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(150, 32);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(306, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(75, 24);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(16, 110);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(82, 24);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(16, 41);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(103, 24);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(566, 26);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(261, 268);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // tabFindByLocation
            // 
            this.tabFindByLocation.Controls.Add(this.buttonCropAndSaveImg);
            this.tabFindByLocation.Controls.Add(this.listBoxLocations);
            this.tabFindByLocation.Controls.Add(this.buttonPause);
            this.tabFindByLocation.Controls.Add(this.pictureBoxLocation);
            this.tabFindByLocation.Controls.Add(this.comboBoxLocationType);
            this.tabFindByLocation.Location = new System.Drawing.Point(4, 33);
            this.tabFindByLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFindByLocation.Name = "tabFindByLocation";
            this.tabFindByLocation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFindByLocation.Size = new System.Drawing.Size(848, 314);
            this.tabFindByLocation.TabIndex = 1;
            this.tabFindByLocation.Text = "Find Pictures By Location";
            this.tabFindByLocation.UseVisualStyleBackColor = true;
            // 
            // buttonCropAndSaveImg
            // 
            this.buttonCropAndSaveImg.Location = new System.Drawing.Point(645, 164);
            this.buttonCropAndSaveImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCropAndSaveImg.Name = "buttonCropAndSaveImg";
            this.buttonCropAndSaveImg.Size = new System.Drawing.Size(128, 66);
            this.buttonCropAndSaveImg.TabIndex = 4;
            this.buttonCropAndSaveImg.Text = "Crop and Save Image";
            this.buttonCropAndSaveImg.UseVisualStyleBackColor = true;
            this.buttonCropAndSaveImg.Click += new System.EventHandler(this.buttonCropAndSaveImg_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.ItemHeight = 24;
            this.listBoxLocations.Location = new System.Drawing.Point(25, 68);
            this.listBoxLocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(214, 220);
            this.listBoxLocations.TabIndex = 3;
            this.listBoxLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxLocations_SelectedIndexChanged);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(645, 68);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(128, 51);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLocation.Location = new System.Drawing.Point(274, 25);
            this.pictureBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(332, 263);
            this.pictureBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocation.TabIndex = 1;
            this.pictureBoxLocation.TabStop = false;
            // 
            // comboBoxLocationType
            // 
            this.comboBoxLocationType.FormattingEnabled = true;
            this.comboBoxLocationType.Items.AddRange(new object[] {
            "Country",
            "City",
            "Street"});
            this.comboBoxLocationType.Location = new System.Drawing.Point(25, 25);
            this.comboBoxLocationType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLocationType.Name = "comboBoxLocationType";
            this.comboBoxLocationType.Size = new System.Drawing.Size(214, 32);
            this.comboBoxLocationType.TabIndex = 0;
            this.comboBoxLocationType.Text = "Choose Location Type";
            this.comboBoxLocationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.panelPostsInfo);
            this.tabPagePosts.Controls.Add(this.buttonFetchPosts);
            this.tabPagePosts.Controls.Add(this.listBoxPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 33);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Size = new System.Drawing.Size(848, 314);
            this.tabPagePosts.TabIndex = 2;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // panelPostsInfo
            // 
            this.panelPostsInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPostsInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPostsInfo.Controls.Add(this.descriptionRichTextBox);
            this.panelPostsInfo.Controls.Add(createdTimeLabel);
            this.panelPostsInfo.Controls.Add(this.createdTimeDateTimePicker);
            this.panelPostsInfo.Controls.Add(messageLabel);
            this.panelPostsInfo.Controls.Add(this.messageTextBox);
            this.panelPostsInfo.Location = new System.Drawing.Point(366, 58);
            this.panelPostsInfo.Name = "panelPostsInfo";
            this.panelPostsInfo.Size = new System.Drawing.Size(470, 244);
            this.panelPostsInfo.TabIndex = 2;
            this.panelPostsInfo.Visible = false;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No Description]"));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(16, 124);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(429, 96);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(147, 21);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(298, 32);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No Message]"));
            this.messageTextBox.Location = new System.Drawing.Point(147, 74);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(298, 32);
            this.messageTextBox.TabIndex = 5;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(18, 13);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(179, 36);
            this.buttonFetchPosts.TabIndex = 1;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Name";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(18, 58);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(324, 244);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonLogout.Location = new System.Drawing.Point(736, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(116, 49);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.labelStart);
            this.flowLayoutPanel.Controls.Add(this.buttonLogin);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(206, 28);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(489, 352);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelStart.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStart.Location = new System.Drawing.Point(1, 0);
            this.labelStart.Margin = new System.Windows.Forms.Padding(0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(489, 290);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Welcome! Please Login...";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonLogin.Location = new System.Drawing.Point(3, 292);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(486, 55);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // timerSlideShow
            // 
            this.timerSlideShow.Interval = 2000;
            this.timerSlideShow.Tick += new System.EventHandler(this.timerSlideShow_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 416);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControlUpdateInfo);
            this.Controls.Add(this.flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - Login";
            this.tabControlUpdateInfo.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabFindByLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            this.tabPagePosts.ResumeLayout(false);
            this.panelPostsInfo.ResumeLayout(false);
            this.panelPostsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUpdateInfo;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabFindByLocation;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ComboBox comboBoxLocationType;
        private System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.Timer timerSlideShow;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.Button buttonCropAndSaveImg;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.Panel panelPostsInfo;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
    }
}

