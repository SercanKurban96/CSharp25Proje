using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proje22_RssTest
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RSSBasliklariGetir(string link)
        {
            lstBasliklar.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    lstBasliklar.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            //lstBasliklar.Items.Clear();
            //XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            //while (xmloku.Read())
            //{
            //    if (xmloku.Name == "title")
            //    {
            //        lstBasliklar.Items.Add(xmloku.ReadString());
            //    }
            //}

            RSSBasliklariGetir("https://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            //lstBasliklar.Items.Clear();
            //XmlTextReader xmloku = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/gundem.xml");
            //while (xmloku.Read())
            //{
            //    if (xmloku.Name == "title")
            //    {
            //        lstBasliklar.Items.Add(xmloku.ReadString());
            //    }
            //}

            RSSBasliklariGetir("https://www.milliyet.com.tr/rss/rssnew/gundem.xml");
        }

        private void btnFotomac_Click(object sender, EventArgs e)
        {
            //lstBasliklar.Items.Clear();
            //XmlTextReader xmloku = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            //while (xmloku.Read())
            //{
            //    if (xmloku.Name == "title")
            //    {
            //        lstBasliklar.Items.Add(xmloku.ReadString());
            //    }
            //}

            RSSBasliklariGetir("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }
    }
}
