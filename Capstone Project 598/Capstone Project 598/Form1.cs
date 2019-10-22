using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project_598
{
    public partial class AddUserForm : Form
    {
        private UserInterface ownerForm = null;
        private List<string> UsernameDictionary = new List<string>();

        bool isTopPanelDragged = false;
        private Point offset;

        public AddUserForm(UserInterface ownerForm)
        {
            InitializeComponent();
            usernameXLabel.Visible = false;
            this.ownerForm = ownerForm;

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

            if (g.Length > 0)
            {
                foreach(string tmp in UsernameDictionary)
                {
                    if (g == tmp)
                        unique = false;
                }
                if (unique)
                    MessageBox.Show("### Username is available ###");//create user in SQL Database 
                if (!unique)
                    MessageBox.Show("Sorry, that username is already taken. :/");
            }
            else
                usernameXLabel.Visible = true;
            
        }
    }
}
