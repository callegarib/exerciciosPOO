using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace CalculadoraPrecos
{
    public class Loja
    {
        private string ConnectionString = "Data Source=nome_do_arquivo.db;Version=3;";

        public void MostrarProdutos()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Products";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Product: {reader["Name"]}, Price: {reader["Price"]}, Discount: {reader["DiscountPercentage"]}");
                        }
                    }
                }
            }
        }
    }
}
