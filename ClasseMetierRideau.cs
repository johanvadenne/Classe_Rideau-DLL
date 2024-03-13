namespace Classe_Rideau
{
    public class ClasseMetierRideau
    {
        // Données saisies et calculées
        private decimal LargeurFenetre;


        // Données SQL
        private decimal CoefOurlet;
        private decimal CoutHoraire;
        private decimal TempsTravailMetre;
        private decimal LargeurTissu;
        private decimal PrixTissu1;
        private decimal PrixTissu2;
        private decimal PrixTissu3;
        private decimal HauteurFenetre;
        private decimal AmpleurFenetre;
        private int NumTissu;
        private int NumModele;

         // instancier la classe d'accès aux données
        ClasseADO BdRideau = new ClasseADO();
        // instancier la classe d'accès à la table "TISSU"
        ClasseTissu TableTissu = new ClasseTissu();
        // instancier la classe d'accès à la table "MODELE"
        ClasseModele TableModele = new ClasseModele();

        // Constructeur
        public ClasseMetierRideau()
        {
            CoefOurlet = 0;
            CoutHoraire = 0;
            TempsTravailMetre = 0;
            LargeurTissu = 0;
            PrixTissu1 = 0;
            PrixTissu2 = 0;
            PrixTissu3 = 0;
        }

        // Constructeur
        public ClasseMetier(decimal LargeurFenetre, decimal HauteurFenetre, decimal AmpleurFenetre, int NumTissu, int NumModele)
        {
            this.LargeurFenetre = LargeurFenetre;
            this.HauteurFenetre = HauteurFenetre;
            this.AmpleurFenetre = AmpleurFenetre;
            this.NumTissu = NumTissu;
            this.NumModele = NumModele;

            // Rechercher CoefOurlet dans la Base
            CoefOurlet = TableTissu.CoefOurlet(this.NumTissu);
            // Rechercher CoutHoraire dans la Base
            CoutHoraire = … A compléter
               // Rechercher TempsTravailMetre dans la Base
            TempsTravailMetre = … A compléter
              // Rechercher les prix des tissus dans la Base
            PrixTissu1 = TableTissu.PrixTissu(NumTissu, 1);
            PrixTissu2 = TableTissu.PrixTissu(NumTissu, 2);
            PrixTissu3 = TableTissu.PrixTissu(NumTissu, 3);
            // Rechercher la largeur des tissus dans la Base
            LargeurTissu = … A compléter
     }

        public decimal NbHauteur()
        {
            return Math.Round((LargeurFenetre * AmpleurFenetre) / LargeurTissu);
        }

        public decimal Metrage()
        {
            // Voir fonction CoefOurlet dans la classeADO --> table TISSU 
            return //… A compléter
        }

        public decimal SurfaceUtile()
        {
            return //… A compléter
        }

        public decimal SurfaceChute()
        {
            return //… A compléter
        }

        public decimal TempsTravail()
        {
            return //… A compléter
        }

        public decimal CoutFacon()
        {
            return //… A compléter
        }

        public decimal CoutTissu()
        {
            // ??? appeler la méthode avec tous les paramètres ou utiliser une propriété calculée (mise à jour par la méthode)
            if (Metrage() < 5)
                return Metrage() * this.PrixTissu1;
            else
            {
                if (Metrage() < 10)
                    return Metrage() * this.PrixTissu2;
                else
                    return Metrage() * this.PrixTissu3;
            }
        }

        public decimal CoutTotal()
        {
            return //… A compléter
        }

    }
}
