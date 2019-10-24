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
            this.minButton = new Capstone_Project_598.ButtonZ();
            this.closeButton = new Capstone_Project_598.ButtonZ();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.logonLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Capstone_Project_598.TextBox2();
            this.passwordTextBox = new Capstone_Project_598.TextBox2();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxPassLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
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
            this.TopPanel.Location = new System.Drawing.Point(207, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(153, 50);
            this.TopPanel.TabIndex = 7;
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
            this.minButton.Location = new System.Drawing.Point(93, 3);
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
            this.closeButton.Location = new System.Drawing.Point(119, 4);
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
            this.leftTopPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.leftTopPanel.Controls.Add(this.logonLabel);
            this.leftTopPanel.Location = new System.Drawing.Point(0, 2);
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
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(146, 92);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(145, 26);
            this.usernameTextBox.TabIndex = 16;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(146, 141);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(145, 26);
            this.passwordTextBox.TabIndex = 17;
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUserLabel.Location = new System.Drawing.Point(21, 95);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(106, 20);
            this.uxUserLabel.TabIndex = 18;
            this.uxUserLabel.Text = "Username : ";
            // 
            // uxPassLabel
            // 
            this.uxPassLabel.AutoSize = true;
            this.uxPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassLabel.Location = new System.Drawing.Point(21, 144);
            this.uxPassLabel.Name = "uxPassLabel";
            this.uxPassLabel.Size = new System.Drawing.Size(101, 20);
            this.uxPassLabel.TabIndex = 19;
            this.uxPassLabel.Text = "Password : ";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(237, 197);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(100, 36);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 254);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.uxPassLabel);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.leftTopPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogonForm";
            this.Text = "Form2";
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
        private System.Windows.Forms.Label logonLabel;
        private TextBox2 usernameTextBox;
        private TextBox2 passwordTextBox;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.Label uxPassLabel;
        private System.Windows.Forms.Button continueButton;
    }
}