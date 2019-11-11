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
        private List<string> UsernameDictionary = new List<string>();

        //SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cmfunk15;Integrated Security=True;Encrypt=False");
        public const string _connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cmfunk15;Integrated Security=false;Encrypt=False";
        private SqlConnection _con = new SqlConnection(_connStr);
        private SqlCommand _cmd = new SqlCommand();
        private SqlDataReader _reader;
        //<add name="SQLServerConnection" connectionString="Server=localhost;Database=database1;Trusted_Connection=True;/>

        //private int State;

        private string Username;
        private string Password;
        private Image ImageSegmentation;

        bool isTopPanelDragged = false;
        private Point offset;

        public AddUserForm(UserInterface ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            charactersXLabel.Visible = true;    specCharsLabel.Visible = false;
            chooseUsernameButton.Enabled = false;       uploadFileButton.Visible = false;
            submitPictureButton.Visible = false;        submitPictureButton.Enabled = true;
            pictureBox1.Visible = false;
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

            if (ree.Length > 7 && !regexItem.IsMatch(ree))
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(ree);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);


                //wrap connection in authentication encryption


                Password = ree;
                //MessageBox.Show("## Password is set! ##");

                bigTextLabel.Text = "3) Please upload a picture";
                choosePasswordButton.Visible = false; chooseUsernameButton.Visible = false;
                passwordTextBox.Visible = false;            
                label5.Visible = false;         //"spaces will be omitted"

                uploadFileButton.Visible = true;        label1.Visible = false;
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

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFD = new OpenFileDialog();
            uploadFileButton.Visible = false;
            OpenFD.Title = "Locate image file.";
            OpenFD.Filter = "Jpeg|*.jpeg|Jpg|*.jpg|Jpge|*.jpge|PNG|*.png";
            OpenFD.FileName = null;
            string fileName;            Image test = null;
            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                //querybuilder qu = new querybuilder();
                fileName = OpenFD.FileName;
                Object refmissing = System.Reflection.Missing.Value;

                if (File.Exists(fileName))
                {
                    try
                    {
                        test = Image.FromFile(OpenFD.FileName);
                        if (test != null)
                        {
                            uploadFileButton.Visible = false;

                            ImageSegmentation = test;   //pictureBox1.Image = test;
                            //MessageBox.Show("## Image Set! ##");
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Image = test;       pictureBox1.Visible = true;

                            //bigTextLabel.Text = "4) Please choose a pattern";
                            submitPictureButton.Visible = true;    submitPictureButton.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {   MessageBox.Show("Error" + ex.Message.ToString());
                        uploadFileButton.Visible = true;  }
                }
                else
                { MessageBox.Show("Unable to locate file....", "#ERROR#");
                    uploadFileButton.Visible = true;  }
            }
            else
            { uploadFileButton.Visible = true; }
            OpenFD.Dispose();
        }

        private void SubmitPictureButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("## Image Set! ##", "Success!");
            bigTextLabel.Text = "4) Please choose a pattern";
            submitPictureButton.Visible = false;        pictureBox1.Visible = false;

            submitPatternButton.Visible = true;
            redButton.Visible = true; greenButton.Visible = true;  blueButton.Visible = true;
            yellowButton.Visible = true;            purpleButton.Visible = true;
            patternLa.Visible = true;
            minPatternLabel.Visible = true;         maxPatternLabel.Visible = true;
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
                _cmd.Parameters.Clear();
                _con.Open();
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.CommandText = "dbo.AddAccount";
                _cmd.Connection = _con;

                _cmd.Parameters.AddWithValue(Username, "@UserName");
                _cmd.Parameters.AddWithValue(Password, "@Pass1Textphrase");
                _cmd.Parameters.AddWithValue("708.54", "@Balance");
                _cmd.Parameters.AddWithValue(patternLa.Text, "@Pass2ColorCode");
                _cmd.Parameters.AddWithValue(ImageSegmentation.ToString(), "@Pass3Image");
                _cmd.Parameters.AddWithValue("1", "@AccountID");
                _cmd.Parameters.AddWithValue("random name", "@Name");
                _cmd.Parameters.AddWithValue("5432 wavy road", "@Address");
                _cmd.Parameters.AddWithValue("20191123 03:34:00 +10:00", "@DOB");
                _cmd.Parameters.AddWithValue("43657865", "@CardNumber");
                _cmd.Parameters.AddWithValue("5356", "@Pin");
                _cmd.ExecuteNonQuery();
                _con.Close();
                /*@UserName nvarchar(32),
	                @Pass1Textphrase nvarchar(64),
	            @Balance float,
                @Pass2Colorcode nvarchar(16),
	            @Pass3Image varbinary(MAX),
	            @AccountID int,
                @Name nvarchar(80),
	            @Address nvarchar(100),
	            @DOB datetimeoffset,
                @CardNumber int,
                @Pin int*/


                MessageBox.Show("## Pattern Set! ##\n# User Successfully Created! #", "User Successfully Created!");



                this.Close();
            }
            ///////WORK ON THIS TO CREATE ACCOUNT
        }
    }
}
