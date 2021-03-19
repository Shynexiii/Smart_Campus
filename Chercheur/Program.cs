using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IGestionProduction;
using System.Collections;

namespace Chercheur
{
    static class Program
    {
        public static IGestionProd objProduction;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChannelServices.RegisterChannel(new TcpChannel(), false);
            objProduction = (IGestionProd)Activator.GetObject(typeof(IGestionProd), "tcp://localhost:1236/IGestionProduction");

            Application.Run(new Form1());
        }
    }
}
