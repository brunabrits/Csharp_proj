using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Leitora
    {
        private string nome;
        private string cpf;
        private string endereco;
        private string email;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public Leitora()
        {

        }

        public Leitora(string nome, string cpf, string endereco, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.email = email;
        }

        public void cadastrarLeitora()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Digite seu nome");
                this.nome = Console.ReadLine();

                Console.WriteLine("Digite o CPF");
                this.cpf = Console.ReadLine();

                Console.WriteLine("Digite o seu endereço");
                this.endereco = Console.ReadLine();

                Console.WriteLine("Digite o email");
                this.email = Console.ReadLine();

                string sql = "insert into leitora values (@nome,@cpf,@endereco,@email)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@endereco", this.endereco);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Cadastro efetuado com sucesso ! Pressione qualquer tecla para sair");

                Console.ReadLine();
                conexao.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }

        }

        public void mostrarCadastroLeitora()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                string sqlselect = "select * from leitora";

                MySqlCommand cmd2 = new MySqlCommand(sqlselect, conexao);

                cmd2.CommandText = sqlselect;
                MySqlDataReader resultado = cmd2.ExecuteReader();


                while (resultado.Read())
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("cpf:" + resultado["cpf"]);
                    Console.WriteLine("nome:" + resultado["nome"]);
                    Console.WriteLine("endereco:" + resultado["endereco"]);
                    Console.WriteLine("email:" + resultado["email"]);

                }


                Console.WriteLine("Listagem efetuada com sucesso ! Pressione qualquer tecla para sair");

                Console.ReadLine();
                conexao.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }
        }
        public void deletarCadastroLeitora()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Digite o CPF que deseja exluir");
                this.cpf = Console.ReadLine();

                string sqldelete = "delete from leitora where cpf=@cpf";

                MySqlCommand cmd2 = new MySqlCommand(sqldelete, conexao);
                cmd2.Parameters.AddWithValue("@cpf", this.cpf);
                cmd2.CommandText = sqldelete;
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Cadastro da leitora deletado com sucesso ! Pressione qualquer tecla para sair");

                Console.ReadLine();
                conexao.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }

        }
    }
}