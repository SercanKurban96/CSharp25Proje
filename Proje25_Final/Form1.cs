using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje25_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu eğitim bana gerçekten çok şey kattı. Daha önceden C# ve SQL bilgilerim sayesinde Öğrenci Sınav Not Kayıt Sistemi projesinden başlayarak finale kadar geldiğim bu müfredattaki tüm projeleri uygulayarak bilgi birikimimi daha da arttırmış oldum. Eğitim boyunca vermiş olduğu ödevlerle daha da pekiştirmemi sağladığı için Sayın Murat Yücedağ'a çok teşekkür ederim.", "TEŞEKKÜRLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
