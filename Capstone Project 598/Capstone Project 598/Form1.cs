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
    public partial class AddUserForm : Form
    {
        private UserInterface ownerForm = null;
        private List<string> UsernameDictionary = new List<string>();
        //private int State;

        private string Username;
        private string Password;

        bool isTopPanelDragged = false;
        private Point offset;

        public AddUserForm(UserInterface ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            charactersXLabel.Visible = true;    specCharsLabel.Visible = false;
            chooseUsernameButton.Enabled = false;
            submitPictureButton.Enabled = false;
            //State = 0;

            UsernameDictionary.Add("cmfunk"); UsernameDictionary.Add("root");
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

        private void ChooseUsernameButton_Click(object sender, EventArgs e)
        {
            string g = usernameTextBox.Text.Trim();
            bool unique = true;

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (g.Length > 5/* && !regexItem.IsMatch(g)*/)
            {
                foreach(string tmp in UsernameDictionary)
                {
                    if (g == tmp)
                        unique = false;
                }
                if (!unique)
                {
                    MessageBox.Show("Sorry, that username is already taken. :/ \n Please try again.");
                    usernameTextBox.Text = "";
                }
                else //if (unique)
                {
                    MessageBox.Show("### Username is available ###");//create user in SQL Database 
                    Username = g;
                    //State = 1;
                    usernameTextBox.Visible = false;
                    chooseUsernameButton.Visible = false;
                    specCharsLabel.Visible = true;
                    charactersXLabel.Visible = true;

                    choosePasswordButton.Enabled = false;
                    bigTextLabel.Text = "2) Please choose a password";
                }
            }
            else
            {
                MessageBox.Show("Please enter a Password longer than 6 characters. (Spaces omitted)");
            }
        }

        private void TextBox21_TextChangedDelayed(object sender, EventArgs e)
        {//            USERNAME TEXTBOX
            string g = usernameTextBox.Text;      string ifneeded = "";
            //charactersXLabel.Visible = g.Trim().Length > 5 ? false : true;
            /*if (g.Trim().Length > 5)
                chooseUsernameButton.Enabled = true;*/

            if (g.Contains(" "))
            {
                ifneeded = g.Replace(" ", "");
                usernameTextBox.Text = "";
                usernameTextBox.Text += ifneeded;
            }

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            string tt = usernameTextBox.Text.Trim();
            if (tt.Length < 1)
                chooseUsernameButton.Enabled = false;

            chooseUsernameButton.Enabled = tt.Length < 6 ? false : true;
            charactersXLabel.Visible = tt.Length < 6 ? true : false;
            
        }

        private void ChoosePasswordButton_Click(object sender, EventArgs e)
        {
            string ree = passwordTextBox.Text.Trim();
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (ree.Length > 5 && !regexItem.IsMatch(ree))
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(ree);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);

                Password = ree;
                MessageBox.Show("## Password is set! ##");

                bigTextLabel.Text = "3) Please upload a picture";
                choosePasswordButton.Visible = false;
                passwordTextBox.Visible = false;
                label5.Visible = false;         //"spaces will be omitted"
            }




        }

        private void PasswordTextBox_TextChangedDelayed(object sender, EventArgs e)
        {
            string ttt = passwordTextBox.Text.Trim();



            /*if (ttt.Length > 5 && !regexItem.IsMatch(ttt))
                choosePasswordButton.Enabled = true;*/

            /*charactersXLabel.Visible = ttt.Length > 5 ? false : true;
            specCharsLabel.Visible = regexItem.IsMatch(ttt) ? true : false;*/
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string tt = passwordTextBox.Text.Trim();
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            choosePasswordButton.Enabled = tt.Length < 6 ? false : true;
            charactersXLabel.Enabled = tt.Length < 6 ? true : false;

            specCharsLabel.Visible = regexItem.IsMatch(tt) ? true : false;
            

        }
    }
}
