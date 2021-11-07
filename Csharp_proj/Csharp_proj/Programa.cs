using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Programa
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            Leitora leitora = new Leitora();
            do
            {
                opcao = menu.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Leitora(O)");
                        leitora.cadastrarLeitora();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Cadastrar Livro");
                        Livro livro = new Livro();
                        livro.cadastrarLivro();
                        break;

                    case "3":
                        Console.WriteLine("Cadastrar Revista");
                        Revista Revista = new Revista();
                        Revista.cadastrarRevista();
                        break;

                    case "4":
                        Console.WriteLine("Fazer uma Concessão");
                        Concessao concessao = new Concessao();
                        concessao.cadastrarConcessao();
                        break;

                    case "5":
                        leitora.mostrarLeitora();
                        Console.ReadKey();
                        break;

                    case "S":
                        Console.WriteLine("Fechando o programa");
                        break;

                    default:
                        Console.WriteLine("Opção incorreta!");
                        break;

                }
            } while (opcao != "S");
        }

    }
}
