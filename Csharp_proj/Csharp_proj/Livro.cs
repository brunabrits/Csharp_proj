using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Livro
    {
        private string nome;
        private string genero;
        private string autora;
        private string datalancamento;
        private string editora;
        private string codlivro;

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

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Autora
        {
            get
            {
                return autora;
            }

            set
            {
                autora = value;
            }
        }

        public string Datalancamento
        {
            get
            {
                return datalancamento;
            }

            set
            {
                datalancamento = value;
            }
        }

        public string Editora
        {
            get
            {
                return editora;
            }

            set
            {
                editora = value;
            }
        }

        public Livro()
        {

        }

        public Livro(string nome, string genero, string autora, string datalancamento, string editora, string codlivro)
        {
            this.nome = nome;
            this.genero = genero;
            this.autora = autora;
            this.datalancamento = datalancamento;
            this.editora = editora;
            this.codlivro = codlivro;
        }

        public Livro(string codlivro)
        {
            this.codlivro = codlivro;
        }

        public void cadastrarLivro()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Digite o nome");
                this.nome = Console.ReadLine();

                Console.WriteLine("Digite o Gênero");
                this.genero = Console.ReadLine();

                Console.WriteLine("Digite o nome da Autora(o)");
                this.autora = Console.ReadLine();

                Console.WriteLine("Digite o nome da Editora");
                this.editora = Console.ReadLine();

                Console.WriteLine("Digite a data de lançamento");
                this.datalancamento = Console.ReadLine();

                Console.WriteLine("Digite o código do livro");
                this.codlivro = Console.ReadLine();

                string sql = "insert into livro values (@nome,@genero,@autora,@editora,@datalancamento,@codlivro)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@genero", this.genero);
                cmd.Parameters.AddWithValue("@autora", this.autora);
                cmd.Parameters.AddWithValue("@editora", this.editora);
                cmd.Parameters.AddWithValue("@dataLancamento", this.datalancamento);
                cmd.Parameters.AddWithValue("@codlivro", this.codlivro);
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

        public void mostrarCadastroLivro()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                string sqlselect = "select * from livro";

                MySqlCommand cmd2 = new MySqlCommand(sqlselect, conexao);

                cmd2.CommandText = sqlselect;
                MySqlDataReader resultado = cmd2.ExecuteReader();


                while (resultado.Read())
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("nome:" + resultado["nome"]);
                    Console.WriteLine("genero:" + resultado["genero"]);
                    Console.WriteLine("autora:" + resultado["autora"]);
                    Console.WriteLine("editora:" + resultado["editora"]);
                    Console.WriteLine("datalancamento:" + resultado["datalancamento"]);
                    Console.WriteLine("codlivro:" + resultado["codlivro"]);

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
        public void deletarCadastroLivro()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Digite o código do livro que deseja exluir");
                this.codlivro = Console.ReadLine();

                string sqldelete = "delete from livro where codlivro=@codlivro";

                MySqlCommand cmd2 = new MySqlCommand(sqldelete, conexao);
                cmd2.Parameters.AddWithValue("@codlivro", this.codlivro);
                cmd2.CommandText = sqldelete;
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Cadastro do livro deletado com sucesso ! Pressione qualquer tecla para sair");

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