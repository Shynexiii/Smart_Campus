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
using IGestionLabo;

namespace Administrateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chercheurView1.Show();
            equipeView1.Hide();
            try
            {
                TcpChannel tcpChannel = new TcpChannel(1234);
                ChannelServices.RegisterChannel(tcpChannel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(IGestionLaboImpl), "IGestionLabo", WellKnownObjectMode.SingleCall);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheurView1.Show();
            equipeView1.Hide();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Show();
        }
    }
}
