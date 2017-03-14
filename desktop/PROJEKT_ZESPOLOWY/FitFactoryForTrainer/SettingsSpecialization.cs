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
    public partial class SettingsSpecialization : Form
    {
        private DataBase db = DataBase.GetInstance();
        public SettingsSpecialization()
        {
            InitializeComponent();
            allSpecView.DataSource = db.ExecuteStoredProcedure("Exec wypiszSpecjalizacje");
            mySpecView.DataSource = db.GetCoachSpecs();
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            if (allSpecView.SelectedRows.Count > 0)
            {
                int rowNumber = int.Parse(allSpecView.SelectedCells[0].RowIndex.ToString());
                string specId = allSpecView[0, rowNumber].Value.ToString();
                db.AddSpec(specId, "15/03/2012");
                gridRefresh();
            }
        }

        public void gridRefresh()
        {
            mySpecView.DataSource = db.GetCoachSpecs();
        }

        private void btnRemoveSpec_Click(object sender, EventArgs e)
        {
            if (mySpecView.SelectedRows.Count > 0)
            {
                int rowNumber = int.Parse(mySpecView.SelectedCells[0].RowIndex.ToString());
                string specId = mySpecView[0, rowNumber].Value.ToString();
                db.RemoveSpec(specId);
                gridRefresh();
            }
        }
    }
}
