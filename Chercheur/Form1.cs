using IGestionLabo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chercheur
{
    public partial class Form1 : Form
    {
        public static IGestionLabo.Chercheur Chercheur;
        public Form1(IGestionLabo.Chercheur chercheur)
        {
            InitializeComponent();
            Chercheur = chercheur;
        }

        private void BtnProduction_Click(object sender, EventArgs e)
        {
            productionScientifique1.AfficherProduction();
        }
    }
}
