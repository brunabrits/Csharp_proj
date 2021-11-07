using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_proj
{
    class Leitora
    {

        private string nome;
        private double CPF;
        private string endereco;         
        private double telefone;
        private string email;

        public void cadastrarLeitora()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF");
            CPF = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("CPF:{0}", CPF);
            Console.WriteLine("Endereço:{0}", endereco);
            Console.WriteLine("Telefone:{0}", telefone);
            Console.WriteLine("Email:{0}", email);
        }

        public string nomeleitora()
        {
            return nome;
        }


    }

}