using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Revista : Livro
    {
       public string frequencia;
       public string orientacao_politica;
    }
    public override void cadastrarLivro()
    {
        Console.WriteLine("-- Cadastro Revista --");
        base.cadastrarLivro();

        Console.WriteLine("Digite a frequência semanal");
        frequencia = Console.ReadLine();

        Console.WriteLine("Digite a orientação política");
        orientacao_politica = Console.ReadLine();

    }
}
