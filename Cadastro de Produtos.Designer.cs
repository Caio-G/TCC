namespace Trabalho_Final_POO
{
    partial class Cadastro_de_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Produtos));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreço = new System.Windows.Forms.Label();
            this.lblQuantidaeEstoque = new System.Windows.Forms.Label();
            this.lblQuantidadeMinRep = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtQntEstoque = new System.Windows.Forms.TextBox();
            this.txtQntMin = new System.Windows.Forms.TextBox();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(468, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(131, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo do Produto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(468, 39);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Location = new System.Drawing.Point(131, 87);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(35, 13);
            this.lblPreço.TabIndex = 3;
            this.lblPreço.Text = "Preço";
            // 
            // lblQuantidaeEstoque
            // 
            this.lblQuantidaeEstoque.AutoSize = true;
            this.lblQuantidaeEstoque.Location = new System.Drawing.Point(131, 61);
            this.lblQuantidaeEstoque.Name = "lblQuantidaeEstoque";
            this.lblQuantidaeEstoque.Size = new System.Drawing.Size(121, 13);
            this.lblQuantidaeEstoque.TabIndex = 4;
            this.lblQuantidaeEstoque.Text = "Quantidade em Estoque";
            // 
            // lblQuantidadeMinRep
            // 
            this.lblQuantidadeMinRep.AutoSize = true;
            this.lblQuantidadeMinRep.Location = new System.Drawing.Point(468, 65);
            this.lblQuantidadeMinRep.Name = "lblQuantidadeMinRep";
            this.lblQuantidadeMinRep.Size = new System.Drawing.Size(176, 13);
            this.lblQuantidadeMinRep.TabIndex = 5;
            this.lblQuantidadeMinRep.Text = "Quantidade Minima para Reposição";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(131, 39);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 9;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(362, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(362, 32);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 10;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // txtQntEstoque
            // 
            this.txtQntEstoque.Location = new System.Drawing.Point(12, 58);
            this.txtQntEstoque.Name = "txtQntEstoque";
            this.txtQntEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtQntEstoque.TabIndex = 11;
            this.txtQntEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntEstoque_KeyPress);
            // 
            // txtQntMin
            // 
            this.txtQntMin.Location = new System.Drawing.Point(362, 58);
            this.txtQntMin.Name = "txtQntMin";
            this.txtQntMin.Size = new System.Drawing.Size(100, 20);
            this.txtQntMin.TabIndex = 12;
            this.txtQntMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntMin_KeyPress);
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(12, 84);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(100, 20);
            this.txtPreço.TabIndex = 13;
            this.txtPreço.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreço_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(325, 118);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(212, 32);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastro_de_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(651, 162);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.txtQntMin);
            this.Controls.Add(this.txtQntEstoque);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblQuantidadeMinRep);
            this.Controls.Add(this.lblQuantidaeEstoque);
            this.Controls.Add(this.lblPreço);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_de_Produtos";
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.Label lblQuantidaeEstoque;
        private System.Windows.Forms.Label lblQuantidadeMinRep;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtQntEstoque;
        private System.Windows.Forms.TextBox txtQntMin;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.Button btnCadastrar;
    }
}