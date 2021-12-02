using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Concessao
    {
        private string codleitora;
        private string nomeleitora;
        private string dataconcessao;
        private string duracao;
        private string descricao;
        private string multa;

        public string Codleitora
        {
            get
            {
                return codleitora;
            }

            set
            {
                codleitora = value;
            }
        }

        public string Nome_leitora
        {
            get
            {
                return nomeleitora;
            }

            set
            {
                nomeleitora = value;
            }
        }

        public string Data_concessao
        {
            get
            {
                return dataconcessao;
            }

            set
            {
                dataconcessao = value;
            }
        }

        public string Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                duracao = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Multa
        {
            get
            {
                return multa;
            }

            set
            {
                multa = value;
            }

        }

        public Concessao()
        {

        }


        public Concessao(string codleitora, string nomeleitora, string dataconcessao, string duracao, string descricao, string multa)
        {
            this.dataconcessao = dataconcessao;
            this.codleitora = codleitora;
            this.nomeleitora = nomeleitora;
            this.descricao = descricao;
            this.multa = multa;
        }

        public void cadastrarConcessao()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Informe o código da leitora");
                this.codleitora = Console.ReadLine();

                Console.WriteLine("Informe o nome da leitora");
                this.nomeleitora = Console.ReadLine();

                Console.WriteLine("Informe a data da concessão");
                this.dataconcessao = Console.ReadLine();

                Console.WriteLine("Informe o valor da multa");
                this.multa = Console.ReadLine();

                Console.WriteLine("Digite a descrição do livro deseja escolher");
                this.descricao = Console.ReadLine();

                Console.WriteLine("Informe a duração da concessão");
                this.duracao = Console.ReadLine();

                string sql = "insert into concessao values (@codleitora,@nome_leitora,@dataconcessao,@multa,@descricao,@duracao)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@codleitora", this.codleitora);
                cmd.Parameters.AddWithValue("@nome_leitora", this.nomeleitora);
                cmd.Parameters.AddWithValue("@dataconcessao", this.dataconcessao);
                cmd.Parameters.AddWithValue("@multa", this.multa);
                cmd.Parameters.AddWithValue("@descricao", this.descricao);
                cmd.Parameters.AddWithValue("@duracao", this.duracao);
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

        public void mostrarCadastroConcessao()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                string sqlselect = "select * from concessao";

                MySqlCommand cmd2 = new MySqlCommand(sqlselect, conexao);

                cmd2.CommandText = sqlselect;
                MySqlDataReader resultado = cmd2.ExecuteReader();


                while (resultado.Read())
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("codleitora:" + resultado["codleitora"]);
                    Console.WriteLine("nomeleitora:" + resultado["nomeleitora"]);
                    Console.WriteLine("dataconcessao:" + resultado["dataconcessao"]);
                    Console.WriteLine("multa:" + resultado["multa"]);
                    Console.WriteLine("descricao:" + resultado["descricao"]);
                    Console.WriteLine("duracao:" + resultado["duracao"]);

                }


                Console.WriteLine("Cadastro efetuada com sucesso ! Pressione qualquer tecla para sair");

                Console.ReadLine();
                conexao.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Nao foi possivel conectar ao banco de dados");
                Console.WriteLine("Entre em contato com o administrador tel:11 999999");
            }
        }
        public void deletarCadastroConcessao()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=proj;uid=root;password=");
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado com sucesso !");

                Console.WriteLine("Digite o código da leitora que deseja exluir a concessão");
                this.codleitora = Console.ReadLine();

                string sqldelete = "delete from concessao where codleitora=@codleitora";

                MySqlCommand cmd2 = new MySqlCommand(sqldelete, conexao);
                cmd2.Parameters.AddWithValue("@codleitora", this.codleitora);
                cmd2.CommandText = sqldelete;
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Concessão deletada com sucesso ! Pressione qualquer tecla para sair");

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