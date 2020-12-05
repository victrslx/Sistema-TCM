using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Tela_de_Splash.Forms;
using desing_da_tela_de_login;

namespace Tela_de_Splash
{
    public partial class frm_Principal : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentChildForm;

        //construtor
        public frm_Principal()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7,96);
            panelMenu.Controls.Add(leftborderBtn);
            submenu();
            
        }

        //estrutura
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 130, 12);
        }

        //metodo
        private void ActivateButton(object sanderBtn, Color color)
        {
            if(sanderBtn != null)
            {
                DisableButton();
                //btn
                currentBtn = (IconButton)sanderBtn;
                currentBtn.BackColor = Color.FromArgb(40, 40, 40);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //btn a borda esquerda
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                //Icon pag atual
                iconPagAtual.IconChar = currentBtn.IconChar;
                iconPagAtual.IconColor = color;
            }
        }
        private void btnInfoCadastro(object sanderBtn, Color color)
        {
            if (sanderBtn != null)
            {
                DisableButton();
                //btn
                currentBtn = (IconButton)sanderBtn;
                currentBtn.BackColor = Color.FromArgb(40, 40, 40);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                //Icon pag atual
                iconPagAtual.IconChar = currentBtn.IconChar;
                iconPagAtual.IconColor = color;
            }
        }

        private void submenu()
        {
            panelSubCadastro.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelSubCadastro.Visible == true)
            {
                panelSubCadastro.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(55, 55, 55);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        private void OpenChildForm(Form childForm)
        {
            //abrir apenas form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPagAtualHome.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconPagAtual.IconChar = IconChar.Home;
            lblPagAtualHome.Text = "Home";

        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelSubCadastro);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMM 'de' yyyy");
            lblNameLog.Text = ""+frm_Login.usuarioConectado;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.Show();
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Consulta());
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Pedido());
        }

        private void btnVenda_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Vendas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes());
            btnInfoCadastro(sender, RGBColors.color1);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Produtos());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
