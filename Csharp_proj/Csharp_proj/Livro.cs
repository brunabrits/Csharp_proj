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

    public virtual void cadastrarLivro()
    {
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

    public virtual void visualizarLivro()
    {
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Gênero: {0}", genero);
        Console.WriteLine("Autora: {0}", autora);
        Console.WriteLine("Data de Lançamento: {0}", data_lancamento.Year);
        Console.WriteLine("Editora: {0}", editora);
    }

}