using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class Estoque : Form
    {
        public ArrayList MeuEstoque;
        public Produto xProduto = new Produto();
        public Estoque()
        {
            InitializeComponent();
            CarregaGrid("Nome");
        }
        private void CarregaGrid(string ordem)//Função para carregar o grid tendo como base uma variavel do tipo string
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
                               QntVendas=(int)A.Element("QntVend"),
                               Ganhos=(double)A.Element("Ganhos")
                               
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
                xProduto.QntVend = a.QntVendas;
                xProduto.Ganho = a.Ganhos;
                MeuEstoque.Add(xProduto);//Salvando em um array todos os produtos
            }

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = MeuEstoque;//Definindo a fonte de dados do grid como o array com os produtos

            dgvEstoque.ClearSelection();
            //Definindo o formato das colunas de preço e ganho para monetario de duas casas decimais
            dgvEstoque.Columns[8].DefaultCellStyle.Format = "C2";
            dgvEstoque.Columns[9].DefaultCellStyle.Format = "C2";
        }
        private void CarregaGridDouble(string ordem)//Função para carregar o grid tendo como base uma variavel do tipo double
        {
            XElement CriaArray = XElement.Load("Produtos.xml");
            MeuEstoque = new ArrayList();

            var Consulta = from A in CriaArray.Elements("Produto")
                           orderby (double)A.Element(ordem)
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

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = MeuEstoque;

            dgvEstoque.ClearSelection();

            dgvEstoque.Columns[8].DefaultCellStyle.Format = "C2";
            dgvEstoque.Columns[9].DefaultCellStyle.Format = "C2";
        }
        private void CarregaGridInt(string ordem)//Função para carregar o grid tendo como base uma variavel do tipo int
        {
            XElement CriaArray = XElement.Load("Produtos.xml");
            MeuEstoque = new ArrayList();

            var Consulta = from A in CriaArray.Elements("Produto")
                           orderby (int)A.Element(ordem)
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

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = MeuEstoque;

            dgvEstoque.ClearSelection();

            dgvEstoque.Columns[8].DefaultCellStyle.Format = "C2";
            dgvEstoque.Columns[9].DefaultCellStyle.Format = "C2";
        }

        private void ckboxCodigo_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pelo Codigo e desmarcar as outras checkbox
        {
            if (ckboxCodigo.Checked == true)
            {
                ckboxNome.Checked = false;
                ckboxCategoria.Checked = false;
                ckboxMarca.Checked = false;
                ckboxPreço.Checked = false;
                ckboxGanhos.Checked = false;
                CarregaGridInt("Codigo");
            }

        }

        private void ckboxNome_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pelo Nome e desmarcar as outras checkbox
        {
            if (ckboxNome.Checked == true)
            {
                ckboxCodigo.Checked = false;
                ckboxCategoria.Checked = false;
                ckboxMarca.Checked = false;
                ckboxPreço.Checked = false;
                ckboxGanhos.Checked = false;
                CarregaGrid("Nome");
            }
        }

        private void ckboxCategoria_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pela Categoria e desmarcar as outras checkbox
        {
            if (ckboxCategoria.Checked == true)
            {
                ckboxCodigo.Checked = false;
                ckboxNome.Checked = false;
                ckboxMarca.Checked = false;
                ckboxPreço.Checked = false;
                ckboxGanhos.Checked = false;
                CarregaGrid("Categoria");
            }
        }

        private void ckboxPreço_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pelo Preço e desmarcar as outras checkbox
        {
            if (ckboxPreço.Checked == true)
            {
                ckboxCodigo.Checked = false;
                ckboxCategoria.Checked = false;
                ckboxMarca.Checked = false;
                ckboxNome.Checked = false;
                ckboxGanhos.Checked = false;
                CarregaGridDouble("Preço");
            }
        }

        private void ckboxMarca_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pela Marca e desmarcar as outras checkbox
        {
            if (ckboxMarca.Checked == true)
            {
                ckboxCodigo.Checked = false;
                ckboxCategoria.Checked = false;
                ckboxNome.Checked = false;
                ckboxPreço.Checked = false;
                ckboxGanhos.Checked = false;
                CarregaGrid("Marca");
            }
        }

        private void ckboxGanhos_CheckedChanged(object sender, EventArgs e)//Muda a ordenação do Grid pelos Ganhos e desmarcar as outras checkbox
        {
            if (ckboxPreço.Checked == true)
            {
                ckboxCodigo.Checked = false;
                ckboxCategoria.Checked = false;
                ckboxMarca.Checked = false;
                ckboxNome.Checked = false;
                ckboxPreço.Checked = false;
                CarregaGridDouble("Ganhos");
            }
        }

        public void tsbtnProcurar_Click(object sender, EventArgs e)//Procura um item no estoque
        {
            string Nome = tstxtProcurar.Text;

            tstxtProcurar.Text = "";

            dgvEstoque.ClearSelection();

            for (int i = 0; i < dgvEstoque.RowCount; i++)
            {
                if (dgvEstoque.Rows[i].Cells[1].Value.ToString() == Nome)
                {
                    dgvEstoque.CurrentCell = dgvEstoque.Rows[i].Cells[1];
                }
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)//Adiciona a quantidade em estoque de um produto
        {
            int NovoEst;
            XElement Raiz = XElement.Load("Produtos.xml");
            var AlterarEstoque = from A in Raiz.Elements("Produto")
                                 where (((string)A.Element("Nome")).Equals(dgvEstoque.CurrentRow.Cells[1].Value) & ((string)A.Element("Codigo")).Equals(dgvEstoque.CurrentRow.Cells[0].Value))
                                 select A;


            if (AlterarEstoque.Count() != 0)
            {
                foreach (var x in AlterarEstoque)
                {
                    NovoEst = int.Parse(tstxtEstAdd.Text) + int.Parse(dgvEstoque.CurrentRow.Cells[5].Value.ToString());
                    x.SetElementValue("QntEst", NovoEst);
                }
                Raiz.Save("Produtos.xml");
            }
            if (ckboxCodigo.Checked == true)
                CarregaGridInt("Codigo");

            if (ckboxNome.Checked == true)
                CarregaGrid("Nome");

            if (ckboxCategoria.Checked == true)
                CarregaGrid("Categoria");

            if (ckboxPreço.Checked == true)
                CarregaGridDouble("Preço");

            if (ckboxMarca.Checked == true)
                CarregaGrid("Marca");

            if (ckboxGanhos.Checked == true)
                CarregaGridDouble("Ganhos");

            tstxtEstAdd.Clear();
        }

        private void tsbtnRem_Click(object sender, EventArgs e)//Diminui a quantidade em estoque de um produto
        {
            int NovoEst,NovaQntVend;
            double NovoGanho;
            XElement Raiz = XElement.Load("Produtos.xml");
            var AlterarEstoque = from A in Raiz.Elements("Produto")
                                 where (((string)A.Element("Nome")).Equals(dgvEstoque.CurrentRow.Cells[1].Value) & ((string)A.Element("Codigo")).Equals(dgvEstoque.CurrentRow.Cells[0].Value))
                                 select A;


            if (AlterarEstoque.Count() != 0)
            {
                foreach (var x in AlterarEstoque)
                {
                    NovoEst = int.Parse(dgvEstoque.CurrentRow.Cells[5].Value.ToString()) - int.Parse(tstxtEstSub.Text);
                    NovaQntVend = int.Parse(dgvEstoque.CurrentRow.Cells[7].Value.ToString()) + int.Parse(tstxtEstSub.Text);
                    NovoGanho = double.Parse(dgvEstoque.CurrentRow.Cells[9].Value.ToString()) + (NovaQntVend * double.Parse(dgvEstoque.CurrentRow.Cells[8].Value.ToString()));
                    if (NovoEst > 0)
                    {
                        x.SetElementValue("QntEst", NovoEst);
                        x.SetElementValue("QntVend", NovaQntVend);
                        x.SetElementValue("Ganhos", NovoGanho);
                    }
                    else
                    {
                        if (NovoEst == 0)
                        {
                            DialogResult Zerar = MessageBox.Show("Deseja remover este produto do estoque?", "Estoque Zerado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Zerar == DialogResult.No)
                            {
                                x.SetElementValue("QntEst", NovoEst);
                                x.SetElementValue("QntVend", NovaQntVend);
                                x.SetElementValue("Ganhos", NovoGanho);
                            }
                            else
                            {
                                if (Zerar == DialogResult.Yes)
                                {
                                    x.Element("Nome").Parent.Remove();
                                }
                            }
                        }
                        else
                        {
                            DialogResult Zerar = MessageBox.Show("Deseja remover este produto do estoque?", "Estoque Zerado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Zerar == DialogResult.No)
                            {
                                NovoEst = 0;
                                x.SetElementValue("QntEst", NovoEst);
                                x.SetElementValue("QntVend", NovaQntVend);
                                x.SetElementValue("Ganhos", NovoGanho);
                            }
                            else
                            {
                                if (Zerar == DialogResult.Yes)
                                {
                                    x.Element("Nome").Parent.Remove();
                                }
                            }
                        }
                    }
                }
                Raiz.Save("Produtos.xml");
            }
            if (ckboxCodigo.Checked == true)
                CarregaGridInt("Codigo");

            if (ckboxNome.Checked == true)
                CarregaGrid("Nome");

            if (ckboxCategoria.Checked == true)
                CarregaGrid("Categoria");

            if (ckboxPreço.Checked == true)
                CarregaGridDouble("Preço");

            if (ckboxMarca.Checked == true)
                CarregaGrid("Marca");

            if (ckboxGanhos.Checked == true)
                CarregaGridDouble("Ganhos");

            tstxtEstSub.Clear();
        }

        private void tstxtProcurar_KeyPress(object sender, KeyPressEventArgs e)//Configuração da tecla Enter na caixa de texto de procura
        {
            if (e.KeyChar == (char)Keys.Enter)
                tsbtnProcurar.PerformClick();
        }

        
    }
}
