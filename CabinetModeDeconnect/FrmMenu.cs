using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CabinetModeDeconnect
{
    public partial class FrmMenu : Form
    {

        private void AfficherFenetre(Form f)
        {
            SContainer.Panel2.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.SContainer.Panel2.Controls.Add(f);
            f.Show();
        }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void TsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsBtnDoctor_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmDoctor());   
        }

        private void TsBtnPatient_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmPatient());
        }

        private void TsBtnMedicament_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmMedicament());
        }
    }
}
