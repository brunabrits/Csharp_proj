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
        private DateTime data_lancamento;
        private string editora;
    }

    public virtual void cadastrarLivro(){

        Console.WriteLine("Digite o nome");
        nome = Console.ReadLine();
        
        Console.WriteLine("Digite o Gênero");
        genero = Console.ReadLine();

        Console.WriteLine("Digite o nome do Autora(o)");
        autora = Console.ReadLine();

        data_lancamento = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        Console.WriteLine("Digite a data de Lançamento");

        Console.WriteLine("Digite o nome da Editora");
        editora = Console.ReadLine();
       
    }

}