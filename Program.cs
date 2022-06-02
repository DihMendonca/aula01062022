using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace aula01062022
{
    class Program
    {


        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=des;uid=root;password=");
            try
            {
                conexao.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ocorreu um erro, fale com o pedro");
                Environment.Exit(0);
            }
            String sql = "select * from login";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
                {
                Console.WriteLine("Lista de Login");
                while (rdr.Read()) ;
            } else
            {

                Console.WriteLine("Sem dados para exibição");
                Console.Write();
                Console.Write();
            }
            Console.ReadKey();

                }
            }

   }
    
