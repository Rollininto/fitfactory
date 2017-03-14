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
        private DataBase db = DataBase.GetInstance();
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
            usersView.DataSource = db.ShowUsers();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void btnShowWorkout_Click(object sender, EventArgs e)
        {
            if (usersView.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)usersView.DataSource;
                int rowNumber = int.Parse(usersView.SelectedCells[0].RowIndex.ToString());
                DataRow r = dt.Rows[rowNumber];
                string programId = r["id_progr"].ToString();
                WorkoutsWindow ww = new WorkoutsWindow(programId);
                //this.Hide();
                ww.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego użytkownika.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(usersView.SelectedRows.Count>0)
            {
                DataTable dt = (DataTable)usersView.DataSource;
                int rowNumber = int.Parse(usersView.SelectedCells[0].RowIndex.ToString());
                DataRow r = dt.Rows[rowNumber];
                int programId = int.Parse(r["id_progr"].ToString());
                db.DeleteUser(programId);
                loadGrid();
                MessageBox.Show("Użytkownik został usunięty.");
            }
            else
            {
                MessageBox.Show("Nie wybrałeś żadnego użytkownika do usunięcia.");
            }
        }

        private void usersView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (usersView.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)usersView.DataSource;
                int rowNumber = int.Parse(usersView.SelectedCells[0].RowIndex.ToString());
                DataRow r = dt.Rows[rowNumber];
                string programId=r["id_progr"].ToString();
                WorkoutsWindow ww = new WorkoutsWindow(programId);
                //this.Hide();
                ww.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego użytkownika.");
            }
        }

        private void btnCommunicate_Click(object sender, EventArgs e)
        {
            if (usersView.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)usersView.DataSource;
                int rowNumber = int.Parse(usersView.SelectedCells[0].RowIndex.ToString());
                DataRow r = dt.Rows[rowNumber];
                string userLogin = r["login_uz"].ToString();
                int userId = db.GetUserId(userLogin);

                Messenger m = new Messenger(userId.ToString());
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego użytkownika.");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (usersView.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)usersView.DataSource;
                int rowNumber = int.Parse(usersView.SelectedCells[0].RowIndex.ToString());
                DataRow r = dt.Rows[rowNumber];
                string userLogin = r["login_uz"].ToString();
                int userId = db.GetUserId(userLogin);

                History h = new History(userId.ToString());
                this.Hide();
                h.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś żadnego użytkownika.");
            }
        }
    }
}
