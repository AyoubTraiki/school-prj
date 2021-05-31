using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appbanque
{
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userlogin = textBox1.Text;
            string userpassword = textBox2.Text;
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);

            connexion.Open();

            SqlCommand command;
            string sql, dblogin = "", dbpassword = "";
            SqlDataReader dataReader;
            sql = "Select username, password from login";
            command = new SqlCommand(sql, connexion);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                dblogin = dataReader.GetValue(0).ToString();
                dbpassword = dataReader.GetValue(1).ToString();
            }
            if (dblogin == userlogin && dbpassword == userpassword)
            {
                Form menu = new Form1();
                menu.Show();
                this.Close();
            }
            else
                MessageBox.Show("essayer de vous reconnecter");

            connexion.Close();

        }
    }
}
