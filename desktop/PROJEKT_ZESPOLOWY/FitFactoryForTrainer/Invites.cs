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
            gridRefresh();       
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(inviteView.SelectedRows.Count > 0)
            {
                int rowNumber = int.Parse(inviteView.SelectedCells[0].RowIndex.ToString());
                string inviteId = inviteView[0, rowNumber].Value.ToString();
                db.confirmInvite(inviteId);
                gridRefresh();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

        private void gridRefresh()
        {
            inviteView.DataSource = db.showInvites();
        }

    }
}
