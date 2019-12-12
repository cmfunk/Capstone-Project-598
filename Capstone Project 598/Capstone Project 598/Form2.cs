using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        List<PictureBox> pictureBoxes;
        List<CheckBox> checkBoxes;

        private string UserName;

        private Dictionary<int, Image> imageDictionary;

        bool usernameLenBool = false;
        bool passwordLenBool = false;

        public LogonForm(UserInterface ownerForm, Dictionary<int, Image> images)
        {
            InitializeComponent();
            imageDictionary = new Dictionary<int, Image>();
            imageDictionary = images;
            this.ownerForm = ownerForm;
            continueButton.Enabled = false;

            initLists();
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

            string comparePass;         string realImageHash;
            if (tempUser.Length > 5 && tempPass.Length > 5 && !regexItem.IsMatch(tempPass))
            {

                using (SqlConnection _con = new SqlConnection(Capstone_Project_598.Properties.Settings.Default.cmfunk15ConnectionString))
                {
                    string oString = "select * from dbo.Account where Username = N'" + tempUser + "'";
                    SqlCommand ocmd = new SqlCommand(oString, _con);
                    ocmd.Parameters.Clear();
                    ocmd.Parameters.AddWithValue("@UserName", tempUser);
                    _con.Open();
                    using (SqlDataReader oReader = ocmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            byte[] data = System.Text.Encoding.ASCII.GetBytes(tempPass);
                            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                            string hashedtempPass = System.Text.Encoding.ASCII.GetString(data);


                            comparePass = oReader["Pass1Textphrase"].ToString();


                            if (comparePass == hashedtempPass)
                            {
                                UserName = tempUser;
                                MessageBox.Show("Moving onto stage 2...");
                                bigTextLabel.Text = "2) Please choose your correct image.";
                                uxUserLabel.Visible = false; uxPassLabel.Visible = false;
                                passwordTextBox.Visible = false; usernameTextBox.Visible = false;
                                label1.Visible = false; continueButton.Visible = false;
                                label2.Visible = false;

                                realImageHash = oReader["Pass3Image"].ToString();

                                int compareInt = 0; string compareImage = "z";
                                byte[] test1;       string hashedCompareImage = "reee";
                                while(hashedCompareImage != realImageHash && compareInt < 13)
                                {
                                    compareInt++;
                                    compareImage = compareInt.ToString() + compareInt.ToString() + compareInt.ToString() + compareInt.ToString();
                                    test1 = System.Text.Encoding.ASCII.GetBytes(compareImage);
                                    test1 = new System.Security.Cryptography.SHA256Managed().ComputeHash(test1);
                                    hashedCompareImage = System.Text.Encoding.ASCII.GetString(test1); 
                                }

                                Image realImage = imageDictionary[compareInt];
                                ///set to a random picture box to ensure we're showing correct one, and three random and go from there

                                Random rand = new Random();
                                int i = rand.Next(4);               //0-3

                                pictureBoxes[i].Image = realImage;
                                int [] indexforImages  = new int[4];

                                compareInt--;
                                indexforImages[1] = rand.Next(12);       //0-11
                                while (indexforImages[1] == compareInt)
                                    indexforImages[1] = rand.Next(12);
                                indexforImages[2] = rand.Next(12);
                                while (indexforImages[2] == indexforImages[1] || indexforImages[2] == compareInt)
                                    indexforImages[2] = rand.Next(12);
                                indexforImages[3] = rand.Next(12);
                                while (indexforImages[3] == indexforImages[2] || indexforImages[3] == indexforImages[1] || indexforImages[3] == compareInt)
                                    indexforImages[3] = rand.Next(12);

                                for(int jj = 0; jj < 4; jj++)
                                {
                                    if (jj != i)
                                        pictureBoxes[jj].Image = imageDictionary[indexforImages[jj] + 1];
                                }



                                                    /////REWORK




                                foreach (PictureBox yy in pictureBoxes)
                                    yy.Visible = true;
                                foreach (CheckBox xxx in checkBoxes)
                                    xxx.Visible = true;



                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username / Password combination");
                                usernameTextBox.Text = "";          passwordTextBox.Text = "";
                            }

                        }

                    }
                }

                



            }
            else
            {   MessageBox.Show("Invalid necessary information.");  }


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
            //charsUsernameXLabel.Visible = ifneeded22.Length > 5 ? false : true;

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

            //charsPasswordXLabel.Visible = temppp.Length > 5 ? false : true;
            //speccharPasswordXLabel.Visible = regexItem.IsMatch(ee) ? true : false;

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

        private void initLists()
        {
            pictureBoxes = new List<PictureBox>();
            checkBoxes = new List<CheckBox>();

            pictureBoxes.Add(pictureBox1); pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3); pictureBoxes.Add(pictureBox4);
            checkBoxes.Add(checkBox1); checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3); checkBoxes.Add(checkBox4);

            foreach (CheckBox i in checkBoxes)
                i.Visible = false;
            foreach (PictureBox j in pictureBoxes)
                j.Visible = false;

        }


    }
}
