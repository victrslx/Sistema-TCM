
namespace Tela_de_Splash.Forms
{
    partial class Produtos
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCatergoria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.lblDescri = new System.Windows.Forms.Label();
            this.btnCadastrar = new ePOSOne.btnProduct.Button_WOC();
            this.btnNovo = new ePOSOne.btnProduct.Button_WOC();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblcodprod = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategoria.Font = new System.Drawing.Font("Yu Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Consoles",
            "Periféricos",
            "Jogos"});
            this.cmbCategoria.Location = new System.Drawing.Point(263, 199);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(227, 35);
            this.cmbCategoria.TabIndex = 30;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(205, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 3);
            this.panel1.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Yu Gothic", 16.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(211, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(420, 39);
            this.txtNome.TabIndex = 40;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(112, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 31);
            this.lblNome.TabIndex = 41;
            this.lblNome.Text = "Nome:";
            // 
            // lblCatergoria
            // 
            this.lblCatergoria.AutoSize = true;
            this.lblCatergoria.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatergoria.Location = new System.Drawing.Point(112, 197);
            this.lblCatergoria.Name = "lblCatergoria";
            this.lblCatergoria.Size = new System.Drawing.Size(145, 31);
            this.lblCatergoria.TabIndex = 43;
            this.lblCatergoria.Text = "Categoria:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(257, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 3);
            this.panel2.TabIndex = 46;
            // 
            // txtDescri
            // 
            this.txtDescri.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescri.Font = new System.Drawing.Font("Yu Gothic", 16.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescri.Location = new System.Drawing.Point(263, 295);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(420, 39);
            this.txtDescri.TabIndex = 44;
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescri.Location = new System.Drawing.Point(112, 295);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(145, 31);
            this.lblDescri.TabIndex = 45;
            this.lblDescri.Text = "Descrição:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCadastrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(727, 407);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.Size = new System.Drawing.Size(130, 58);
            this.btnCadastrar.TabIndex = 48;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextColor = System.Drawing.Color.White;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNovo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(551, 407);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovo.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNovo.Size = new System.Drawing.Size(130, 58);
            this.btnNovo.TabIndex = 49;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextColor = System.Drawing.Color.White;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(44, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(217, 31);
            this.lblCodigo.TabIndex = 50;
            this.lblCodigo.Text = "Código Produto:";
            // 
            // lblcodprod
            // 
            this.lblcodprod.AutoSize = true;
            this.lblcodprod.Font = new System.Drawing.Font("Verdana", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodprod.Location = new System.Drawing.Point(267, 30);
            this.lblcodprod.Name = "lblcodprod";
            this.lblcodprod.Size = new System.Drawing.Size(0, 23);
            this.lblcodprod.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(659, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 3);
            this.panel3.TabIndex = 54;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Control;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Yu Gothic", 16.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(665, 201);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(47, 39);
            this.txtValor.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Valor:";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcodprod);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.lblCatergoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCatergoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.Label lblDescri;
        private ePOSOne.btnProduct.Button_WOC btnCadastrar;
        private ePOSOne.btnProduct.Button_WOC btnNovo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblcodprod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}