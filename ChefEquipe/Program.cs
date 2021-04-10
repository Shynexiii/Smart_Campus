using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace ChefEquipe
{
    static class Program
    {
        public static IGestionEquipe.IGestionEquipe objEquipe;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChannelServices.RegisterChannel(new TcpChannel(), false);
            objEquipe = (IGestionEquipe.IGestionEquipe)Activator.GetObject(typeof(IGestionEquipe.IGestionEquipe), "tcp://localhost:1235/IGestionEquipe");

            IDictionary value = new Hashtable();
            value["port"] = "1236";
            value["name"] = "GestionProduction";
            ChannelServices.RegisterChannel(new TcpChannel(value, null, null), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(IGestionProdImpl), "IGestionProduction", WellKnownObjectMode.SingleCall);

            LoginFormChef loginFormChef = new LoginFormChef();

            Application.Run(loginFormChef);
            if (loginFormChef.UserSuccessfullyAuthenticated)
            {
                Application.Run(new Form1(LoginFormChef.user));
            }
        }
    }
}
