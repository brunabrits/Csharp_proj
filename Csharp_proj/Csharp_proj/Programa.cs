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
            Livro livro = new Livro();
            Concessao concessao = new Concessao();
            do
            {
                opcao = menu.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Leitora");
                        leitora.cadastrarLeitora();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Cadastrar Livro");
                        livro.cadastrarLivro();
                        break;

                    case "3":
                        Console.WriteLine("Cadastrar uma Concessão");
                        concessao.cadastrarConcessao();
                        Console.ReadKey();
                        break;

                    case "4":
                        leitora.mostrarCadastroLeitora();
                        Console.ReadKey();
                        break;

                    case "5":
                        livro.mostrarCadastroLivro();
                        Console.ReadKey();
                        break;

                    case "6":
                        concessao.mostrarCadastroConcessao();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Deletar cadastro leitora");
                        leitora.deletarCadastroLeitora();
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Deletar cadastro livro");
                        livro.deletarCadastroLivro();
                        Console.ReadKey();
                        break;

                    case "9":
                        Console.WriteLine("Deletar cadastro concessão");
                        concessao.deletarCadastroConcessao();
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