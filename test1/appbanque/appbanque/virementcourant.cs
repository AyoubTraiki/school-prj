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
    public partial class virementcourant : Form
    {
        public virementcourant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double somme = double.Parse(textBox1.Text);
                int numCompte = int.Parse(textBox2.Text);
                SqlConnection connexion;
                string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                connexion = new SqlConnection(connectionstring);
                connexion.Open();

                SqlCommand command;
                string sql;
                string solde = "";
                SqlDataReader dataReader;
                sql = "Select solde from comptecourant where IdC='" + numCompte + "'";
                command = new SqlCommand(sql, connexion);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    solde = dataReader.GetValue(0).ToString();
                }
                double newsolde = double.Parse(solde) + somme;
                else
                {
                    MessageBox.Show("retapez les champs suivants");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
