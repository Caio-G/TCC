using System.Collections;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class Categorias : Form
    {
        public Produto xProduto;
        public ArrayList MeusProdutos = new ArrayList();
        public ArrayList MinhasCat = new ArrayList();
        public Categorias()
        {
            InitializeComponent();
            XElement CriaArray = XElement.Load("Produtos.xml");// Carregando os dados dos produtos, armazenados em xml

            var Consulta = from A in CriaArray.Elements("Produto")
                           select new
                           {
                               Codigo = (string)A.Element("Codigo"),
                               Nome = (string)A.Element("Nome"),
                               Categoria = (string)A.Element("Categoria"),
                               CodCat=(string)A.Element("CodCat"),
                               Preço = (double)A.Element("Preço"),
                               QntEst = (int)A.Element("QntEst"),
                               QntRep = (int)A.Element("QntRep"),
                               Marca = (string)A.Element("Marca"),
                               QntVend=(int)A.Element("QntVend"),
                               Ganho=(double)A.Element("Ganhos")

                           };


            foreach (var a in Consulta)//Passando as informações do xml para um objeto
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
                xProduto.QntVend = a.QntVend;
                xProduto.Ganho = a.Ganho;
                MeusProdutos.Add(xProduto);//Salvando em um array todos os produtos
            }
            foreach (Produto x in MeusProdutos)
            {
                //Coletando as categorias diferentes entre os produtos
                int cont = 0;
                Produto z = new Produto();
                if (MinhasCat.Count == 0)//A categoria do primeiro produto sempre será adicionada no array
                {
                    MinhasCat.Add(x);
                }
                else
                {
                    foreach (Produto y in MinhasCat)//A partir do segundo produto serão adicionadas somentes categorias que já não estejam presentes no array
                    {
                        if ((y.Codigo!=x.Codigo) & (y.Categoria == x.Categoria))
                        {
                            cont++;
                        }
                    }
                    if (cont == 0)
                        MinhasCat.Add(x);
                }
            }
                    if (MinhasCat.Count!=0)
                CarregaGrid();//Chamando a função para carregar o grid preenchido
        }
        private void CarregaGrid()
        {
            dgvCat.DataSource = null;
            dgvCat.DataSource = MinhasCat;//Definindo a fonte de dados do grid como o array com as categorias
            
            dgvCat.ClearSelection();
            
            //Deixando visiveis apenas colunas de Categoria e Codigo da Categoria
            dgvCat.Columns[0].Visible = false;
            dgvCat.Columns[1].Visible = false;
            dgvCat.Columns[2].Visible = false;
            dgvCat.Columns[5].Visible = false;
            dgvCat.Columns[6].Visible = false;
            dgvCat.Columns[7].Visible = false;
            dgvCat.Columns[8].Visible = false;
            dgvCat.Columns[9].Visible = false;
        }
        
    }
}
