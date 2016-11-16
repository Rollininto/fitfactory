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
    public partial class FitFactoryMain : Form
    {
        private DataBase db = DataBase.getInstance();
        public FitFactoryMain()
        {
            InitializeComponent();
            loadGrid();
        }

        private void btnInvites_Click(object sender, EventArgs e)
        {
            Invites inv = new Invites();
            inv.ShowDialog();
            loadGrid();
        }

        private void FitFactoryMain_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        public void loadGrid()
        {
            usersView.DataSource = db.showUsers();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }
    }
}
