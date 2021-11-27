using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Csharp_proj
{
    class MySqlcs
    {
        static void Main(string[] args)
        {
            string = sql;
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost; database=csharp_proj; uid=root" );
            try
            {
                conexao.Open();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Deu ruim mané");
                    }
             

            sql= "insert into login values ("
            Console.ReadKey();
        }
           
        }
    }

