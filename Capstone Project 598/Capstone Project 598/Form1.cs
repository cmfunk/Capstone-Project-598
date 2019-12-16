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
using System.IO;

namespace Capstone_Project_598
{
    public partial class AddUserForm : Form
    {
        private UserInterface ownerForm = null;
        private LogonForm logonForm = null;
        private List<string> UsernameDictionary;

        private SqlConnection _con = new SqlConnection(Capstone_Project_598.Properties.Settings.Default.cmfunk15ConnectionString);
        private SqlCommand _cmd = new SqlCommand();
        //private SqlDataReader _reader;
        int[] possibleValues;                   private Encryptor encr;// = new Encryptor()

        private string Username;
        private string Password;
        private string ImageforSegmentation;

        bool isTopPanelDragged = false;
        private Point offset;
        Dictionary<int, Image> imageDictionary;
        List<PictureBox> pictureBoxes;
        List<CheckBox> checkBoxes;
        List<Button> coloredButtons;


        public AddUserForm(UserInterface ownerForm, Dictionary<int, Image> images)
        {
            InitializeComponent();              imageDictionary = images;
            UsernameDictionary = new List<string>();
            this.ownerForm = ownerForm;
            charactersXLabel.Visible = true;    specCharsLabel.Visible = false;
            chooseUsernameButton.Enabled = false;       imageSubmitButton.Visible = false;
            //State = 0;
            possibleValues = new int[4];
            checkBoxes = new List<CheckBox>(); pictureBoxes = new List<PictureBox>();   coloredButtons = new List<Button>();
            initStuff();                encr = new Encryptor();

            foreach (PictureBox ee in pictureBoxes)
                ee.Visible = false;
            foreach (CheckBox rr in checkBoxes)
                rr.Visible = false;

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

            if (g.Length > 5)
            {
                using (SqlConnection _con = new SqlConnection(Capstone_Project_598.Properties.Settings.Default.cmfunk15ConnectionString))
                {
                    string oString = "select Username from dbo.Account";
                    SqlCommand ocmd = new SqlCommand(oString, _con);
                    ocmd.Parameters.Clear();
                    _con.Open();
                    UsernameDictionary.Clear();
                    using (SqlDataReader reader = ocmd.ExecuteReader())
                    {
                        while(reader.Read())
                        { UsernameDictionary.Add(reader.GetString(0)); }
                    }
                }

                foreach (string tmp in UsernameDictionary)
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
                    //MessageBox.Show("### Username is available ###");//create user in SQL Database 
                    Username = g;
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

            if (ree.Length > 7 && !regexItem.IsMatch(ree))
            {
                Password = encr.encryptString(ree);

                bigTextLabel.Text = "3) Please choose a picture";
                choosePasswordButton.Visible = false; chooseUsernameButton.Visible = false;
                passwordTextBox.Visible = false;            
                label5.Visible = false;         //"spaces will be omitted"

                label1.Visible = false;
                var random = new Random();

                int picbox1 = random.Next(12);
                int picbox2 = random.Next(12);
                while (picbox2 == picbox1)
                    picbox2 = random.Next(12);
                int picbox3 = random.Next(12);
                while (picbox3 == picbox1 || picbox3 == picbox2)
                    picbox3 = random.Next(12);
                int picbox4 = random.Next(12);
                while (picbox4 == picbox1 || picbox4 == picbox2 || picbox4 == picbox3)
                    picbox4 = random.Next(12);

                possibleValues[0] = picbox1;  possibleValues[1] = picbox2;
                possibleValues[2] = picbox3;  possibleValues[3] = picbox4;

                pictureBox1.Image = imageDictionary[picbox1];
                pictureBox2.Image = imageDictionary[picbox2];
                pictureBox3.Image = imageDictionary[picbox3];
                pictureBox4.Image = imageDictionary[picbox4];

                imageSubmitButton.Enabled = false;
                imageSubmitButton.Visible = true;

                foreach (PictureBox yy in pictureBoxes)
                    yy.Visible = true;
                foreach (CheckBox xx in checkBoxes)
                    xx.Visible = true;
            }
        }

        private void PasswordTextBox_TextChangedDelayed(object sender, EventArgs e)
        {
            string ttt = passwordTextBox.Text;      string ifneededd22 = "";

            if (ttt.Contains(" "))
            {
                ifneededd22 = ttt.Replace(" ", "");
                passwordTextBox.Text = ifneededd22;
            }

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string tt = passwordTextBox.Text.Trim();
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (tt.Length < 8 || regexItem.IsMatch(tt))
                choosePasswordButton.Enabled = false;
            else
                choosePasswordButton.Enabled = true;
            
            charactersXLabel.Visible = tt.Length < 8 ? true : false;

            specCharsLabel.Visible = regexItem.IsMatch(tt) ? true : false;
        }


        private void RedButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "R";

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

        private void BlueButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "B";
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

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            patternLa.Text += "P";
            minPatternLabel.Visible = patternLa.Text.Length > 7 ? false : true;
            if (patternLa.Text.Length == 16)
                DisableButtons();

            submitPatternButton.Enabled = patternLa.Text.Length > 7 ? true : false;
        }

        private void DisableButtons()
        {
            redButton.Enabled = false; greenButton.Enabled = false; blueButton.Enabled = false;
            yellowButton.Enabled = false; purpleButton.Enabled = false;
        }

        private void SubmitPatternButton_Click(object sender, EventArgs e)
        {
            
            if (patternLa.Text.Length > 7)
            {
                string colorCode = encr.encryptString(patternLa.Text);

                string ImageHash = encr.encryptString(ImageforSegmentation);

                _cmd.Parameters.Clear();

                _con.Open();
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.CommandText = "dbo.AddAccount";
                _cmd.Connection = _con;

                _cmd.Parameters.AddWithValue("@UserName", Username);
                _cmd.Parameters.AddWithValue("@Pass1Textphrase", Password);
                _cmd.Parameters.AddWithValue("@Pass2Colorcode", colorCode);
                _cmd.Parameters.AddWithValue("@Pass3Image", ImageHash/*ImageforSegmentation*/);
                _cmd.ExecuteNonQuery();
                _con.Close();

                MessageBox.Show("## Pattern Set! ##\n# User Successfully Created! #", "User Successfully Created!");

                if (Application.OpenForms.OfType<LogonForm>().Count() == 0)
                {
                    logonForm = new LogonForm(ownerForm, imageDictionary);
                    logonForm.Show();
                }
                else if (Application.OpenForms.OfType<LogonForm>().Count() == 1)
                    Application.OpenForms.OfType<LogonForm>().First().BringToFront();
                else //if (Application.OpenForms.OfType<LogonForm>().Count() > 1)
                {
                    FormCollection fc = Application.OpenForms;
                    foreach (Form frm in fc)
                    {
                        if (frm.GetType() == logonForm.GetType())
                            frm.Close();
                    }
                    logonForm = new LogonForm(ownerForm, imageDictionary);
                    logonForm.Show();
                }
                this.Close();
            }
        }

        private SqlParameter convertToSqlParam(string str, string sqlVar)
        {
            SqlParameter temp = new SqlParameter();
            temp.ParameterName = sqlVar;
            temp.SqlDbType = System.Data.SqlDbType.NVarChar;
            temp.Direction = System.Data.ParameterDirection.Input;
            temp.Value = str;
            return temp;
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false;
            imageSubmitButton.Enabled = checkBox1.Checked ? true : false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;  checkBox3.Checked = false; checkBox4.Checked = false;
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
            if (checkBox1.Checked)
                ImageforSegmentation = possibleValues[0].ToString() + possibleValues[0].ToString() + possibleValues[0].ToString() + possibleValues[0].ToString();
            else if (checkBox2.Checked)
                ImageforSegmentation = possibleValues[1].ToString() + possibleValues[1].ToString() + possibleValues[1].ToString() + possibleValues[1].ToString();
            else if (checkBox3.Checked)
                ImageforSegmentation = possibleValues[2].ToString() + possibleValues[2].ToString() + possibleValues[2].ToString() + possibleValues[2].ToString();
            else if (checkBox4.Checked)
                ImageforSegmentation = possibleValues[3].ToString() + possibleValues[3].ToString() + possibleValues[3].ToString() + possibleValues[3].ToString();

            bigTextLabel.Text = "4) Please choose a pattern";
            imageSubmitButton.Visible = false;
            foreach (PictureBox ee in pictureBoxes)
                ee.Visible = false;
            foreach (CheckBox rr in checkBoxes)
                rr.Visible = false;

            submitPatternButton.Visible = true;
            foreach (Button bb in coloredButtons)
                bb.Visible = true;

            patternLa.Visible = true;
            minPatternLabel.Visible = true;         maxPatternLabel.Visible = true;

        }

        private void initStuff()
        {
            pictureBoxes.Add(pictureBox1); pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3); pictureBoxes.Add(pictureBox4);
            checkBoxes.Add(checkBox1); checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3); checkBoxes.Add(checkBox4);
            coloredButtons.Add(redButton); coloredButtons.Add(greenButton); coloredButtons.Add(blueButton);
            coloredButtons.Add(yellowButton); coloredButtons.Add(purpleButton);

        }
    }
}
