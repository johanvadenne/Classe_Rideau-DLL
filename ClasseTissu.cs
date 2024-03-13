using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Rideau
{
    internal class ClasseTissu
    {
        // instancier la classe d'accès aux données
        ClasseADO BdRideau = new ClasseADO();

        // propriétés table client
        public string refTypeTissu { get; set; }
        public string nomTypeTissu { get; set; }
        public decimal largeurTypeTissu { get; set; }
        public decimal coefOurlet { get; set; }

        public ClasseTissu(string REFTYPETISSU, string NOMTYPETISSU, decimal LARGEURTYPETISSU, decimal COEFOURLET)
        {
            this.refTypeTissu = REFTYPETISSU;
            this.nomTypeTissu = NOMTYPETISSU;
            this.largeurTypeTissu = LARGEURTYPETISSU;
            this.coefOurlet = COEFOURLET;
        }

        public ClasseTissu()
        {
        }

        public Decimal CoefOurlet(int NumTissu)
        {
            SqlCommand sqlCmd = new SqlCommand("select COEFOURLET from TISSU " +
                            "where REFTYPETISSU=" + NumTissu, BdRideau.ConnexionBase());

            return (Decimal)sqlCmd.ExecuteScalar();
        }

        public DataTable SQLTissus()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM TISSU", BdRideau.ConnexionBase());

            DataTable DtTissus = new DataTable();
            DtTissus.Load(sqlCmd.ExecuteReader());

            return DtTissus;
        }

        public Decimal SQLLargeurTissu(int NumTissu)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT LARGEURTYPETISSU "+
                "FROM TISSU where REFTYPETISSU = " + NumTissu, BdRideau.ConnexionBase());

            return (Decimal)sqlCmd.ExecuteScalar();
        }

        public Decimal PrixTissu(int NumTissu, int NumPrixTissu)
        {
            SqlCommand sqlCmd = new SqlCommand("select PRIXTISSU from PRIX_TISSU " +
                                                  "where REFTYPETISSU = " + NumTissu +
                                                  " and NUMPRIXTISSU = " + NumPrixTissu, BdRideau.ConnexionBase());

            return (Decimal)sqlCmd.ExecuteScalar();
        }

    }
}
