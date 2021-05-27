using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Trabalho_Final_POO
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string CodCat { get; set; }
        public int QntEstoque { get; set; }
        public int QntRep { get; set; }
        public int QntVend { get; set; }
        public double Preço { get; set; }
        public double Ganho { get; set; }
        
        public Produto()
        {
            Codigo = "";
            Nome = "";
            Categoria = "";
            CodCat = "";
            Preço = 0;
            QntEstoque = 0;
            QntRep = 0;
            Marca = "";
            QntVend = 0;
            Ganho = 0;
        }
        public void GeraCodCat(ArrayList b)
        {
            int Cont = 0;
            string ArmazenaCod = "";

            foreach (Produto x in b)
            {
                if (Categoria == x.Categoria)
                {
                    Cont++;
                    ArmazenaCod = x.CodCat;
                }
            }
            if (Cont > 0)
                CodCat = ArmazenaCod;
            else
            {
                int x;
                x = DateTime.Now.Year * DateTime.Now.Month * DateTime.Now.Day * DateTime.Now.Hour * DateTime.Now.Minute * DateTime.Now.Second;
                CodCat = x.ToString();
            }
        }
    }
}
