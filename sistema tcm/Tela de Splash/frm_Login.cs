using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tela_de_Splash;
using System.Data.SqlClient;

namespace desing_da_tela_de_login
{
    public partial class frm_Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TFD466O\SQLEXPRESS; Initial Catalog = db_games; Integrated Security = sspi");

        SqlCommand cmd = new SqlCommand();

        public frm_Login()
        {
            InitializeComponent();
        }

        public bool logado = false;

        public static string usuarioConectado;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO") {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true; 
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.LightGray;
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dados = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("Select * from tbl_funcionario where ds_login = @user and senha = @senha",con);
            Da.SelectCommand.Parameters.AddWithValue("@user",txtUsuario.Text);
            Da.SelectCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
            Da.Fill(dados);

            if (dados.Rows.Count == 0)
            {
                logado = false;

                MessageBox.Show("Usuario e senha invalidos");
            }
            else
            {
                usuarioConectado = txtUsuario.Text;
                logado = true;

                frm_Principal Principal = new frm_Principal();
                Principal.Show();
                this.Hide();

                MessageBox.Show("Seja bem-vindo ao sistema");
            }
            con.Close();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
