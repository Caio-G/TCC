using System.Collections;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class Relatorio : Form
    {
        public ArrayList MeuEstoque;
        public Produto xProduto = new Produto();
        public Relatorio()
        {
            InitializeComponent();
            CarregaGrid("Nome");
        }
        private void CarregaGrid(string ordem)
        {
            XElement CriaArray = XElement.Load("Produtos.xml");// Carregando os dados dos produtos, armazenados em xml
            MeuEstoque = new ArrayList();

            var Consulta = from A in CriaArray.Elements("Produto")
                           orderby (string)A.Element(ordem)
                           select new
                           {
                               Codigo = (string)A.Element("Codigo"),
                               Nome = (string)A.Element("Nome"),
                               Categoria = (string)A.Element("Categoria"),
                               Marca = (string)A.Element("Marca"),
                               CodCat = (string)A.Element("CodCat"),
                               Preço = (double)A.Element("Preço"),
                               QntEst = (int)A.Element("QntEst"),
                               QntRep = (int)A.Element("QntRep"),
                               QntVendas = (int)A.Element("QntVend"),
                               Ganhos = (double)A.Element("Ganhos")

                           };


            foreach (var a in Consulta)
            {
                xProduto = new Produto();
                xProduto.Codigo = a.Codigo;
                xProduto.Nome = a.Nome;
                xProduto.Categoria = a.Categoria;
                xProduto.CodCat = a.CodCat;
                xProduto.Preço = a.Preço;
                xProduto.QntEstoque = a.QntEst;
                xProduto.QntRep = a.QntRep;
                xProduto.Marca = a.Marca;
                xProduto.QntVend = a.QntVendas;
                xProduto.Ganho = a.Ganhos;
                MeuEstoque.Add(xProduto);
            }

            dgvRelatorio.DataSource = null;
            dgvRelatorio.DataSource = MeuEstoque;

            dgvRelatorio.ClearSelection();

            dgvRelatorio.Columns[8].DefaultCellStyle.Format = "C2";
            dgvRelatorio.Columns[9].DefaultCellStyle.Format = "C2";
        }
    }
}
