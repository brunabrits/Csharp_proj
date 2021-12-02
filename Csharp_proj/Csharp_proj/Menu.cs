using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Menu
    {
        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Leitora");
            Console.WriteLine("2 -Cadastrar Livro");
            Console.WriteLine("3 -Cadastrar uma Concessão");
            Console.WriteLine("4 -Exibir Cadastro Leitora");
            Console.WriteLine("5 -Exibir todos os Livros");
            Console.WriteLine("6 -Exibir todas as Concessões");
            Console.WriteLine("7 -Deletar cadastro leitora");
            Console.WriteLine("8 -Deletar cadastro livro");
            Console.WriteLine("9 -Deletar cadastro concessão");
            Console.WriteLine("S -Para Sair ");
            Console.WriteLine("Escolha uma opção:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}