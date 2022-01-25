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
    public partial class FrmPatient : Form
    {

        SqlConnection cnx =new SqlConnection();
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

            btnPicture.Visible = !v;

        }

        public FrmPatient()
        {
            InitializeComponent();                        
        }


        private void FrmPatient_Load(object sender, EventArgs e)
        {
            string cnfig = ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;

            cnx.ConnectionString = cnfig;
            cnx.Open();

            cmd.Connection = cnx;
            cmd.CommandText = "select * from patient";

            da = new SqlDataAdapter(cmd);

            cmdBuild = new SqlCommandBuilder(da);

            da.Fill(ds, "patient");

            binding.DataSource = ds;
            binding.DataMember = "patient";

            LstPatient.DisplayMember = "nom";
            LstPatient.ValueMember = "id";
            LstPatient.DataSource = binding;

            txtId.DataBindings.Add("text", binding, "id");
            txtNom.DataBindings.Add("text", binding, "nom");
            txtPrenom.DataBindings.Add("text", binding, "prenom");
            txtEmail.DataBindings.Add("text", binding, "email");
            txtTel.DataBindings.Add("text", binding, "telephone");
            txt_img.DataBindings.Add("text", binding, "photo");

            ofd.Filter = "Fichiers PNG|*.png|Fichier JPG|*.JPG|Fichier GIF|*.GIF";

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
            if (LstPatient.SelectedIndex == 0) binding.MoveLast();
            else
                binding.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (LstPatient.SelectedIndex == LstPatient.Items.Count - 1) binding.MoveFirst();
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
            if(MessageBox.Show("Do you want to delete it?","Deleting",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                binding.RemoveCurrent();
                da.Update(ds, "patient");
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            binding.EndEdit();
            da.Update(ds, "patient");
            Activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
            Activate(true);
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(ofd.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace(":", "").Replace("-", "").Replace("/", "");
                Random r = new Random();
                name += (r.Next() * 1000).ToString().Replace("-", "");
                name += ext;
                File.Copy(ofd.FileName, "pictures/" + name);
                txt_img.Text = name;
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnFind.PerformClick();
        }

        private void txt_img_TextChanged(object sender, EventArgs e)
        {
            if (txt_img.Text == "")
                picBx.Load("pictures/empty.png");
            else
                picBx.Load("pictures/" + txt_img.Text);
        }

       
    }
}
