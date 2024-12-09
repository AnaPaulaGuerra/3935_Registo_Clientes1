using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_Registo_Clientes
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7750220;password=qn5fvYrwXy");
            string query = "select * from sql7750220.login where user  =  '" + txtUserLogin.Text.Trim() + "' and  password = '" + txtPassLogin.Text.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Login com sucesso!");
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados incorrectos!");
            }
        }
    }
    }

