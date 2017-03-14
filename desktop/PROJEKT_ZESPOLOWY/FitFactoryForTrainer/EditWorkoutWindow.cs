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
    public partial class EditWorkoutWindow : Form
    {
        private DataBase db = DataBase.GetInstance();
        private string workoutId;
        private DataTable exercisesTable;
        private int exerciseQueue;
        public EditWorkoutWindow(string workoutId)
        {
            InitializeComponent();
            exerciseQueue = 0;
            this.workoutId = workoutId;
            loadExcercises();
            loadWorkout();
        }

        public void loadExcercises()
        {
            exercisesView.DataSource = db.GetExercisesList();
        }

        private void btnAddExcercise_Click(object sender, EventArgs e)
        {
            int exerciseId;
            string intensity;
            if(exercisesView.Rows.Count>0 && exercisesView.SelectedRows.Count>0)
            {
                exerciseId = int.Parse(exercisesView.SelectedCells[0].Value.ToString());
                intensity = IntensityTb.Text;
                if(intensity!="")
                {
                    try
                    {
                        DataTable dt = db.InsertSingleExercise(exerciseId.ToString(), intensity, workoutId, (++exerciseQueue).ToString());
                        loadWorkout();
                        MessageBox.Show("Dodano ćwiczenie.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Nie udało się dodać ćwiczenia. " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Nie podałeś intesywności ćwiczenia.");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego ćwiczenia.");
            }
        }

        public void loadWorkout()
        {
            exerciseQueue = 0;
            workoutView.DataSource = db.GetWorkoutExercises(workoutId.ToString());
            exerciseQueue = workoutView.Rows.Count;
            workoutView.Refresh();
        }

        private void btnUsunCwiczenie_Click(object sender, EventArgs e)
        {
            if(workoutView.SelectedRows.Count>0)
            {
                int exerciseId = int.Parse(workoutView.SelectedCells[0].Value.ToString());
                int queueNumber = int.Parse(workoutView.SelectedCells[2].Value.ToString());
                db.DeleteWorkoutExercise(exerciseId, int.Parse(workoutId), queueNumber);
                loadWorkout();
                MessageBox.Show("Usunięto ćwiczenie.");
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego ćwiczenia do usunięcia.");
            }
        }

        public void ColorGrid()
        {
            DataTable dt = (DataTable)workoutView.DataSource;
            for (int i = 0; i < workoutView.Rows.Count; i++)
            {
                if ((Boolean)workoutView[3, i].Value == true)
                {
                    workoutView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    workoutView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            workoutView.Refresh();
        }

        private void workoutView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorGrid();
        }
    }
}
