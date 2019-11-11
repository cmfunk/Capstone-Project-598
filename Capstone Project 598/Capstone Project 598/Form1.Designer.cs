namespace Capstone_Project_598
{
    partial class AddUserForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bigTextLabel = new System.Windows.Forms.Label();
            this.chooseUsernameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.charactersXLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.specCharsLabel = new System.Windows.Forms.Label();
            this.choosePasswordButton = new System.Windows.Forms.Button();
            this.submitPictureButton = new System.Windows.Forms.Button();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.submitPatternButton = new System.Windows.Forms.Button();
            this.patternLa = new System.Windows.Forms.Label();
            this.minPatternLabel = new System.Windows.Forms.Label();
            this.maxPatternLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Capstone_Project_598.TextBox2();
            this.minButton = new Capstone_Project_598.ButtonZ();
            this.closeButton = new Capstone_Project_598.ButtonZ();
            this.passwordTextBox = new Capstone_Project_598.TextBox2();
            this.TopPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TopPanel.Controls.Add(this.minButton);
            this.TopPanel.Controls.Add(this.closeButton);
            this.TopPanel.Location = new System.Drawing.Point(174, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(185, 50);
            this.TopPanel.TabIndex = 6;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.leftTopPanel.Controls.Add(this.label2);
            this.leftTopPanel.Location = new System.Drawing.Point(-1, 0);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(175, 50);
            this.leftTopPanel.TabIndex = 7;
            this.leftTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.leftTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.leftTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "New User";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // bigTextLabel
            // 
            this.bigTextLabel.AutoSize = true;
            this.bigTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTextLabel.Location = new System.Drawing.Point(12, 57);
            this.bigTextLabel.Name = "bigTextLabel";
            this.bigTextLabel.Size = new System.Drawing.Size(288, 24);
            this.bigTextLabel.TabIndex = 8;
            this.bigTextLabel.Text = "1) Please choose a username";
            // 
            // chooseUsernameButton
            // 
            this.chooseUsernameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameButton.Location = new System.Drawing.Point(200, 189);
            this.chooseUsernameButton.Name = "chooseUsernameButton";
            this.chooseUsernameButton.Size = new System.Drawing.Size(103, 33);
            this.chooseUsernameButton.TabIndex = 10;
            this.chooseUsernameButton.Text = "Continue";
            this.chooseUsernameButton.UseVisualStyleBackColor = true;
            this.chooseUsernameButton.Click += new System.EventHandler(this.ChooseUsernameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "* User will not \r\nbe created until \r\nall 4 steps are\r\ncompleted *";
            // 
            // charactersXLabel
            // 
            this.charactersXLabel.AutoSize = true;
            this.charactersXLabel.Location = new System.Drawing.Point(213, 115);
            this.charactersXLabel.Name = "charactersXLabel";
            this.charactersXLabel.Size = new System.Drawing.Size(124, 13);
            this.charactersXLabel.TabIndex = 12;
            this.charactersXLabel.Text = "## Min. 8 Characters ##";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "# Spaces will be Omitted #";
            // 
            // specCharsLabel
            // 
            this.specCharsLabel.AutoSize = true;
            this.specCharsLabel.Location = new System.Drawing.Point(209, 98);
            this.specCharsLabel.Name = "specCharsLabel";
            this.specCharsLabel.Size = new System.Drawing.Size(134, 13);
            this.specCharsLabel.TabIndex = 16;
            this.specCharsLabel.Text = "## 1 Special Character ##";
            // 
            // choosePasswordButton
            // 
            this.choosePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePasswordButton.Location = new System.Drawing.Point(200, 189);
            this.choosePasswordButton.Name = "choosePasswordButton";
            this.choosePasswordButton.Size = new System.Drawing.Size(103, 33);
            this.choosePasswordButton.TabIndex = 18;
            this.choosePasswordButton.Text = "Continue";
            this.choosePasswordButton.UseVisualStyleBackColor = true;
            this.choosePasswordButton.Click += new System.EventHandler(this.ChoosePasswordButton_Click);
            // 
            // submitPictureButton
            // 
            this.submitPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPictureButton.Location = new System.Drawing.Point(47, 189);
            this.submitPictureButton.Name = "submitPictureButton";
            this.submitPictureButton.Size = new System.Drawing.Size(103, 33);
            this.submitPictureButton.TabIndex = 19;
            this.submitPictureButton.Text = "Continue";
            this.submitPictureButton.UseVisualStyleBackColor = true;
            this.submitPictureButton.Click += new System.EventHandler(this.SubmitPictureButton_Click);
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFileButton.Location = new System.Drawing.Point(37, 108);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(132, 50);
            this.uploadFileButton.TabIndex = 20;
            this.uploadFileButton.Text = "Upload Picture";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Visible = false;
            this.uploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 138);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(58, 90);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(50, 36);
            this.redButton.TabIndex = 22;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Visible = false;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(153, 90);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(50, 36);
            this.greenButton.TabIndex = 23;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Visible = false;
            this.greenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(239, 90);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(50, 36);
            this.blueButton.TabIndex = 24;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Visible = false;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(109, 133);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(50, 36);
            this.yellowButton.TabIndex = 25;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Visible = false;
            this.yellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Fuchsia;
            this.purpleButton.Location = new System.Drawing.Point(194, 131);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(50, 36);
            this.purpleButton.TabIndex = 26;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Visible = false;
            this.purpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // submitPatternButton
            // 
            this.submitPatternButton.Enabled = false;
            this.submitPatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPatternButton.Location = new System.Drawing.Point(234, 202);
            this.submitPatternButton.Name = "submitPatternButton";
            this.submitPatternButton.Size = new System.Drawing.Size(103, 33);
            this.submitPatternButton.TabIndex = 27;
            this.submitPatternButton.Text = "Continue";
            this.submitPatternButton.UseVisualStyleBackColor = true;
            this.submitPatternButton.Visible = false;
            this.submitPatternButton.Click += new System.EventHandler(this.SubmitPatternButton_Click);
            // 
            // patternLa
            // 
            this.patternLa.AutoSize = true;
            this.patternLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLa.Location = new System.Drawing.Point(13, 202);
            this.patternLa.Name = "patternLa";
            this.patternLa.Size = new System.Drawing.Size(0, 20);
            this.patternLa.TabIndex = 28;
            this.patternLa.Visible = false;
            // 
            // minPatternLabel
            // 
            this.minPatternLabel.AutoSize = true;
            this.minPatternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPatternLabel.Location = new System.Drawing.Point(231, 173);
            this.minPatternLabel.Name = "minPatternLabel";
            this.minPatternLabel.Size = new System.Drawing.Size(108, 13);
            this.minPatternLabel.TabIndex = 29;
            this.minPatternLabel.Text = "# min: 8 characters #";
            this.minPatternLabel.Visible = false;
            // 
            // maxPatternLabel
            // 
            this.maxPatternLabel.AutoSize = true;
            this.maxPatternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPatternLabel.Location = new System.Drawing.Point(230, 185);
            this.maxPatternLabel.Name = "maxPatternLabel";
            this.maxPatternLabel.Size = new System.Drawing.Size(117, 13);
            this.maxPatternLabel.TabIndex = 30;
            this.maxPatternLabel.Text = "# max: 16 characters #";
            this.maxPatternLabel.Visible = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(23, 120);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(158, 26);
            this.usernameTextBox.TabIndex = 15;
            this.usernameTextBox.TextChangedDelayed += new System.EventHandler(this.TextBox21_TextChangedDelayed);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // minButton
            // 
            this.minButton.BZBackColor = System.Drawing.Color.White;
            this.minButton.DisplayText = "_";
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.Black;
            this.minButton.Location = new System.Drawing.Point(125, 3);
            this.minButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.minButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(31, 24);
            this.minButton.TabIndex = 2;
            this.minButton.Text = "_";
            this.minButton.TextLocation_X = 6;
            this.minButton.TextLocation_Y = -18;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BZBackColor = System.Drawing.Color.White;
            this.closeButton.DisplayText = "X";
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(151, 4);
            this.closeButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 22);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextLocation_X = 5;
            this.closeButton.TextLocation_Y = -2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(23, 120);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(158, 26);
            this.passwordTextBox.TabIndex = 17;
            this.passwordTextBox.TextChangedDelayed += new System.EventHandler(this.PasswordTextBox_TextChangedDelayed);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.minPatternLabel);
            this.Controls.Add(this.patternLa);
            this.Controls.Add(this.submitPatternButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.uploadFileButton);
            this.Controls.Add(this.specCharsLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.charactersXLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigTextLabel);
            this.Controls.Add(this.leftTopPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.submitPictureButton);
            this.Controls.Add(this.chooseUsernameButton);
            this.Controls.Add(this.choosePasswordButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maxPatternLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.leftTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private ButtonZ minButton;
        private ButtonZ closeButton;
        private System.Windows.Forms.Panel leftTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bigTextLabel;
        private System.Windows.Forms.Button chooseUsernameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label charactersXLabel;
        private System.Windows.Forms.Label label5;
        private TextBox2 usernameTextBox;
        private System.Windows.Forms.Label specCharsLabel;
        private TextBox2 passwordTextBox;
        private System.Windows.Forms.Button choosePasswordButton;
        private System.Windows.Forms.Button submitPictureButton;
        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button submitPatternButton;
        private System.Windows.Forms.Label patternLa;
        private System.Windows.Forms.Label minPatternLabel;
        private System.Windows.Forms.Label maxPatternLabel;
    }
}