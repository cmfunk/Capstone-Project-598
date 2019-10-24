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
            this.minButton = new Capstone_Project_598.ButtonZ();
            this.closeButton = new Capstone_Project_598.ButtonZ();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bigTextLabel = new System.Windows.Forms.Label();
            this.chooseUsernameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.charactersXLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new Capstone_Project_598.TextBox2();
            this.specCharsLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Capstone_Project_598.TextBox2();
            this.choosePasswordButton = new System.Windows.Forms.Button();
            this.submitPictureButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
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
            this.charactersXLabel.Text = "## Min. 6 Characters ##";
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
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(23, 120);
            this.usernameTextBox.MaxLength = 20;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(158, 26);
            this.usernameTextBox.TabIndex = 15;
            this.usernameTextBox.TextChangedDelayed += new System.EventHandler(this.TextBox21_TextChangedDelayed);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
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
            this.submitPictureButton.Location = new System.Drawing.Point(200, 189);
            this.submitPictureButton.Name = "submitPictureButton";
            this.submitPictureButton.Size = new System.Drawing.Size(103, 33);
            this.submitPictureButton.TabIndex = 19;
            this.submitPictureButton.Text = "Continue";
            this.submitPictureButton.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.specCharsLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.charactersXLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseUsernameButton);
            this.Controls.Add(this.bigTextLabel);
            this.Controls.Add(this.leftTopPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.choosePasswordButton);
            this.Controls.Add(this.submitPictureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.leftTopPanel.PerformLayout();
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
    }
}