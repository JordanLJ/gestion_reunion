using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gTontine
{
    class ClasseGenerale
    {
    //    public static int gCodeAnnee;
    //    public static string glibelleAnnee;
        public static DataSet dsPrint = new DataSet();
        public static string gNomProjet;
        public static int gIdAssociation;
        public static int gIdTontine;
        //public static int gCodeUtilisateur;
        public static string gNomAssociation;
        public static string gNomTontine;
        public static string gNomEtatImpression;

        public static int gCodeUtilisateur;
        public static string gUtilisateurconnecte;
        public static string gNomEtat;


        public static void uniquement_entier(System.Windows.Forms.KeyPressEventArgs e)
        {
            

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
