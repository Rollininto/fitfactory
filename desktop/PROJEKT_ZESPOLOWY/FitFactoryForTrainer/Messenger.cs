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
    public partial class Messenger : Form
    {
        private DataBase db = DataBase.GetInstance();
        private string rozmowca;
        public Messenger(string rozmowca)
        {
            InitializeComponent();
            this.rozmowca = rozmowca;
            //Refresh();
        }


        private void Refresh()
        {
            messageView.DataSource = db.GetMessages(rozmowca);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(messageTb.Text != "")
            {
                db.SendMessage(rozmowca, messageTb.Text);
                messageTb.Clear();
            }
            else
            {
                MessageBox.Show("Nie możesz wysłac pustej wiadomości.");
            }
        }
    }
}
