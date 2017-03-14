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
    public partial class History : Form
    {
        private DataBase db = DataBase.GetInstance();
        private string rozmowca;
        public History(string rozmowca)
        {
            InitializeComponent();
            this.rozmowca = rozmowca;
            historyView.DataSource = db.GetHistoryMessages(rozmowca);
        }
    }
}
