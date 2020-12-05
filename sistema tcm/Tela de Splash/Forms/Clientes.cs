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
    public partial class Clientes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TFD466O\SQLEXPRESS; Initial Catalog = db_games; Integrated Security = sspi");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader dt;

        public void desabilitaCampos()
        {
            txtNome.Enabled = false;
            rdbMasculino.Enabled = false;
            rdbFeminino.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;
            mskTelefone.Enabled = false;
            mskCPF.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = true;
            mskCelular.Enabled = false;
            mskCep.Enabled = false;
            mskCPFSearch.Enabled = true;
            mskData.Enabled = false;
            txtRua.Enabled = false;
        }

        public void habilitaCampos()
        {
            txtNome.Enabled = true;
            rdbMasculino.Enabled = true;
            rdbFeminino.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtEmail.Enabled = true;
            mskTelefone.Enabled = true;
            mskCPF.Enabled = true;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            mskCPFSearch.Enabled = true;
            mskCep.Enabled = true;
            mskData.Enabled = true;
            mskCelular.Enabled = true;
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            txtBairro.Text = "";
            txtEmail.Text = "";
            mskTelefone.Text = "";
            mskCPF.Text = "";
            txtRua.Text = "";
            mskCelular.Text = "";
            mskData.Text = "";
            mskCPFSearch.Text = "";
            mskCep.Text = "";
        }

        

        public Clientes()
        {
            InitializeComponent();
            desabilitaCampos();
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sex;
            if(rdbMasculino.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }

            try
            {
                con.Open();
                string strSQL = "Select cpf from tbl_cliente where cpf = " + mskCPF.Text;
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    MessageBox.Show("CPF já cadastrado","ops",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!dt.IsClosed)
                    {
                        dt.Close();
                    }
                    
                    strSQL = "insert into tbl_cliente(nm_cliente,cpf,dt_nasc,sexo,rua,bairro,cep,email,telefone,celular) values (@nome,@cpf,@nasc,@sexo,@rua,@bairro,@cep,@email,@telefone,@celular)";
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@cpf", SqlDbType.Char).Value = mskCPF.Text;
                    cmd.Parameters.Add("@nasc", SqlDbType.Date).Value = Convert.ToDateTime(mskData.Text);
                    cmd.Parameters.Add("@sexo", SqlDbType.Char).Value = sex;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtRua.Text;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                    cmd.Parameters.Add("@cep", SqlDbType.Char).Value = mskCep.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@telefone", SqlDbType.Char).Value = mskTelefone.Text;
                    cmd.Parameters.Add("@celular", SqlDbType.Char).Value = mskCelular.Text;

                    cmd.Connection = con;
                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("dados cadastrados com sucesso");
                    con.Close();

                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitaCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string strSQL = "Select * from tbl_cliente where cpf = " + mskCPFSearch.Text;
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();
                if (!dt.HasRows)
                {
                    MessageBox.Show("CPF não cadastrado", "erro no CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dt.Read();
                    txtCodigo.Text = dt["cd_cliente"].ToString();
                    txtNome.Text = dt["nm_cliente"].ToString();
                    mskCPF.Text = dt["cpf"].ToString();
                    mskData.Text = dt["dt_nasc"].ToString();
                    string sex = dt["sexo"].ToString();
                    if (sex == "M")
                    {
                        rdbMasculino.Checked = true;
                    }
                    else
                    {
                        rdbFeminino.Checked = true;
                    }
                     txtRua.Text = dt["rua"].ToString();
                     txtBairro.Text = dt["bairro"].ToString();
                     mskCep.Text = dt["cep"].ToString();
                     txtEmail.Text = dt["email"].ToString();
                    mskTelefone.Text = dt["telefone"].ToString();
                    mskCelular.Text = dt["celular"].ToString();

                    if (!dt.IsClosed)
                    {
                        dt.Close();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
