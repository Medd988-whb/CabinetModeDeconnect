﻿using System;
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
    public partial class FrmDoctor : Form
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

            btnPicture.Visible = !v;

        }


        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            string cnfig = ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;

            cnx.ConnectionString = cnfig;
            cnx.Open();

            cmd.Connection = cnx;
            cmd.CommandText = "select * from medecin";

            da = new SqlDataAdapter(cmd);

            cmdBuild = new SqlCommandBuilder(da);

            da.Fill(ds, "medecin");

            binding.DataSource = ds;
            binding.DataMember = "medecin";

            LstDoctor.DisplayMember = "nom";
            LstDoctor.ValueMember = "id";
            LstDoctor.DataSource = binding;

            txtId.DataBindings.Add("text", binding, "id");
            txtNom.DataBindings.Add("text", binding, "nom");
            txtPrenom.DataBindings.Add("text", binding, "prenom");
            txtEmail.DataBindings.Add("text", binding, "email");
            txtTel.DataBindings.Add("text", binding, "telephone");
            txt_img.DataBindings.Add("text", binding, "photo");


            ofd.Filter = "Fichiers PNG|*.png|Fichier JPG|*.JPG|Fichier GIF|*.GIF";

            Activate(true);

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            binding.EndEdit();
            da.Update(ds, "medecin");
            Activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
            Activate(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Activate(false);
            binding.AddNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Activate(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete it ?","Deleting",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                binding.RemoveCurrent();
                da.Update(ds, "medecin");
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(ofd.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace("-", "").Replace("/", "").Replace(":", "");
                Random r = new Random();
                name += (r.Next() * 100).ToString().Replace("-", "");
                name += ext;
                File.Copy(ofd.FileName, "pictures/" + name);
                txt_img.Text = name;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            binding.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (LstDoctor.SelectedIndex == 0)
                binding.MoveLast();
            else
                binding.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (LstDoctor.SelectedIndex == LstDoctor.Items.Count - 1)
                binding.MoveFirst();
            else
                binding.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            binding.MoveLast();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string start = "%";
            string finish = "%";
            if (rbStartBy.Checked) start = "";
            if (rbEndBy.Checked) finish = "";
            binding.Filter = "nom like '" + start + txtFind.Text + finish + "'";
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btnFind.PerformClick();
            }
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
