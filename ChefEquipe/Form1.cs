using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ChefEquipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            equipeChercheur1.Show();
        }

        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            equipeChercheur1.Show();
            new EquipeChercheur().AfficherChercheur();
        }
    }
}
