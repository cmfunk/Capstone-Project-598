namespace Capstone_Project_598
{
    partial class LogonForm
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
            this.logonLabel = new System.Windows.Forms.Label();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxPassLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bigTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.imageSubmitButton = new System.Windows.Forms.Button();
            this.submitPatternButton = new System.Windows.Forms.Button();
            this.patternLa = new System.Windows.Forms.Label();
            this.greenButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.maxPatternLabel = new System.Windows.Forms.Label();
            this.minPatternLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Capstone_Project_598.TextBox2();
            this.usernameTextBox = new Capstone_Project_598.TextBox2();
            this.minButton = new Capstone_Project_598.ButtonZ();
            this.closeButton = new Capstone_Project_598.ButtonZ();
            this.TopPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TopPanel.Controls.Add(this.minButton);
            this.TopPanel.Controls.Add(this.closeButton);
            this.TopPanel.Location = new System.Drawing.Point(207, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(207, 50);
            this.TopPanel.TabIndex = 7;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.leftTopPanel.Controls.Add(this.logonLabel);
            this.leftTopPanel.Location = new System.Drawing.Point(0, 0);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(208, 50);
            this.leftTopPanel.TabIndex = 8;
            this.leftTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.leftTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.leftTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // logonLabel
            // 
            this.logonLabel.AutoSize = true;
            this.logonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.logonLabel.Location = new System.Drawing.Point(27, 12);
            this.logonLabel.Name = "logonLabel";
            this.logonLabel.Size = new System.Drawing.Size(69, 24);
            this.logonLabel.TabIndex = 0;
            this.logonLabel.Text = "Logon";
            this.logonLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.logonLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.logonLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUserLabel.Location = new System.Drawing.Point(21, 104);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(106, 20);
            this.uxUserLabel.TabIndex = 18;
            this.uxUserLabel.Text = "Username : ";
            // 
            // uxPassLabel
            // 
            this.uxPassLabel.AutoSize = true;
            this.uxPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassLabel.Location = new System.Drawing.Point(21, 153);
            this.uxPassLabel.Name = "uxPassLabel";
            this.uxPassLabel.Size = new System.Drawing.Size(101, 20);
            this.uxPassLabel.TabIndex = 19;
            this.uxPassLabel.Text = "Password : ";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(290, 256);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(100, 36);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "# Spaces will be omitted #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "** All 3 steps\r\nare required\r\nfor successful\r\nlogin process**";
            // 
            // bigTextLabel
            // 
            this.bigTextLabel.AutoSize = true;
            this.bigTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTextLabel.Location = new System.Drawing.Point(12, 63);
            this.bigTextLabel.Name = "bigTextLabel";
            this.bigTextLabel.Size = new System.Drawing.Size(395, 24);
            this.bigTextLabel.TabIndex = 25;
            this.bigTextLabel.Text = "1) Please enter Username and Password.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(250, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(56, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(250, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(234, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(41, 268);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(234, 268);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // imageSubmitButton
            // 
            this.imageSubmitButton.Enabled = false;
            this.imageSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSubmitButton.Location = new System.Drawing.Point(365, 273);
            this.imageSubmitButton.Name = "imageSubmitButton";
            this.imageSubmitButton.Size = new System.Drawing.Size(39, 34);
            this.imageSubmitButton.TabIndex = 39;
            this.imageSubmitButton.Text = "√";
            this.imageSubmitButton.UseVisualStyleBackColor = true;
            this.imageSubmitButton.Visible = false;
            this.imageSubmitButton.Click += new System.EventHandler(this.ImageSubmitButton_Click);
            // 
            // submitPatternButton
            // 
            this.submitPatternButton.Enabled = false;
            this.submitPatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPatternButton.Location = new System.Drawing.Point(298, 259);
            this.submitPatternButton.Name = "submitPatternButton";
            this.submitPatternButton.Size = new System.Drawing.Size(103, 33);
            this.submitPatternButton.TabIndex = 40;
            this.submitPatternButton.Text = "Continue";
            this.submitPatternButton.UseVisualStyleBackColor = true;
            this.submitPatternButton.Visible = false;
            this.submitPatternButton.Click += new System.EventHandler(this.SubmitPatternButton_Click);
            // 
            // patternLa
            // 
            this.patternLa.AutoSize = true;
            this.patternLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLa.Location = new System.Drawing.Point(22, 256);
            this.patternLa.Name = "patternLa";
            this.patternLa.Size = new System.Drawing.Size(0, 20);
            this.patternLa.TabIndex = 41;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(177, 123);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(50, 36);
            this.greenButton.TabIndex = 42;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Visible = false;
            this.greenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Fuchsia;
            this.purpleButton.Location = new System.Drawing.Point(223, 180);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(50, 36);
            this.purpleButton.TabIndex = 43;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Visible = false;
            this.purpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(272, 123);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(50, 36);
            this.blueButton.TabIndex = 44;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Visible = false;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(77, 123);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(50, 36);
            this.redButton.TabIndex = 45;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Visible = false;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(122, 180);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(50, 36);
            this.yellowButton.TabIndex = 46;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Visible = false;
            this.yellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // maxPatternLabel
            // 
            this.maxPatternLabel.AutoSize = true;
            this.maxPatternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPatternLabel.Location = new System.Drawing.Point(284, 226);
            this.maxPatternLabel.Name = "maxPatternLabel";
            this.maxPatternLabel.Size = new System.Drawing.Size(117, 13);
            this.maxPatternLabel.TabIndex = 47;
            this.maxPatternLabel.Text = "# max: 16 characters #";
            this.maxPatternLabel.Visible = false;
            // 
            // minPatternLabel
            // 
            this.minPatternLabel.AutoSize = true;
            this.minPatternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPatternLabel.Location = new System.Drawing.Point(288, 210);
            this.minPatternLabel.Name = "minPatternLabel";
            this.minPatternLabel.Size = new System.Drawing.Size(108, 13);
            this.minPatternLabel.TabIndex = 48;
            this.minPatternLabel.Text = "# min: 8 characters #";
            this.minPatternLabel.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(146, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(145, 26);
            this.passwordTextBox.TabIndex = 17;
            this.passwordTextBox.TextChangedDelayed += new System.EventHandler(this.PasswordTextBox_TextChangedDelayed);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(146, 101);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(145, 26);
            this.usernameTextBox.TabIndex = 16;
            this.usernameTextBox.TextChangedDelayed += new System.EventHandler(this.UsernameTextBox_TextChangedDelayed);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // minButton
            // 
            this.minButton.BZBackColor = System.Drawing.Color.White;
            this.minButton.DisplayText = "_";
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.Black;
            this.minButton.Location = new System.Drawing.Point(144, 3);
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
            this.closeButton.Location = new System.Drawing.Point(173, 4);
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
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 319);
            this.Controls.Add(this.minPatternLabel);
            this.Controls.Add(this.maxPatternLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.patternLa);
            this.Controls.Add(this.submitPatternButton);
            this.Controls.Add(this.imageSubmitButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bigTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.leftTopPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.uxPassLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogonForm";
            this.Text = "Form2";
            this.TopPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.leftTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private ButtonZ minButton;
        private ButtonZ closeButton;
        private System.Windows.Forms.Panel leftTopPanel;
        private System.Windows.Forms.Label logonLabel;
        private TextBox2 usernameTextBox;
        private TextBox2 passwordTextBox;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.Label uxPassLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bigTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button imageSubmitButton;
        private System.Windows.Forms.Button submitPatternButton;
        private System.Windows.Forms.Label patternLa;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Label maxPatternLabel;
        private System.Windows.Forms.Label minPatternLabel;
    }
}