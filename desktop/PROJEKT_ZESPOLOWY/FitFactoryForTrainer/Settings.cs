using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitFactoryForTrainer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            SettingsSpecialization ss = new SettingsSpecialization();
            this.Hide();
            ss.ShowDialog();
            this.Show();

        }
    }
}
