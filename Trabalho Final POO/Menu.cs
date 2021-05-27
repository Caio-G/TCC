using System;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class FmrInicial : Form
    {
        public FmrInicial()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto para a tela de Cadastro e escondendo o Menu enquanto a tela está aberta
            Cadastro_de_Produtos xCadastro = new Cadastro_de_Produtos();
            this.Hide();
            xCadastro.ShowDialog();
            this.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto para a tela de Categoria e escondendo o Menu enquanto a tela está aberta
            Categorias xCategoria = new Categorias();
            this.Hide();
            xCategoria.ShowDialog();
            this.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto para a tela de Estoque e escondendo o Menu enquanto a tela está aberta
            Estoque xEstoque = new Estoque();
            this.Hide();
            xEstoque.ShowDialog();
            this.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto para a tela de Relatorio e escondendo o Menu enquanto a tela está aberta
            Relatorio xRelatorio = new Relatorio();
            this.Hide();
            xRelatorio.ShowDialog();
            this.Show();
        }
    }
}
