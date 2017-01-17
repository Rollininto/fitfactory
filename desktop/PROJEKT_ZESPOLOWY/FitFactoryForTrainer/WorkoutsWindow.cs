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
    public partial class WorkoutsWindow : Form
    {
        private string programId;
        private DataBase db;
        public WorkoutsWindow(string Id)
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            this.programId = Id;
            refreshWorkouts();           
        }

        public void refreshWorkouts()
        {
            DataTable dt = db.ShowWorkouts(programId);
            workoutsView.DataSource = dt;
        }

        public void ColorGrid()
        {
            DataTable dt = (DataTable)workoutsView.DataSource;
            for(int i =0;i<workoutsView.Rows.Count;i++)
            {
                if((Boolean)workoutsView[2,i].Value == true )
                {
                    workoutsView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    workoutsView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            workoutsView.Refresh();
        }

        private void workoutsView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorGrid();
        }

        private void workoutsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowNumber = int.Parse(workoutsView.SelectedCells[0].RowIndex.ToString());
                string workoutId = workoutsView[0, rowNumber].Value.ToString();
                EditWorkoutWindow eww = new EditWorkoutWindow(workoutId);
                this.Hide();
                eww.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się otworzyć treningu. " + ex.ToString());
            }
        }
    }
}
