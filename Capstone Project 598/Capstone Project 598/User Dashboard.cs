/*********************************************
* property of carson funk
* author : carson funk
* three level password authentication system (3LPAS)
* user interface class - main form
*********************************************/
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
    public partial class UserInterface : Form
    {
        private AddUserForm form1 = null;
        private LogonForm form2 = null;

        bool isTopPanelDragged = false;
        private Point offset;

        public UserInterface()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddUserForm>().Count() == 0)
            {
                form1 = new AddUserForm(this);
                form1.Show();
            }
            else if (Application.OpenForms.OfType<AddUserForm>().Count() == 1)
                Application.OpenForms.OfType<AddUserForm>().First().BringToFront();
            else //if (Application.OpenForms.OfType<AddUserForm>().Count() > 1)
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm.GetType() == form1.GetType())
                        frm.Close();
                }
                form1 = new AddUserForm(this);
                form1.Show();
            }
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LogonForm>().Count() == 0)
            {
                form2 = new LogonForm(this);
                form2.Show();
            }
            else if (Application.OpenForms.OfType<LogonForm>().Count() == 1)
                Application.OpenForms.OfType<LogonForm>().First().BringToFront();
            else //if (Application.OpenForms.OfType<LogonForm>().Count() > 1)
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm.GetType() == form2.GetType())
                        frm.Close();
                }
                form2 = new LogonForm(this);
                form2.Show();
            }
        }
    }
}
