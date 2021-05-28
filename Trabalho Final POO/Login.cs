using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabalho_Final_POO
{
    public partial class FmrLogin : Form
    {
        // Variável que validará o login
        // Teste Teste Teste Teste Teste Teste Teste
        //Teste2
        public bool log = false;
        public FmrLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                List<Usuario> Logins = new List<Usuario>();
                con = new SqlConnection();
                con.ConnectionString = "Data Source=loginserv.cfyt3lwwnz1m.sa-east-1.rds.amazonaws.com;Initial Catalog=TCC;User ID=admin;Password=adminadmin";
                SqlCommand cmd = new SqlCommand("spGetAllUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure; // Informando que o comando spGetAllUsuário é um Stored Procedure
                con.Open(); //Conectando ao banco de dados
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //Adicionando todos os usuário cadastrados em uma Lista
                {
                    Usuario Usuario = new Usuario();
                    Usuario.Login = rdr["Login"].ToString().ToLower();
                    Usuario.Senha = rdr["Senha"].ToString().ToLower();
                    Logins.Add(Usuario);
                }
                if (Logins.Exists(x => (x.Login == txtUser.Text.ToLower() && x.Senha == txtSenha.Text.ToLower()))) // Verificando se o Login e Senha digitados estão entre os cadastrados
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Login Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);//Caso usuário esteja cadstrado e a senha informada estiver correta
                    this.log = true;
                    this.Close();

                }
                else if (Logins.Exists(x => (x.Login == txtUser.Text.ToLower() && x.Senha != txtSenha.Text.ToLower())))
                {
                    MessageBox.Show("Senha Inconrreta!", "Falha de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);//Caso usuário esteja cadstrado mas a senha informada não estiver correta
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado!", "Falha de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);//Caso usuário não esteja cadstrado
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());//Mensagem de erro, caso algum ocorra durante a conexão
            }
        }
    }
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
