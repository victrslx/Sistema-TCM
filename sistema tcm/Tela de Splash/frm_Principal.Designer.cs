
namespace Tela_de_Splash
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.btnDelivery = new FontAwesome.Sharp.IconButton();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.panelLogoReset = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconPagAtual = new FontAwesome.Sharp.IconPictureBox();
            this.lblPagAtualHome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogoReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPagAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.btn);
            this.panelMenu.Controls.Add(this.btnConsulta);
            this.panelMenu.Controls.Add(this.btnDelivery);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.panelLogoReset);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 633);
            this.panelMenu.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btn.IconColor = System.Drawing.Color.Gainsboro;
            this.btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn.IconSize = 32;
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(0, 488);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(10, 10, 20, 0);
            this.btn.Size = new System.Drawing.Size(214, 84);
            this.btn.TabIndex = 5;
            this.btn.Text = "A Definir";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsulta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 404);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 10, 20, 0);
            this.btnConsulta.Size = new System.Drawing.Size(214, 84);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelivery.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnDelivery.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDelivery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelivery.IconSize = 32;
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Location = new System.Drawing.Point(0, 320);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Padding = new System.Windows.Forms.Padding(10, 10, 20, 0);
            this.btnDelivery.Size = new System.Drawing.Size(214, 84);
            this.btnDelivery.TabIndex = 3;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click_1);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnProdutos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutos.IconSize = 32;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 236);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(10, 10, 20, 0);
            this.btnProdutos.Size = new System.Drawing.Size(214, 84);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click_1);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVendas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.IconSize = 32;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 152);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(10, 10, 20, 0);
            this.btnVendas.Size = new System.Drawing.Size(214, 84);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click_1);
            // 
            // panelLogoReset
            // 
            this.panelLogoReset.Controls.Add(this.btnHome);
            this.panelLogoReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoReset.Location = new System.Drawing.Point(0, 0);
            this.panelLogoReset.Name = "panelLogoReset";
            this.panelLogoReset.Size = new System.Drawing.Size(214, 152);
            this.panelLogoReset.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(-3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(223, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Controls.Add(this.lblPagAtualHome);
            this.panelTitleBar.Controls.Add(this.iconPagAtual);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(903, 106);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconPagAtual
            // 
            this.iconPagAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconPagAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPagAtual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPagAtual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPagAtual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagAtual.IconSize = 37;
            this.iconPagAtual.Location = new System.Drawing.Point(12, 38);
            this.iconPagAtual.Name = "iconPagAtual";
            this.iconPagAtual.Size = new System.Drawing.Size(37, 37);
            this.iconPagAtual.TabIndex = 0;
            this.iconPagAtual.TabStop = false;
            // 
            // lblPagAtualHome
            // 
            this.lblPagAtualHome.AutoSize = true;
            this.lblPagAtualHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagAtualHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPagAtualHome.Location = new System.Drawing.Point(51, 45);
            this.lblPagAtualHome.Name = "lblPagAtualHome";
            this.lblPagAtualHome.Size = new System.Drawing.Size(52, 20);
            this.lblPagAtualHome.TabIndex = 1;
            this.lblPagAtualHome.Text = "Home";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 633);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.panelLogoReset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPagAtual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogoReset;
        private FontAwesome.Sharp.IconButton btnVendas;
        private FontAwesome.Sharp.IconButton btn;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private FontAwesome.Sharp.IconButton btnDelivery;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconPagAtual;
        private System.Windows.Forms.Label lblPagAtualHome;
    }
}