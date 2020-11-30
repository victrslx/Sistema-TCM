﻿using System;
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

namespace Tela_de_Splash
{
    public partial class frm_Principal : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;

        //construtor
        public frm_Principal()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7,84);
            panelMenu.Controls.Add(leftborderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        //estrutura
        private struct RGBColors
        {
            public static Color color1=Color.FromArgb(249, 130, 12);
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


        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconPagAtual.IconChar = IconChar.Home;
            iconPagAtual.IconColor = Color.Orange;
            lblPagAtualHome.Text = "Home";

        }

        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnDelivery_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
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
    }
}
