using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenPharm_Click(object sender, EventArgs e)
        {
            Form formApteka = new Аптеки();
            formApteka.Show();
        }

        private void buttonOpenMedicine_Click(object sender, EventArgs e)
        {
            Form formMed = new Лекарства();
            formMed.Show();
        }

        private void buttonOpenNal_Click(object sender, EventArgs e)
        {
            Form formNal = new Наличие();
            formNal.Show();
        }
    }
}
