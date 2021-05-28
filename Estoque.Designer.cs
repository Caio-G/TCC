namespace Trabalho_Final_POO
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.ckboxCodigo = new System.Windows.Forms.CheckBox();
            this.ckboxNome = new System.Windows.Forms.CheckBox();
            this.ckboxCategoria = new System.Windows.Forms.CheckBox();
            this.ckboxPreço = new System.Windows.Forms.CheckBox();
            this.ckboxMarca = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstxtProcurar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstlblAdicionar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtEstAdd = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblSaida = new System.Windows.Forms.ToolStripLabel();
            this.tstxtEstSub = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnRem = new System.Windows.Forms.ToolStripButton();
            this.ckboxGanhos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 52);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(1045, 306);
            this.dgvEstoque.TabIndex = 0;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(7, 29);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(72, 13);
            this.lblOrdenar.TabIndex = 1;
            this.lblOrdenar.Text = "Ordenar por : ";
            // 
            // ckboxCodigo
            // 
            this.ckboxCodigo.AutoSize = true;
            this.ckboxCodigo.Location = new System.Drawing.Point(96, 29);
            this.ckboxCodigo.Name = "ckboxCodigo";
            this.ckboxCodigo.Size = new System.Drawing.Size(59, 17);
            this.ckboxCodigo.TabIndex = 2;
            this.ckboxCodigo.Text = "Codigo";
            this.ckboxCodigo.UseVisualStyleBackColor = true;
            this.ckboxCodigo.CheckedChanged += new System.EventHandler(this.ckboxCodigo_CheckedChanged);
            // 
            // ckboxNome
            // 
            this.ckboxNome.AutoSize = true;
            this.ckboxNome.Checked = true;
            this.ckboxNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckboxNome.Location = new System.Drawing.Point(182, 29);
            this.ckboxNome.Name = "ckboxNome";
            this.ckboxNome.Size = new System.Drawing.Size(54, 17);
            this.ckboxNome.TabIndex = 3;
            this.ckboxNome.Text = "Nome";
            this.ckboxNome.UseVisualStyleBackColor = true;
            this.ckboxNome.CheckedChanged += new System.EventHandler(this.ckboxNome_CheckedChanged);
            // 
            // ckboxCategoria
            // 
            this.ckboxCategoria.AutoSize = true;
            this.ckboxCategoria.Location = new System.Drawing.Point(268, 28);
            this.ckboxCategoria.Name = "ckboxCategoria";
            this.ckboxCategoria.Size = new System.Drawing.Size(71, 17);
            this.ckboxCategoria.TabIndex = 4;
            this.ckboxCategoria.Text = "Categoria";
            this.ckboxCategoria.UseVisualStyleBackColor = true;
            this.ckboxCategoria.CheckedChanged += new System.EventHandler(this.ckboxCategoria_CheckedChanged);
            // 
            // ckboxPreço
            // 
            this.ckboxPreço.AutoSize = true;
            this.ckboxPreço.Location = new System.Drawing.Point(354, 28);
            this.ckboxPreço.Name = "ckboxPreço";
            this.ckboxPreço.Size = new System.Drawing.Size(54, 17);
            this.ckboxPreço.TabIndex = 5;
            this.ckboxPreço.Text = "Preço";
            this.ckboxPreço.UseVisualStyleBackColor = true;
            this.ckboxPreço.CheckedChanged += new System.EventHandler(this.ckboxPreço_CheckedChanged);
            // 
            // ckboxMarca
            // 
            this.ckboxMarca.AutoSize = true;
            this.ckboxMarca.Location = new System.Drawing.Point(440, 29);
            this.ckboxMarca.Name = "ckboxMarca";
            this.ckboxMarca.Size = new System.Drawing.Size(56, 17);
            this.ckboxMarca.TabIndex = 6;
            this.ckboxMarca.Text = "Marca";
            this.ckboxMarca.UseVisualStyleBackColor = true;
            this.ckboxMarca.CheckedChanged += new System.EventHandler(this.ckboxMarca_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtProcurar,
            this.tsbtnProcurar,
            this.toolStripSeparator1,
            this.tstlblAdicionar,
            this.tstxtEstAdd,
            this.tsbtnAdd,
            this.toolStripSeparator2,
            this.tslblSaida,
            this.tstxtEstSub,
            this.tsbtnRem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstxtProcurar
            // 
            this.tstxtProcurar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtProcurar.Name = "tstxtProcurar";
            this.tstxtProcurar.Size = new System.Drawing.Size(100, 25);
            this.tstxtProcurar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxtProcurar_KeyPress);
            // 
            // tsbtnProcurar
            // 
            this.tsbtnProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProcurar.Image")));
            this.tsbtnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProcurar.Name = "tsbtnProcurar";
            this.tsbtnProcurar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnProcurar.Text = "Procura por Nome";
            this.tsbtnProcurar.Click += new System.EventHandler(this.tsbtnProcurar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstlblAdicionar
            // 
            this.tstlblAdicionar.Name = "tstlblAdicionar";
            this.tstlblAdicionar.Size = new System.Drawing.Size(114, 22);
            this.tstlblAdicionar.Text = "Entrada de Estoque :";
            // 
            // tstxtEstAdd
            // 
            this.tstxtEstAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtEstAdd.Name = "tstxtEstAdd";
            this.tstxtEstAdd.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdd.Text = "Adicionar quantidade ao estoque selecionado";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblSaida
            // 
            this.tslblSaida.Name = "tslblSaida";
            this.tslblSaida.Size = new System.Drawing.Size(102, 22);
            this.tslblSaida.Text = "Saída de Estoque :";
            // 
            // tstxtEstSub
            // 
            this.tstxtEstSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtEstSub.Name = "tstxtEstSub";
            this.tstxtEstSub.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnRem
            // 
            this.tsbtnRem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRem.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRem.Image")));
            this.tsbtnRem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRem.Name = "tsbtnRem";
            this.tsbtnRem.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRem.Text = "Retirar Quantidade ao estoque selecionado";
            this.tsbtnRem.Click += new System.EventHandler(this.tsbtnRem_Click);
            // 
            // ckboxGanhos
            // 
            this.ckboxGanhos.AutoSize = true;
            this.ckboxGanhos.Location = new System.Drawing.Point(525, 28);
            this.ckboxGanhos.Name = "ckboxGanhos";
            this.ckboxGanhos.Size = new System.Drawing.Size(63, 17);
            this.ckboxGanhos.TabIndex = 8;
            this.ckboxGanhos.Text = "Ganhos";
            this.ckboxGanhos.UseVisualStyleBackColor = true;
            this.ckboxGanhos.CheckedChanged += new System.EventHandler(this.ckboxGanhos_CheckedChanged);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1048, 358);
            this.Controls.Add(this.ckboxGanhos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ckboxMarca);
            this.Controls.Add(this.ckboxPreço);
            this.Controls.Add(this.ckboxCategoria);
            this.Controls.Add(this.ckboxNome);
            this.Controls.Add(this.ckboxCodigo);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.dgvEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.ShowInTaskbar = false;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.CheckBox ckboxCodigo;
        private System.Windows.Forms.CheckBox ckboxNome;
        private System.Windows.Forms.CheckBox ckboxCategoria;
        private System.Windows.Forms.CheckBox ckboxPreço;
        private System.Windows.Forms.CheckBox ckboxMarca;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnProcurar;
        private System.Windows.Forms.ToolStripTextBox tstxtProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tstlblAdicionar;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripTextBox tstxtEstAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslblSaida;
        private System.Windows.Forms.ToolStripTextBox tstxtEstSub;
        private System.Windows.Forms.ToolStripButton tsbtnRem;
        private System.Windows.Forms.CheckBox ckboxGanhos;
    }
}