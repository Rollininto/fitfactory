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
    public partial class Invites : Form
    {
        private DataBase db;
        public Invites()
        {
            InitializeComponent();
            db = DataBase.getInstance();
            inviteView.DataSource = db.showInvites();        
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }
    }
}
