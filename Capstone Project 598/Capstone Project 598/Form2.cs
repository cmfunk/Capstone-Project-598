using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Capstone_Project_598
{
    public partial class LogonForm : Form
    {
        private UserInterface ownerForm = null;
        bool isTopPanelDragged = false;
        private Point offset;

        bool usernameLenBool = false;
        bool passwordLenBool = false;

        public LogonForm(UserInterface ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            continueButton.Enabled = false;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                offset = e.Location;
            }
            else
                isTopPanelDragged = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                int xDif = offset.X - e.Location.X;
                int yDif = offset.Y - e.Location.Y;

                this.Location = new Point(this.Location.X - xDif, this.Location.Y - yDif);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            string user = usernameTextBox.Text;     user = user.Trim();     string tempUser = user;
            if (user.Contains(" "))
                tempUser = user.Replace(" ", "");

            string pass = passwordTextBox.Text;     pass = pass.Trim();     string tempPass = pass;
            if (pass.Contains(" "))
                tempPass = pass.Replace(" ", "");
            
            if (tempUser.Length > 5 && tempPass.Length > 5 && !regexItem.IsMatch(tempPass))
            {
                   //get all username and check if in   //bool userBool = 

                    //sql connection
            }
            else
            {   MessageBox.Show("Error, username and password requirements NOT met.", "Sorry :/");  }


        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            string dee = usernameTextBox.Text;
            dee = dee.Trim();               string ifneeded22 = dee;
            //          var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            /*if (dee.Length > 5 && !regexItem.IsMatch(dee))
                usernameLenBool = true;*/
            if (dee.Contains(" "))
                ifneeded22 = dee.Replace(" ", "");

            usernameLenBool = ifneeded22.Length > 5 ? true : false;
            charsUsernameXLabel.Visible = ifneeded22.Length > 5 ? false : true;

            if (usernameLenBool && passwordLenBool)
                continueButton.Enabled = true;
            else
                continueButton.Enabled = false;
        }

        private void UsernameTextBox_TextChangedDelayed(object sender, EventArgs e)
        {
            string t = usernameTextBox.Text;     string temp = "";
            //var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (t.Contains(" "))
            {
                temp = t.Replace(" ", "");
                usernameTextBox.Text = "";
                usernameTextBox.Text += temp;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            string ee = passwordTextBox.Text;
            ee = ee.Trim();        string temppp = ee;

            if (ee.Contains(" "))
                temppp = ee.Replace(" ", "");

            charsPasswordXLabel.Visible = temppp.Length > 5 ? false : true;
            speccharPasswordXLabel.Visible = regexItem.IsMatch(ee) ? true : false;

            if (temppp.Length > 5 && !regexItem.IsMatch(ee))
            {
                continueButton.Enabled = true;
                passwordLenBool = true;
            }
            else
            {
                continueButton.Enabled = false;
                passwordLenBool = false;
            }

            if (usernameLenBool && passwordLenBool)
                continueButton.Enabled = true;
            else
                continueButton.Enabled = false;
        }

        private void PasswordTextBox_TextChangedDelayed(object sender, EventArgs e)
        {
            string p = passwordTextBox.Text;            string tmpp = "";
            //p = p.Trim();         

            if (p.Contains(" "))
            {
                tmpp = p.Replace(" ", "");
                passwordTextBox.Text = "";
                passwordTextBox.Text += tmpp;
            }
        }
    }
}
