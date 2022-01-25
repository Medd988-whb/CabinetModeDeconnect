using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace CabinetModeDeconnect
{
    public partial class FrmMedicament : Form
    {
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommandBuilder cmdBuild = new SqlCommandBuilder();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        BindingSource binding = new BindingSource();


        public void Activate(bool v)
        {
            panel2.Enabled = !v;
            panel1.Enabled = v;
            btnNew.Visible = v;
            btnEdit.Visible = v;
            btnDelete.Visible = v;

            btnValidate.Visible = !v;
            btnCancel.Visible = !v;


        }

        public FrmMedicament()
        {
            InitializeComponent();
        }

        private void FrmMedicament_Load(object sender, EventArgs e)
        {
            string cnfig = ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;

            cnx.ConnectionString = cnfig;
            cnx.Open();

            cmd.Connection = cnx;
            cmd.CommandText = "select * from medicament";

            da = new SqlDataAdapter(cmd);

            cmdBuild = new SqlCommandBuilder(da);

            da.Fill(ds, "medicament");

            binding.DataSource = ds;
            binding.DataMember = "medicament";

            LstMedicament.DisplayMember = "nom";
            LstMedicament.ValueMember = "id";
            LstMedicament.DataSource = binding;

            txtId.DataBindings.Add("text", binding, "id");
            txtNom.DataBindings.Add("text", binding, "nom");

            Activate(true);
        }

        

        private void btnFind_Click(object sender, EventArgs e)
        {
            string start = "%";
            string finish = "%";
            if (rbEndBy.Checked) finish = "";
            if (rbStartBy.Checked) start = "";

            binding.Filter = "nom like '" + start + txtFind.Text + finish + "'";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            binding.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (LstMedicament.SelectedIndex == 0)
                binding.MoveLast();
            else
                binding.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (LstMedicament.SelectedIndex == LstMedicament.Items.Count - 1)
                binding.MoveFirst();
            else
                binding.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            binding.MoveLast();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            binding.AddNew();
            Activate(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Activate(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete it?", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                binding.RemoveCurrent();
                da.Update(ds, "medicament");
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            binding.EndEdit();
            da.Update(ds, "medicament");
            Activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
            Activate(true);
        }


        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btnFind.PerformClick();
            }
        }        
    }
}
