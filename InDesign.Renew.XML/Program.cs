using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDesign.Renew.XML
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex MutexDiControllo = new Mutex(false, "InDesign.Renew.XML.Mutex");
            try
            {
                if (MutexDiControllo.WaitOne(0, false))
                {
                    // Eseguo l'applicazione
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormPrincipale());
                }
                else
                {
                    MessageBox.Show($"Un'altra istanza dell'applicazione {AppDomain.CurrentDomain.FriendlyName} è in esecuzione.");
                }
            }
            finally
            {
                if (MutexDiControllo != null)
                {
                    MutexDiControllo.Close();
                    MutexDiControllo = null;
                }
            }
        }

    }
}
