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

namespace Tela_de_Splash
{
    public partial class Vendas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TFD466O\SQLEXPRESS; Initial Catalog = db_games; Integrated Security = sspi");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader objDados;



        public Vendas()
        {
            InitializeComponent();
        }

        private void somaTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvvendas.Rows)
            {
                total += Convert.ToDecimal(row.Cells["valorprod"].Value);
            }
            lblTotalGeral.Text = Convert.ToString(total);
        }

        private void preencheGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tbl_vendas where cd_venda = " + lblcodvendas.Text;
                cmd.Connection = con; // informando que este comando sql será executado na conexao estabelecida
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgvvendas.DataSource = dt;
                somaTotal();
                con.Close(); // fechando conexao

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (txtProd.Text.Length <3) 
            {
                try
                {
                    
                con.Open(); // abrindo conexão com o banco de dados

                    string strsql = "select  cd_produtos, nm_produto, valorprod from tbl_produtos where cd_produtos = " + txtProd.Text;
                    cmd.Connection = con; // informando a conexao
                    cmd.CommandText = strsql;
                    objDados = cmd.ExecuteReader(); // executando leitura dos dados;
                    if (!objDados.HasRows) // se tiver linha com cpf digitado entao...
                    {
                        MessageBox.Show("Produto não cadadstrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProd.Text = "";
                        txtProd.Focus();
                        con.Close();
                    }
                    else
                    {
                        objDados.Read();
                        lblNomeProd.Text = objDados["nm_produto"].ToString();
                        lblValor.Text = objDados["valorprod"].ToString();
                        con.Close();
                    }

                    if (!objDados.IsClosed) { objDados.Close(); } // caso leitor NÃO estiver fechado, então feche.
                    txtquantidade.Text = "1";
                    lblTotal.Text = lblValor.Text;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "aTENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblNomeProd.Text = "";
                lblValor.Text = "";
            }
        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtquantidade.Text != "")
            {
                int qt = Convert.ToInt16(txtquantidade.Text);
                decimal valor = Convert.ToDecimal(lblValor.Text);
                decimal total = qt * valor;
                lblTotalGeral.Text = total.ToString();
            }
            else
            {
                lblTotalGeral.Text = "";
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int cdvenda = Convert.ToInt32(lblcodvendas.Text);
            int codProd = Convert.ToInt32(txtProd.Text);
            string data = mskData.Text;
            int qt = Convert.ToInt32(txtquantidade.Text);
            decimal total = Convert.ToDecimal(lblTotal.Text);


            try
            {
                string sql = "insert into tbl_vendas(cd_venda,cd_produtos,dt_venda,quantidade,valorprod)values(@venda,@produtos,@dtvenda,@qtde,@valorprod)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@venda", SqlDbType.Int).Value = cdvenda;
                cmd.Parameters.Add("@produtos", SqlDbType.Int).Value = codProd;
                cmd.Parameters.Add("@dtvenda", SqlDbType.Date).Value = data;
                cmd.Parameters.Add("@qtde", SqlDbType.Int).Value = qt;
                cmd.Parameters.Add("@valorprod", SqlDbType.Decimal).Value = total;
                con.Open(); // abrindo conexão com o banco de dados
                cmd.ExecuteNonQuery(); // executando a instrução sql
                con.Close();
                MessageBox.Show("Dados inseridos com sucesso !!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preencheGrid();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void carregaValor()
        {
            try
            {
                con.Open(); // abrindo conexão com o banco de dados
                cmd.CommandText = "select top 1 cd_venda from tbl_vendas order by cd_venda desc";
                cmd.Connection = con; // informando a conexao
                objDados = cmd.ExecuteReader(); // executando leitura dos dados;


                if (!objDados.HasRows) // se tiver linha com cpf digitado entao...
                {
                    lblcodvendas.Text = 1.ToString();
                }
                else
                {
                    objDados.Read();
                    string numero = objDados["cd_venda"].ToString();
                    int contador = Convert.ToInt32(numero);
                    contador++;
                    lblcodvendas.Text = contador.ToString();

                }

                if (!objDados.IsClosed) { objDados.Close(); } // caso leitor NÃO estiver fechado, então feche.
                con.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvvendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            preencheGrid();

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            carregaValor();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            carregaValor();
        }
    }
}
