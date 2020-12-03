
namespace Tela_de_Splash.Forms
{
    partial class Pedido
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCdPedido = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblFormadePagamento = new System.Windows.Forms.Label();
            this.rdDebito = new System.Windows.Forms.RadioButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.cmbVezes = new System.Windows.Forms.ComboBox();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lblCdPedido
            // 
            this.lblCdPedido.AutoSize = true;
            this.lblCdPedido.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdPedido.Location = new System.Drawing.Point(141, 90);
            this.lblCdPedido.Name = "lblCdPedido";
            this.lblCdPedido.Size = new System.Drawing.Size(201, 31);
            this.lblCdPedido.TabIndex = 2;
            this.lblCdPedido.Text = "Código Pedido:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(351, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 3);
            this.panel2.TabIndex = 17;
            // 
            // txtCdPedido
            // 
            this.txtCdPedido.BackColor = System.Drawing.SystemColors.Control;
            this.txtCdPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCdPedido.Font = new System.Drawing.Font("Yu Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdPedido.Location = new System.Drawing.Point(360, 93);
            this.txtCdPedido.Name = "txtCdPedido";
            this.txtCdPedido.Size = new System.Drawing.Size(54, 34);
            this.txtCdPedido.TabIndex = 1;
            this.txtCdPedido.Text = "724";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(635, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 31);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data";
            // 
            // txtBanco
            // 
            this.txtBanco.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBanco.Location = new System.Drawing.Point(149, 152);
            this.txtBanco.Multiline = true;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.ReadOnly = true;
            this.txtBanco.Size = new System.Drawing.Size(561, 151);
            this.txtBanco.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel5.Location = new System.Drawing.Point(650, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 3);
            this.panel5.TabIndex = 24;
            // 
            // txtCompra
            // 
            this.txtCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompra.Font = new System.Drawing.Font("Yu Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.Location = new System.Drawing.Point(659, 328);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(54, 34);
            this.txtCompra.TabIndex = 2;
            this.txtCompra.Text = "724";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(443, 325);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(201, 31);
            this.lblTotalCompra.TabIndex = 22;
            this.lblTotalCompra.Text = "Total Crompra:";
            // 
            // lblFormadePagamento
            // 
            this.lblFormadePagamento.AutoSize = true;
            this.lblFormadePagamento.Font = new System.Drawing.Font("Verdana", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormadePagamento.Location = new System.Drawing.Point(141, 324);
            this.lblFormadePagamento.Name = "lblFormadePagamento";
            this.lblFormadePagamento.Size = new System.Drawing.Size(281, 31);
            this.lblFormadePagamento.TabIndex = 25;
            this.lblFormadePagamento.Text = "Forma de Pagamento";
            // 
            // rdDebito
            // 
            this.rdDebito.AutoSize = true;
            this.rdDebito.Font = new System.Drawing.Font("Verdana", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDebito.Location = new System.Drawing.Point(193, 363);
            this.rdDebito.Name = "rdDebito";
            this.rdDebito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdDebito.Size = new System.Drawing.Size(99, 29);
            this.rdDebito.TabIndex = 3;
            this.rdDebito.TabStop = true;
            this.rdDebito.Text = "Débito";
            this.rdDebito.UseVisualStyleBackColor = true;
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Font = new System.Drawing.Font("Verdana", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCredito.Location = new System.Drawing.Point(315, 363);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdCredito.Size = new System.Drawing.Size(107, 29);
            this.rdCredito.TabIndex = 4;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Crédito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // cmbVezes
            // 
            this.cmbVezes.FormattingEnabled = true;
            this.cmbVezes.Location = new System.Drawing.Point(308, 398);
            this.cmbVezes.Name = "cmbVezes";
            this.cmbVezes.Size = new System.Drawing.Size(121, 21);
            this.cmbVezes.TabIndex = 29;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_WOC3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_WOC3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Verdana", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC3.Location = new System.Drawing.Point(605, 381);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(114, 53);
            this.button_WOC3.TabIndex = 6;
            this.button_WOC3.Text = "Realizar Venda";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 486);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.cmbVezes);
            this.Controls.Add(this.rdCredito);
            this.Controls.Add(this.rdDebito);
            this.Controls.Add(this.lblFormadePagamento);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCdPedido);
            this.Controls.Add(this.lblCdPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCdPedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblFormadePagamento;
        private System.Windows.Forms.RadioButton rdDebito;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.ComboBox cmbVezes;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
    }
}