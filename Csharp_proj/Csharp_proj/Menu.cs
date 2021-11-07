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
            Console.WriteLine("1 -Cadastrar Leitora(O)");
            Console.WriteLine("2 -Cadastrar Livro");
            Console.WriteLine("3 -Cadastrar Revista");
            Console.WriteLine("4 -Fazer um Concessão");
            Console.WriteLine("5 -Exibir Cadastro Leitora");
            Console.WriteLine("S -Para Sair ");
            Console.WriteLine("Escolha uma opção:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}

