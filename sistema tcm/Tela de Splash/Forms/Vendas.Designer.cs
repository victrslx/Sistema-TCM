
namespace Tela_de_Splash
{
    partial class Vendas
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
            this.lblCdPedido = new System.Windows.Forms.Label();
            this.lblCdProduto = new System.Windows.Forms.Label();
            this.lblNmProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCdCliente = new System.Windows.Forms.Label();
            this.lblcodvendas = new System.Windows.Forms.Label();
            this.btnInserir = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCdPedido
            // 
            this.lblCdPedido.AutoSize = true;
            this.lblCdPedido.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdPedido.Location = new System.Drawing.Point(95, 37);
            this.lblCdPedido.Name = "lblCdPedido";
            this.lblCdPedido.Size = new System.Drawing.Size(210, 31);
            this.lblCdPedido.TabIndex = 1;
            this.lblCdPedido.Text = "Código Vendas:";
            // 
            // lblCdProduto
            // 
            this.lblCdProduto.AutoSize = true;
            this.lblCdProduto.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdProduto.Location = new System.Drawing.Point(95, 94);
            this.lblCdProduto.Name = "lblCdProduto";
            this.lblCdProduto.Size = new System.Drawing.Size(257, 31);
            this.lblCdProduto.TabIndex = 3;
            this.lblCdProduto.Text = "Código do Produto:";
            // 
            // lblNmProduto
            // 
            this.lblNmProduto.AutoSize = true;
            this.lblNmProduto.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmProduto.Location = new System.Drawing.Point(95, 157);
            this.lblNmProduto.Name = "lblNmProduto";
            this.lblNmProduto.Size = new System.Drawing.Size(234, 31);
            this.lblNmProduto.TabIndex = 5;
            this.lblNmProduto.Text = "Nome do Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(95, 227);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(88, 31);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(246, 227);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(170, 31);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(474, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 31);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total da compra:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel7.Location = new System.Drawing.Point(412, 254);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 3);
            this.panel7.TabIndex = 30;
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtquantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquantidade.Font = new System.Drawing.Font("Yu Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(414, 230);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(54, 34);
            this.txtquantidade.TabIndex = 29;
            this.txtquantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantidade.TextChanged += new System.EventHandler(this.txtquantidade_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(356, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 3);
            this.panel3.TabIndex = 36;
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.SystemColors.Control;
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProd.Font = new System.Drawing.Font("Yu Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(358, 97);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(54, 34);
            this.txtProd.TabIndex = 35;
            this.txtProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProd.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // dgvvendas
            // 
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendas.Location = new System.Drawing.Point(101, 270);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.RowHeadersWidth = 45;
            this.dgvvendas.Size = new System.Drawing.Size(520, 150);
            this.dgvvendas.TabIndex = 39;
            this.dgvvendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellContentClick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(503, 100);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(227, 31);
            this.lblData.TabIndex = 47;
            this.lblData.Text = "Data da compra:";
            // 
            // mskData
            // 
            this.mskData.BackColor = System.Drawing.SystemColors.Control;
            this.mskData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData.Location = new System.Drawing.Point(725, 103);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(126, 28);
            this.mskData.TabIndex = 46;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(353, 163);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(0, 25);
            this.lblNomeProd.TabIndex = 48;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(180, 233);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(0, 25);
            this.lblValor1.TabIndex = 49;
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(557, 234);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(0, 25);
            this.lblTotal1.TabIndex = 50;
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(327, 434);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(0, 25);
            this.lblTotalGeral.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Código Cliente:";
            // 
            // lblCdCliente
            // 
            this.lblCdCliente.AutoSize = true;
            this.lblCdCliente.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdCliente.Location = new System.Drawing.Point(721, 43);
            this.lblCdCliente.Name = "lblCdCliente";
            this.lblCdCliente.Size = new System.Drawing.Size(0, 25);
            this.lblCdCliente.TabIndex = 54;
            // 
            // lblcodvendas
            // 
            this.lblcodvendas.AutoSize = true;
            this.lblcodvendas.Font = new System.Drawing.Font("Yu Gothic", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodvendas.Location = new System.Drawing.Point(311, 43);
            this.lblcodvendas.Name = "lblcodvendas";
            this.lblcodvendas.Size = new System.Drawing.Size(0, 25);
            this.lblcodvendas.TabIndex = 55;
            // 
            // btnInserir
            // 
            this.btnInserir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInserir.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserir.Location = new System.Drawing.Point(672, 283);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInserir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInserir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInserir.Size = new System.Drawing.Size(106, 50);
            this.btnInserir.TabIndex = 26;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextColor = System.Drawing.Color.White;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Verdana", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC2.Location = new System.Drawing.Point(672, 359);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(106, 50);
            this.button_WOC2.TabIndex = 25;
            this.button_WOC2.Text = "Novo";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 486);
            this.Controls.Add(this.lblcodvendas);
            this.Controls.Add(this.lblCdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.dgvvendas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNmProduto);
            this.Controls.Add(this.lblCdProduto);
            this.Controls.Add(this.lblCdPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCdPedido;
        private System.Windows.Forms.Label lblCdProduto;
        private System.Windows.Forms.Label lblNmProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC btnInserir;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCdCliente;
        private System.Windows.Forms.Label lblcodvendas;
    }
}