using System;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Iniciando a tela de login
            FmrLogin x = new FmrLogin();
            Application.Run(x);
            // Testando se o login é valido e então iniciando o menu da aplicação
            if (x.log)
            {
                Application.Run(new FmrInicial());
            }
        }
    }
}
