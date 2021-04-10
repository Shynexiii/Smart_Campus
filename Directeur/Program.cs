using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace Directeur
{
    static class Program
    {
        public static IGestionLabo.IGestionLabo obj;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChannelServices.RegisterChannel(new TcpChannel(), false);
            obj = (IGestionLabo.IGestionLabo)Activator.GetObject(typeof(IGestionLabo.IGestionLabo), "tcp://localhost:1234/IGestionLabo");

            IDictionary value = new Hashtable();
            value["port"] = "1235";
            value["name"] = "GestionEquipe";
            ChannelServices.RegisterChannel(new TcpChannel(value,null,null), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(IGestionEquipeImpl), "IGestionEquipe", WellKnownObjectMode.SingleCall);

            LoginFormDir loginFormDir = new LoginFormDir();

            Application.Run(loginFormDir);
            if (loginFormDir.UserSuccessfullyAuthenticated)
            {
                Application.Run(new Form1(loginFormDir.user));
            }

        }
    }
}
