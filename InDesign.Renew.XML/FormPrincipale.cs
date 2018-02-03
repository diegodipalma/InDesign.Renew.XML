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
using System.Xml;

namespace InDesign.Renew.XML
{
    public partial class FormPrincipale : Form
    {
        public const string CurrentVersion = "0.1b";
        public string CurrentOS = Environment.OSVersion.ToString();
        public const string CommonInDesignPath = @"C:\Program Files\Adobe\Adobe InDesign CC 2018\AMT";
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void btnGetCurrentCode_Click(object sender, EventArgs e)
        {
            XmlDocument docXML = new XmlDocument();
            docXML.Load(Path.Combine(CommonInDesignPath, "application.xml"));
            MessageBox.Show(docXML.SelectSingleNode("Configuration/Other/Data").Attributes["TrialSerialNumber"].ToString());
            docXML.Save(Path.Combine(CommonInDesignPath, "application.xml"));
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Quest'applicazione è stata realizzada da Diego Di Palma sotto licenza MIT.\n" +
                "Per ogni problema contattare lo sviluppatore via email (diegodipalma@outlook.com) o via Telegram " +
                $"(t.me/diegodipalma) indicando versione ({CurrentVersion}) e Sistema Operativo ({(CurrentOS)}).");

        private void aiutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Premere il pulsante \"Get current code\" per caricare in memoria il codice che si sta utilizzando;\n" +
                "2 - ");
        }
    }
}
