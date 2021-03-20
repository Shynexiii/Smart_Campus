using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace Administrateur
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDictionary value = new Hashtable();
            value["port"] = "1234";
            value["name"] = "GestionLabo";
            ChannelServices.RegisterChannel(new TcpChannel(value,null,null), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(IGestionLaboImpl), "IGestionLabo", WellKnownObjectMode.SingleCall);
            
            Login login = new Login();

            Application.Run(login);
            if (login.UserSuccessfullyAuthenticated)
            {
                Application.Run(new Form1(login.user));
            }
        }
    }
}
