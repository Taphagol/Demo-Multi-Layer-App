using LC_ENT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_ENTTR
{
    public class ConnectionClass
    {
        public static SqlConnection conn;
        public static SqlCommand command;

        public SqlConnection ConnectionSQL { get; set; }
        public SqlCommand CommandeSQL { get; set; }


        static ConnectionClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["coffeeConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }


       
        public static CoffeeEntite GetCoffeeByType(string coffeeType)
        {
            CoffeeEntite retour = new CoffeeEntite();
            string query = string.Format("SELECT * FROM coffee WHERE type LIKE '{0}'", coffeeType);

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string type = reader.GetString(2);
                    double price = reader.GetDouble(3);

                    retour.Id = id;
                    retour.Name = name;
                    retour.Type = type;
                    retour.Price = price;
 
                    //CoffeeEntite coffee = new CoffeeEntite(id, name, type, price);
                    //list.Add(coffee);
                }
            }
            finally
            {
                conn.Close();
            }

            return retour ;
        }

    }
}
