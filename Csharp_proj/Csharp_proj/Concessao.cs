using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Concessao
    {
        public string nome_leitora;
        public DateTime data_inicial;
        public DateTime data_final;
        public double valor_total;
        public DateTime duracao;
        public string descricao;
        public double multa;


        public void cadastrarConcessao()
        {

            data_inicial = DateTime.Now;
            Console.WriteLine(data_inicial.Date);
            Console.WriteLine("Digite qual livro deseja escolher");
            descricao = Console.ReadLine();
        }

        public void cadastrarMulta()
        {
            Console.WriteLine("Informe o valor da multa");
            multa = double.Parse(Console.ReadLine());
            if (multa > 0)
            {

            }
            else
            {
                multa = 0;
            }
        }

        public void mostrarMulta()
        {
            Console.WriteLine("Total da Multa R${0}, total a pagar{1}", multa, valor_total);
        }

        public void mostrarTotal()
        {
            Console.WriteLine("Valor Total, concessao + multa : {0}", multa + valor_total);
        }

        public void registrarDevolucao()
        {
            data_final = DateTime.Now;
            Console.WriteLine(" Devolvido em{0}", data_final.Date);
        }

    }
}
