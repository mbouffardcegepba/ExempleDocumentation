using DocumentationExemples.ApplicationServices;
using System.Windows.Forms;

namespace DocumentedExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UtiliserMaClasse();
        }

        private void UtiliserMaClasse()
        {
            Class1 maClasse = new Class1();
            maClasse.UtiliserFonction1(1, 2, 3);

        }
    }
}
