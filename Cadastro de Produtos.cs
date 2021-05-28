using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class Cadastro_de_Produtos : Form
    {
        public Produto yProduto;
        public ArrayList MeusProdutos = new ArrayList();
        public ArrayList CodCat = new ArrayList();
        XElement Prod = XElement.Load("Produtos.xml");// Carregando os dados dos produtos, armazenados em xml
        public Cadastro_de_Produtos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Passando as informações inseridas para um objeto Produto
            yProduto = new Produto();
            yProduto.Codigo = txtCodigo.Text;
            yProduto.Nome = txtNome.Text;
            yProduto.Marca = txtMarca.Text;
            yProduto.Categoria = txtCategoria.Text;
            yProduto.GeraCodCat(CodCat);
            yProduto.QntEstoque = int.Parse(txtQntEstoque.Text);
            yProduto.QntRep = int.Parse(txtQntMin.Text);
            yProduto.Preço = double.Parse(txtPreço.Text);
            //Criando um novo elemento XML com as informações
            XElement NovoProduto = new XElement("Produto",
                new XElement("Codigo", yProduto.Codigo),
                new XElement("Nome", yProduto.Nome),
                new XElement("Marca", yProduto.Marca),
                new XElement("Categoria", yProduto.Categoria),
                new XElement("CodCat",yProduto.CodCat),
                new XElement("QntEst", yProduto.QntEstoque),
                new XElement("QntRep", yProduto.QntRep),
                new XElement("QntVend", yProduto.QntVend),
                new XElement("Preço", yProduto.Preço),
                new XElement("Ganhos", yProduto.Ganho));

            MeusProdutos.Add(NovoProduto); //Adicionando o Elemento criado a um array
            CodCat.Add(yProduto);
            
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                txtCodigo.Clear();
                txtNome.Clear();
                txtMarca.Clear();
                txtCategoria.Clear();
                txtQntEstoque.Clear();
                txtQntMin.Clear();
                txtPreço.Clear();
            }
            else
            {
                if (confirm == DialogResult.No)
                {
                    Prod.Add(MeusProdutos);
                    Prod.Save("Produtos.xml");
                    this.Close();
                }
            }

            txtCodigo.Focus();
        }

        //Definindo algumas interações com teclado
        #region Interações Teclado 
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtNome.Focus();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtCategoria.Focus();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtQntEstoque.Focus();
        }

        private void txtQntEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtQntMin.Focus();
        }

        private void txtQntMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtPreço.Focus();
        }

        private void txtPreço_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
                txtCodigo.Focus();
            if (e.KeyChar == (char)Keys.Enter)
                btnCadastrar.PerformClick();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                txtNome.Focus();
        }
        #endregion
    }
}
