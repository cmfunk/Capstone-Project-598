using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_598
{
    class Account
    {
        /*private string _creditor;
        private double _rate;
        private double _payment;
        private double _balance;
        private double _ExtendedPayment;
        private bool _refinanced;
        private string[] _columns;*/

        private string _username;
        private string _password;

        //need picture file
        private string _colorscode;


        public Account(string username, string password, /* double pmt, */string colorcode)
        {



            /*_creditor = cred;
            _rate = rate;
            _payment = pmt;
            _balance = bal;
            _refinanced = false;*/
        }

        /*public string Column1
        {
            get { return _columns[0]; }
        }
        public string Column2
        {
            get { return _columns[1]; }
        }

        public bool Refinanced
        {
            get { return _refinanced; }
            set { _refinanced = value; }
        }

        public string Creditor
        {
            get { return _creditor; }
            set { _creditor = value; }
        }

        public double Rate
        {
            get { return _rate; }
            set
            {
                _rate = value;
                //MessageBox.Show("Set rate.");         √√√√
            }
        }

        public double Payment
        {
            get { return _payment; }
            //set { _payment = value; }
        }

        public double ExtendedPayment
        {
            get { return _ExtendedPayment; }
            set { _ExtendedPayment = value; }
        }

        public double Balance
        {
            get { return _balance; }
            //set { _balance = value; }
        }

        public void setCorrectColumn(int b)
        {
            string[] useee = new string[2];

            int test = b * 5 - 2;
            useee[0] = GetExcelColumnName(test);
            useee[1] = GetExcelColumnName(test + 1);

            _columns = useee;
        }

        private static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }
            return columnName;
        }*/
    }
}
