using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FitFactoryForTrainer
{
    public partial class Login : Form
    {
        private DataBase db = DataBase.GetInstance();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text!="" && tbPassword.Text!="")
            {
                MD5 md = MD5.Create();
                string login = tbLogin.Text;
                string password = "" + GetMd5Hash(md, tbPassword.Text) + "";
       
                DataTable dt = new DataTable();
                dt = db.CheckLogin(login,  password);
                DataRow r = dt.Rows[0];

                if (int.Parse(r["Column1"].ToString()) != 0)
                {
                    db.GetCoachId(int.Parse(r["Column1"].ToString()));
                    FitFactoryMain f = new FitFactoryMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Podany użytkownik nie istnieje w bazie.");
                }          
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }

}
