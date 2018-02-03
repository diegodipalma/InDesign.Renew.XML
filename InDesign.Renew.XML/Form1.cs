using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InDesign.Renew.XML
{
    public partial class Form1 : Form
    {
        public const string CurrentVersion = "0.1b";
        public string CurrentOS = Environment.OSVersion.ToString();
        public object xmlOriginale, xmlModificato;
        public const string CommonInDesignPath = @"C:\Program Files\Adobe\Adobe InDesign CC 2018\AMT";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetCurrentCode_Click(object sender, EventArgs e)
        {
            // Deserializzo l'xml e ne faccio una copia per sicurezza.
            xmlOriginale = DeserializeXMLFileToObject<object>(Path.Combine(CommonInDesignPath, @"application.xml"));
            xmlModificato = xmlOriginale;


        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Quest'applicazione è stata realizzada da Diego Di Palma sotto licenza MIT.\n" +
                "Per ogni problema contattare lo sviluppatore via email (diegodipalma@outlook.com) o via Telegram " +
                $"(t.me/diegodipalma) indicando versione ({CurrentVersion}) e Sistema Operativo ({(CurrentOS)}).");

        private void aiutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Premere il pulsante \"Get current code\" per caricare in memoria il codice che si sta utilizzando;\n" +
                "2 - ");
        }

        public static T DeserializeXMLFileToObject<T>(string XmlFilename)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(XmlFilename)) return default(T);

            try
            {
                StreamReader xmlStream = new StreamReader(XmlFilename);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nel recuperare il file XML!");
            }
            return returnObject;
        }
    }
}
