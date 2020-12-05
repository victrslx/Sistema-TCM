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

namespace Tela_de_Splash.Forms
{
    public partial class Pedido : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TFD466O\SQLEXPRESS; Initial Catalog = db_games; Integrated Security = sspi");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader dt;

        public Pedido()
        {
            InitializeComponent();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", con);

            if (txtCdPedido.Text == "")
            {

                Da.SelectCommand.CommandText = "SELECT * FROM tbl_pedido";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;


            }
            else
            {

                Da.SelectCommand.CommandText = "SELECT * FROM tbl_pedido WHERE cd_pedido =" + txtCdPedido.Text + "";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;


            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
