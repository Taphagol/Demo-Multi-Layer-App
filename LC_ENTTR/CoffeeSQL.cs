using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_ENTTR
{
    public class CoffeeSQL
    {
        public static string SqlSelect(LC_ENT.CoffeeEntite criteres)
        {
       
            StringBuilder strSQL = new StringBuilder();

            strSQL.Append("SELECT *");
            strSQL.Append(" FROM ");
            strSQL.Append(CoffeeTable.NomTable );
            strSQL.Append(" WHERE type ");
            strSQL.Append(" = ");
            strSQL.Append("@type");
            return strSQL.ToString(); 
        }

        
    }
}
