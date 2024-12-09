using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _3935_Registo_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string string_cnn = "datasource=sql7.freemysqlhosting.net;port=3306;username=sql7750220;password=qn5fvYrwXy;database=sql7750220";

                string sql = "INSERT INTO clientes(nome, morada, numero, complemento, codpostal, cidade, concelho, pais, telefone)" +
                    " VALUES ('" + txtNome.Text + "', '" + txtMorada.Text + "', '" + txtNumero.Text + "', " +
                    "'" + txtComplemento.Text + "', '" + txtCodPostal.Text + "', '" + txtCidade.Text + "'," +
                    " '" + txtConcelho.Text + "', '" + txtPais.Text + "', '" + txtTelefone.Text + "')";


                MySqlConnection cnn = new MySqlConnection(string_cnn);


                MySqlCommand retorno_comando = new MySqlCommand(sql, cnn);

                cnn.Open();

                retorno_comando.ExecuteReader();

                MessageBox.Show("Cliente Registado com sucesso!");

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
