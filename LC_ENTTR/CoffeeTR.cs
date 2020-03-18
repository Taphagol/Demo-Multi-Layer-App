using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC_ENT;

namespace LC_ENTTR
{
    public class CoffeeTR
    {
       
          
        public SqlParameter EssayerCreerParametresSQL(string nomParametre, object value)
        {

            SqlParameter parameter = null;


            switch (nomParametre)
            {
                case CoffeeTable.NomColId:
                    parameter = new SqlParameter();
                    parameter.ParameterName = string.Format(":{0}", nomParametre);
                    parameter.DbType = DbType.Int64;
                    parameter.Value = value;
                    break;
                case CoffeeTable.NomColName:
                    parameter = new SqlParameter();
                    parameter.ParameterName = string.Format(":{0}", nomParametre);
                    parameter.DbType = DbType.String;
                    parameter.Value = value;
                    break;
                case CoffeeTable.NomColType:
                    parameter = new SqlParameter();
                    parameter.ParameterName = string.Format(":{0}", nomParametre);
                    parameter.DbType = DbType.String;
                    parameter.Value = value;
                    break;
                case CoffeeTable.NomColPrice:
                    parameter = new SqlParameter();
                    parameter.ParameterName = string.Format(":{0}", nomParametre);
                    parameter.DbType = DbType.Int64;
                    parameter.Value = value;

                    break;
            }

            return parameter;

        }

        public SqlParameter CreerParametreSQL(string nomParametre, object value)
        {

            SqlParameter parameter = null;

            parameter = EssayerCreerParametresSQL(nomParametre, value);


            if ((parameter == null))
            {
                switch (nomParametre)
                {

                    case CoffeeTable.NomColId:
                        parameter = new SqlParameter();
                        parameter.ParameterName = string.Format(":{0}", nomParametre);
                        parameter.DbType = DbType.Int64;
                        parameter.Value = value;
                        break;
                    case CoffeeTable.NomColName:
                        parameter = new SqlParameter();
                        parameter.ParameterName = string.Format(":{0} ", nomParametre);
                        parameter.DbType = DbType.String;
                        parameter.Value = value;

                        break;
                    case CoffeeTable.NomColType:
                        parameter = new SqlParameter();
                        parameter.ParameterName = string.Format(":{0}", nomParametre);
                        parameter.DbType = DbType.String;
                        parameter.Value = value;
                        break;
                    case CoffeeTable.NomColPrice:
                        parameter = new SqlParameter();
                        parameter.ParameterName = string.Format(":{0}", nomParametre);
                        parameter.DbType = DbType.Int64;
                        parameter.Value = value;
                        break;
                    
                    default:

                        throw new ArgumentException("Nom du paramètre (" + nomParametre + ") inconnu.");
                }
            }
            return parameter;

        }

        public static CoffeeEntite GetCoffeeByType(string coffeeType)
        {
            CoffeeEntite retour = new CoffeeEntite();
            string query = string.Format("SELECT * FROM coffee WHERE type LIKE '{0}'", coffeeType);

            try
            {
                ConnectionClass.conn.Open();
                ConnectionClass.command.CommandText = query;
                SqlDataReader reader = ConnectionClass.command.ExecuteReader();

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
                ConnectionClass.conn.Close();
            }

            return retour ;
        }

        public static List<LC_ENT.CoffeeEntite> RechercherTP(LC_ENT.CoffeeEntite criteres)
        {

            string requeteSQL = string.Empty;
            requeteSQL = CoffeeSQL.SqlSelect(criteres); 

            //OracleParameter[] parametre = CreerParametreSQL(criteres)  AjouterParametreOraclePourRechercher(criteres).ToArray;

            List<LC_ENT.CoffeeEntite> retour = new List<LC_ENT.CoffeeEntite>();

            //IDataReader dr = AgentServiceXD.ExecuteReader(requeteSQL, parametre);

            try
            {
                      
                ConnectionClass.command.CommandText = requeteSQL;
                ConnectionClass.command.Parameters.AddWithValue("@type", criteres.Type);
                ConnectionClass.conn.Open();
                SqlDataReader dr = ConnectionClass.command.ExecuteReader();


                while (dr.Read())
                {
                    LC_ENT.CoffeeEntite RepRechTP = new LC_ENT.CoffeeEntite();

                    RepRechTP.Id = dr.GetInt32(0);
                    RepRechTP.Name = dr.GetString(1);
                    RepRechTP.Type = dr.GetString(2);
                    RepRechTP.Price = dr.GetDouble(3);

                    retour.Add(RepRechTP);
                }
            }
            finally 
            {
                ConnectionClass.conn.Close();
            }

            return retour;

        }


    }


    
}
