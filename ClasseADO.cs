using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Rideau
{
    internal class ClasseADO
    {
        public ClasseADO()
        { }

        public SqlConnection ConnexionBase()
        {
            string ChConnexion = "Server = localhost; Database = RideauConf; User Id = sa; Password = Azertysio-01";
            SqlConnection connexion = new SqlConnection(ChConnexion);
            connexion.Open();

            return connexion;
        }
    }
}
