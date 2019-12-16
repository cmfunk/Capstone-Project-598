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
        private Point offset;               private Encryptor encr;

        int[] possibleValues;
        List<PictureBox> pictureBoxes;
        List<CheckBox> checkBoxes;
        List<Button> coloredButtons;

        Random rand;

        private string UserName;
        private string Password;
        private string imageCode;

        private Dictionary<int, Image> imageDictionary;

        bool usernameLenBool = false;
        bool passwordLenBool = false;

        public LogonForm(UserInterface ownerForm, Dictionary<int, Image> images)
        {
            InitializeComponent();
            imageDictionary = new Dictionary<int, Image>();
            imageDictionary = images;       rand = new Random();
            this.ownerForm = ownerForm;
            continueButton.Enabled = false;

            initLists();                    encr = new Encryptor();
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

            UserName = tempUser;                Password = tempPass;    
            string comparePass;         string realImageHash;       bool isUsernameinDB = false;
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
                        while (oReader.Read())                                          ////////if not correct username, Will not read
                        {
                            isUsernameinDB = true;
                            string hashedtempPass = encr.encryptString(tempPass);

                            comparePass = oReader["Pass1Textphrase"].ToString();            

                            if (comparePass == hashedtempPass)                                              
                            {
                                UserName = tempUser;
                                bigTextLabel.Text = "2) Please choose your correct image.";
                                uxUserLabel.Visible = false; uxPassLabel.Visible = false;
                                passwordTextBox.Visible = false; usernameTextBox.Visible = false;
                                label1.Visible = false; continueButton.Visible = false;
                                label2.Visible = false;

                                realImageHash = oReader["Pass3Image"].ToString();               //hashed image

                                int i = -1;     string compareHash = "";

                                while(compareHash != realImageHash )
                                {
                                    i++;
                                    compareHash = i.ToString() + i.ToString() + i.ToString() + i.ToString();
                                    compareHash = encr.encryptString(compareHash);
                                }

                                imageCode = i.ToString() + i.ToString() + i.ToString() + i.ToString();
                                Image realImage = imageDictionary[i];              //i is correct 0-11 int index of real image

                                int j = rand.Next(4);

                                pictureBoxes[j].Image = realImage;

                                int[] index = new int[4];                   //j is index of 0-3 of pictureBoxes, i is index 0-11 of true image

                                index[0] = rand.Next(12);   
                                while (index[0] == i)
                                    index[0] = rand.Next(12);
                                index[1] = rand.Next(12);
                                while (index[1] == index[0] || index[1] == i)
                                    index[1] = rand.Next(12);
                                index[2] = rand.Next(12);
                                while (index[2] == index[1] || index[2] == index[0] || index[2] == i)
                                    index[2] = rand.Next(12);
                                index[3] = rand.Next(12);
                                while (index[3] == index[2] || index[3] == index[1] || index[3] == index[0] || index[3] == i)
                                    index[3] = rand.Next(12);

                                possibleValues[j] = i;

                                for (int k = 0; k < 4; k++)
                                {
                                    if (k != j)
                                    {
                                        pictureBoxes[k].Image = imageDictionary[index[k]];
                                        possibleValues[k] = index[k];
                                    }
                                }

                                imageSubmitButton.Visible = true;       imageSubmitButton.Enabled = false;
                                foreach (PictureBox yy in pictureBoxes)
                                    yy.Visible = true;
                                foreach (CheckBox xxx in checkBoxes)
                                    xxx.Visible = true;

                            }
                            else
                            { alternatePath(tempUser); }
                        }
                        if (!isUsernameinDB)
                        { alternatePath(tempUser); }
                    }
                }
                
                

            }
            else
            {   MessageBox.Show("Invalid necessary information.");  }


        }

        private void alternatePath (string tempUser)
        {
            UserName = tempUser;
            bigTextLabel.Text = "2) Please choose your correct image.";
            uxUserLabel.Visible = false; uxPassLabel.Visible = false;
            passwordTextBox.Visible = false; usernameTextBox.Visible = false;
            label1.Visible = false; continueButton.Visible = false;
            label2.Visible = false;

            int[] index = new int[4];                   //all random

            index[0] = rand.Next(12);
            index[1] = rand.Next(12);
            while (index[1] == index[0])
                index[1] = rand.Next(12);
            index[2] = rand.Next(12);
            while (index[2] == index[1] || index[2] == index[0])
                index[2] = rand.Next(12);
            index[3] = rand.Next(12);
            while (index[3] == index[1] || index[3] == index[2] || index[3] == index[1])
                index[3] = rand.Next(12);

            

            for (int k = 0; k < 4; k++)
            {
                pictureBoxes[k].Image = imageDictionary[index[k]];
                possibleValues[k] = index[k];
            }

            imageSubmitButton.Visible = true; imageSubmitButton.Enabled = false;
            foreach (PictureBox yy in pictureBoxes)
                yy.Visible = true;
            foreach (CheckBox xxx in checkBoxes)
                xxx.Visible = true;
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
            submitPatternButton.Visible = false;
            imageSubmitButton.Visible = false;
            pictureBoxes = new List<PictureBox>();
            checkBoxes = new List<CheckBox>();
            coloredButtons = new List<Button>();
            possibleValues = new int[4];

            coloredButtons.Add(redButton); coloredButtons.Add(greenButton); coloredButtons.Add(blueButton);
            coloredButtons.Add(yellowButton);           coloredButtons.Add(purpleButton);
            pictureBoxes.Add(pictureBox1); pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3); pictureBoxes.Add(pictureBox4);
            checkBoxes.Add(checkBox1); checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3); checkBoxes.Add(checkBox4);

            minPatternLabel.Visible = false;
            maxPatternLabel.Visible = false;

            foreach (Button bb in coloredButtons)
                bb.Visible = false;
            foreach (CheckBox i in checkBoxes)
                i.Visible = false;
            foreach (PictureBox j in pictureBoxes)
                j.Visible = false;

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false;
            imageSubmitButton.Enabled = checkBox1.Checked ? true : false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false;
            imageSubmitButton.Enabled = checkBox2.Checked ? true : false;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false; checkBox2.Checked = false; checkBox4.Checked = false;
            imageSubmitButton.Enabled = checkBox3.Checked ? true : false;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false; checkBox3.Checked = false; checkBox2.Checked = false;
            imageSubmitButton.Enabled = checkBox4.Checked ? true : false;
        }

        private void ImageSubmitButton_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)                                            CHECKING IF CORRECT IMAGE ://////////////////    FOR TRUE OR FALSE

            if (checkBox1.Checked)
                imageCode = possibleValues[0].ToString() + possibleValues[0].ToString() + possibleValues[0].ToString() + possibleValues[0].ToString();
            else if (checkBox2.Checked)
                imageCode = possibleValues[1].ToString() + possibleValues[1].ToString() + possibleValues[1].ToString() + possibleValues[1].ToString();
            else if (checkBox3.Checked)
                imageCode = possibleValues[2].ToString() + possibleValues[2].ToString() + possibleValues[2].ToString() + possibleValues[2].ToString();
            else if (checkBox4.Checked)
                imageCode = possibleValues[3].ToString() + possibleValues[3].ToString() + possibleValues[3].ToString() + possibleValues[3].ToString();

            bigTextLabel.Text = "4) Please complete your pattern.";
            imageSubmitButton.Visible = false;
            foreach (PictureBox x in pictureBoxes)
                x.Visible = false;
            foreach (CheckBox y in checkBoxes)
                y.Visible = false;

            foreach (Button q in coloredButtons)
                q.Visible = true;

            submitPatternButton.Visible = true;
            patternLa.Visible = true;

            minPatternLabel.Visible = true;
            maxPatternLabel.Visible = true;


        }

        private void DisableButtons ()
        {
            foreach (Button bb in coloredButtons)
                bb.Enabled = false;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "R";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "Y";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "G";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "P";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "B";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void SubmitPatternButton_Click(object sender, EventArgs e)
        {
            string hashedPassword = encr.encryptString(Password);
            string hashedImage = encr.encryptString(imageCode);
            string hashedPattern = encr.encryptString(patternLa.Text);

            bool isUsernameinDBO = false;
            using (SqlConnection _con = new SqlConnection(Capstone_Project_598.Properties.Settings.Default.cmfunk15ConnectionString))
            {
                string oString = "select * from dbo.Account where Username = N'" + UserName + "'";
                SqlCommand ocmd = new SqlCommand(oString, _con);
                ocmd.Parameters.Clear();
                ocmd.Parameters.AddWithValue("@UserName", UserName);
                _con.Open();
                using (SqlDataReader oReader = ocmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        isUsernameinDBO = true;
                        string cmpPass = oReader["Pass1Textphrase"].ToString();
                        string cmpColor = oReader["Pass2Colorcode"].ToString();
                        string cmpImage = oReader["Pass3Image"].ToString();

                        if (hashedPassword == cmpPass && hashedImage == cmpImage && hashedPattern == cmpColor)
                            MessageBox.Show("##Successfull logon.##", "Success!");
                        else
                        { MessageBox.Show("Invalid Credentials"); this.Close(); }
                    }
                    if (!isUsernameinDBO)
                    { MessageBox.Show("Invalid Credentials"); this.Close(); }
                }
            }


        }
    }
}
