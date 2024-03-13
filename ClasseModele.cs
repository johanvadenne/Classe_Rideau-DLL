using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Rideau
{
    internal class ClasseModele
    {
        // instancier la classe d'accès aux données
        ClasseADO BdRideau = new ClasseADO();

        public ClasseModele()
        {

        }

        public DataTable SQLModeles()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM MODELE_RIDEAU", BdRideau.ConnexionBase());

            DataTable DtModeles = new DataTable();
            DtModeles.Load(sqlCmd.ExecuteReader());

            return DtModeles;
        }

        public Decimal TempsTravailMetre(int NumModele)
        {
            SqlCommand sqlCmd = new SqlCommand("select TEMPSMODELE from MODELE_RIDEAU " +
                       "where MODELE_RIDEAU.NUMMODELE =" + NumModele, BdRideau.ConnexionBase());

            return (Decimal)sqlCmd.ExecuteScalar();
        }

        public Decimal CoutHoraire(int NumModele)
        {
            SqlCommand sqlCmd = new SqlCommand("select COUTFACON from FACON, MODELE_RIDEAU " +
                                           "where FACON.CODEFACON = MODELE_RIDEAU.CODEFACON " +
                                             "and MODELE_RIDEAU.NUMMODELE =" + NumModele, BdRideau.ConnexionBase());

            return (Decimal)sqlCmd.ExecuteScalar();
        }

    }
}
