using DocumentationExemples.ApplicationServices;
using System.Windows.Forms;

namespace DocumentedExemple
{
    /// <summary>
    /// Formulaire d'affichage principal
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constucteur du Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            UtiliserMaClasse();
        }

        /// <summary>
        /// Utilisation de la classe de test
        /// </summary>
        private void UtiliserMaClasse()
        {
            Class1 maClasse = new Class1();
            maClasse.UtiliserFonction1(1, 2, 3);

        }

        /// <summary>
        /// Code executé au chargement du formulaire
        /// </summary>
        /// <param name="sender">Objet qui envoie le commande, généralement le "Form"</param>
        /// <param name="e">Paramètres envoyés en arguments</param>
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
