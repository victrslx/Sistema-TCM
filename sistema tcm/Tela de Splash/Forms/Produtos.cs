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
    public partial class Produtos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TFD466O\SQLEXPRESS; Initial Catalog = db_games; Integrated Security = sspi");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader dt;

        public Produtos()
        {
            InitializeComponent();
            cmd.Connection = con;
        }

        private void carregaValor()
        {
            try
            {
                con.Open(); // abrindo conexão com o banco de dados
                cmd.CommandText = "select top 1 cd_produtos from tbl_produtos order by cd_produtos desc";
                cmd.Connection = con; // informando a conexao
                dt = cmd.ExecuteReader(); // executando leitura dos dados;


                if (!dt.HasRows) // se tiver linha com cpf digitado entao...
                {
                    lblcodprod.Text = 1.ToString();
                }
                else
                {
                    dt.Read();
                    string numero = dt["cd_produtos"].ToString();
                    int contador = Convert.ToInt32(numero);
                    contador++;
                    lblcodprod.Text = contador.ToString();

                }

                if (!dt.IsClosed) { dt.Close(); } // caso leitor NÃO estiver fechado, então feche.
                con.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("escolha uma categoria", "erro", MessageBoxButtons.OK);
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("informe o nome do produto", "erro", MessageBoxButtons.OK);
                txtNome.Focus();
            }
            else if (txtDescri.Text == "")
            {
                MessageBox.Show("informe a descrição do produto", "erro", MessageBoxButtons.OK);
                txtDescri.Focus();
            }
            else
            {
                string categoria = cmbCategoria.SelectedItem.ToString();
                string cat;

                if (categoria == "Consoles")
                {
                    cat = "consoles";
                }
                else if (categoria == "Periféricos")
                {
                    cat = "periféricos";
                }
                else
                {
                    cat = "Jogos";
                }
                try
                {
                   
                   string sql = "insert into tbl_produtos(descricao,categoria,nm_produto,valorprod) values(@descri,@categoria,@nome,@valor)";
                    SqlCommand cmd = new SqlCommand(sql,con);
                    cmd.Parameters.Add("@descri", SqlDbType.VarChar).Value = txtDescri.Text;
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = cat;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = txtValor.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }


                /* try
                 {
                     con.Open();
                     cmd.Connection = con;
                     string strSQL = "Select * from tbl_produto where nm_produto = " + txtNome.Text;
                     dt = cmd.ExecuteReader();
                     if (dt.HasRows)
                     {
                         MessageBox.Show("produto já cadastrado", "ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                     {
                         if (!dt.IsClosed)
                         {
                             dt.Close();
                         }

                         strSQL = "insert into tbl_produtos(descricao,categoria,nm_produto) values(@descri,@categoria,@nome)";
                         cmd.Parameters.Add("@descri", SqlDbType.VarChar).Value = txtDescri.Text;
                         cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = cat;
                         cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

                        //md.Connection = con;
                        //md.CommandText = strSQL;
                         cmd.ExecuteNonQuery();

                         MessageBox.Show("dados cadastrados com sucesso");
                         con.Close();

                     }
                 }
                 catch (Exception erro)
                 {
                     MessageBox.Show(erro.Message);
                     con.Close();
                 }*/
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            carregaValor();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescri.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }


     
        
    }
}
