
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVenda = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.btnPedido = new FontAwesome.Sharp.IconButton();
            this.panelSubCadastro = new System.Windows.Forms.Panel();
            this.btnProduto = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnCadastro = new FontAwesome.Sharp.IconButton();
            this.panelLogoReset = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lblNameLog = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblPagAtualHome = new System.Windows.Forms.Label();
            this.iconPagAtual = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelSombraEsquerda = new System.Windows.Forms.Panel();
            this.panelSombraDecima = new System.Windows.Forms.Panel();
            this.panelDesingHome = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picHomeDesing = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSubCadastro.SuspendLayout();
            this.panelLogoReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPagAtual)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeDesing)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.btnVenda);
            this.panelMenu.Controls.Add(this.btnConsulta);
            this.panelMenu.Controls.Add(this.btnPedido);
            this.panelMenu.Controls.Add(this.panelSubCadastro);
            this.panelMenu.Controls.Add(this.btnCadastro);
            this.panelMenu.Controls.Add(this.panelLogoReset);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 635);
            this.panelMenu.TabIndex = 0;
            // 
            // btnVenda
            // 
            this.btnVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenda.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVenda.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenda.IconSize = 32;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(0, 530);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnVenda.Size = new System.Drawing.Size(214, 96);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click_1);
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
            this.btnConsulta.Location = new System.Drawing.Point(0, 434);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnConsulta.Size = new System.Drawing.Size(214, 96);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedido.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnPedido.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPedido.IconSize = 32;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 338);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnPedido.Size = new System.Drawing.Size(214, 96);
            this.btnPedido.TabIndex = 7;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // panelSubCadastro
            // 
            this.panelSubCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panelSubCadastro.Controls.Add(this.btnProduto);
            this.panelSubCadastro.Controls.Add(this.btnCliente);
            this.panelSubCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCadastro.Location = new System.Drawing.Point(0, 245);
            this.panelSubCadastro.Name = "panelSubCadastro";
            this.panelSubCadastro.Size = new System.Drawing.Size(214, 93);
            this.panelSubCadastro.TabIndex = 5;
            // 
            // btnProduto
            // 
            this.btnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProduto.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnProduto.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduto.IconSize = 32;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(0, 42);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.btnProduto.Size = new System.Drawing.Size(214, 42);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 32;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.btnCliente.Size = new System.Drawing.Size(214, 42);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastro.IconSize = 32;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 149);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnCadastro.Size = new System.Drawing.Size(214, 96);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click_1);
            // 
            // panelLogoReset
            // 
            this.panelLogoReset.Controls.Add(this.btnHome);
            this.panelLogoReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoReset.Location = new System.Drawing.Point(0, 0);
            this.panelLogoReset.Name = "panelLogoReset";
            this.panelLogoReset.Size = new System.Drawing.Size(214, 149);
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
            this.panelTitleBar.Controls.Add(this.picMinimize);
            this.panelTitleBar.Controls.Add(this.picLogout);
            this.panelTitleBar.Controls.Add(this.lblNameLog);
            this.panelTitleBar.Controls.Add(this.picUsuario);
            this.panelTitleBar.Controls.Add(this.picExit);
            this.panelTitleBar.Controls.Add(this.lblPagAtualHome);
            this.panelTitleBar.Controls.Add(this.iconPagAtual);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(903, 106);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // picMinimize
            // 
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(826, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(34, 28);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 3;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.pictureBox3_Click_2);
            // 
            // picLogout
            // 
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(850, 41);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(30, 42);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 7;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lblNameLog
            // 
            this.lblNameLog.AutoSize = true;
            this.lblNameLog.Font = new System.Drawing.Font("Yu Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameLog.Location = new System.Drawing.Point(764, 46);
            this.lblNameLog.Name = "lblNameLog";
            this.lblNameLog.Size = new System.Drawing.Size(64, 33);
            this.lblNameLog.TabIndex = 6;
            this.lblNameLog.Text = "joao";
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(689, 40);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(51, 42);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 4;
            this.picUsuario.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(866, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(34, 28);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPagAtualHome
            // 
            this.lblPagAtualHome.AutoSize = true;
            this.lblPagAtualHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagAtualHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPagAtualHome.Location = new System.Drawing.Point(47, 37);
            this.lblPagAtualHome.Name = "lblPagAtualHome";
            this.lblPagAtualHome.Size = new System.Drawing.Size(81, 29);
            this.lblPagAtualHome.TabIndex = 1;
            this.lblPagAtualHome.Text = "Home";
            // 
            // iconPagAtual
            // 
            this.iconPagAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconPagAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPagAtual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPagAtual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPagAtual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagAtual.IconSize = 50;
            this.iconPagAtual.Location = new System.Drawing.Point(0, 29);
            this.iconPagAtual.Name = "iconPagAtual";
            this.iconPagAtual.Size = new System.Drawing.Size(50, 50);
            this.iconPagAtual.TabIndex = 0;
            this.iconPagAtual.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Controls.Add(this.panelSombraEsquerda);
            this.panelDesktop.Controls.Add(this.panelSombraDecima);
            this.panelDesktop.Controls.Add(this.panelDesingHome);
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.lblTime);
            this.panelDesktop.Controls.Add(this.picHomeDesing);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(214, 106);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(903, 529);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // panelSombraEsquerda
            // 
            this.panelSombraEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSombraEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSombraEsquerda.Location = new System.Drawing.Point(0, 8);
            this.panelSombraEsquerda.Name = "panelSombraEsquerda";
            this.panelSombraEsquerda.Size = new System.Drawing.Size(8, 521);
            this.panelSombraEsquerda.TabIndex = 6;
            // 
            // panelSombraDecima
            // 
            this.panelSombraDecima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSombraDecima.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombraDecima.Location = new System.Drawing.Point(0, 0);
            this.panelSombraDecima.Name = "panelSombraDecima";
            this.panelSombraDecima.Size = new System.Drawing.Size(903, 8);
            this.panelSombraDecima.TabIndex = 5;
            // 
            // panelDesingHome
            // 
            this.panelDesingHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelDesingHome.Location = new System.Drawing.Point(288, 341);
            this.panelDesingHome.Name = "panelDesingHome";
            this.panelDesingHome.Size = new System.Drawing.Size(318, 2);
            this.panelDesingHome.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDate.Location = new System.Drawing.Point(286, 343);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(324, 33);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "terça-feira, 08 dez de 2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Yu Gothic Light", 23.77358F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTime.Location = new System.Drawing.Point(373, 300);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(152, 45);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHomeDesing
            // 
            this.picHomeDesing.Image = ((System.Drawing.Image)(resources.GetObject("picHomeDesing.Image")));
            this.picHomeDesing.Location = new System.Drawing.Point(372, 113);
            this.picHomeDesing.Name = "picHomeDesing";
            this.picHomeDesing.Size = new System.Drawing.Size(143, 172);
            this.picHomeDesing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHomeDesing.TabIndex = 1;
            this.picHomeDesing.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 635);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubCadastro.ResumeLayout(false);
            this.panelLogoReset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPagAtual)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeDesing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogoReset;
        private FontAwesome.Sharp.IconButton btnCadastro;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconPagAtual;
        private System.Windows.Forms.Label lblPagAtualHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picHomeDesing;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelDesingHome;
        private System.Windows.Forms.Label lblNameLog;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Panel panelSombraDecima;
        private System.Windows.Forms.Panel panelSombraEsquerda;
        private System.Windows.Forms.Panel panelSubCadastro;
        private FontAwesome.Sharp.IconButton btnProduto;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnPedido;
        private FontAwesome.Sharp.IconButton btnVenda;
        private FontAwesome.Sharp.IconButton btnConsulta;
    }
}