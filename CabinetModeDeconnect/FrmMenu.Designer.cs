
namespace CabinetModeDeconnect
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsBtnDoctor = new System.Windows.Forms.ToolStripButton();
            this.TsBtnPatient = new System.Windows.Forms.ToolStripButton();
            this.TsBtnMedicament = new System.Windows.Forms.ToolStripButton();
            this.TsBtnOrdonance = new System.Windows.Forms.ToolStripButton();
            this.TsBtnConsultation = new System.Windows.Forms.ToolStripButton();
            this.TsBtnClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SContainer)).BeginInit();
            this.SContainer.Panel1.SuspendLayout();
            this.SContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SContainer
            // 
            this.SContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SContainer.Location = new System.Drawing.Point(0, 0);
            this.SContainer.Name = "SContainer";
            this.SContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SContainer.Panel1
            // 
            this.SContainer.Panel1.Controls.Add(this.toolStrip1);
            this.SContainer.Size = new System.Drawing.Size(919, 450);
            this.SContainer.SplitterDistance = 147;
            this.SContainer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(120, 120);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnDoctor,
            this.TsBtnPatient,
            this.TsBtnMedicament,
            this.TsBtnOrdonance,
            this.TsBtnConsultation,
            this.TsBtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 148);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsBtnDoctor
            // 
            this.TsBtnDoctor.Image = global::CabinetModeDeconnect.Properties.Resources.doctor;
            this.TsBtnDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnDoctor.Name = "TsBtnDoctor";
            this.TsBtnDoctor.Size = new System.Drawing.Size(124, 145);
            this.TsBtnDoctor.Text = "Medecin";
            this.TsBtnDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnDoctor.Click += new System.EventHandler(this.TsBtnDoctor_Click);
            // 
            // TsBtnPatient
            // 
            this.TsBtnPatient.Image = global::CabinetModeDeconnect.Properties.Resources.Patient;
            this.TsBtnPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnPatient.Name = "TsBtnPatient";
            this.TsBtnPatient.Size = new System.Drawing.Size(124, 145);
            this.TsBtnPatient.Text = "Patient";
            this.TsBtnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnPatient.Click += new System.EventHandler(this.TsBtnPatient_Click);
            // 
            // TsBtnMedicament
            // 
            this.TsBtnMedicament.Image = global::CabinetModeDeconnect.Properties.Resources.medication;
            this.TsBtnMedicament.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnMedicament.Name = "TsBtnMedicament";
            this.TsBtnMedicament.Size = new System.Drawing.Size(124, 145);
            this.TsBtnMedicament.Text = "Medicament";
            this.TsBtnMedicament.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnMedicament.Click += new System.EventHandler(this.TsBtnMedicament_Click);
            // 
            // TsBtnOrdonance
            // 
            this.TsBtnOrdonance.Image = global::CabinetModeDeconnect.Properties.Resources.checklist;
            this.TsBtnOrdonance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnOrdonance.Name = "TsBtnOrdonance";
            this.TsBtnOrdonance.Size = new System.Drawing.Size(124, 145);
            this.TsBtnOrdonance.Text = "Ordonance";
            this.TsBtnOrdonance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TsBtnConsultation
            // 
            this.TsBtnConsultation.Image = global::CabinetModeDeconnect.Properties.Resources.consulting;
            this.TsBtnConsultation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnConsultation.Name = "TsBtnConsultation";
            this.TsBtnConsultation.Size = new System.Drawing.Size(124, 145);
            this.TsBtnConsultation.Text = "Consultation";
            this.TsBtnConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TsBtnClose
            // 
            this.TsBtnClose.Image = global::CabinetModeDeconnect.Properties.Resources.logout;
            this.TsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnClose.Name = "TsBtnClose";
            this.TsBtnClose.Size = new System.Drawing.Size(124, 145);
            this.TsBtnClose.Text = "Exit";
            this.TsBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnClose.Click += new System.EventHandler(this.TsBtnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.SContainer);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SContainer.Panel1.ResumeLayout(false);
            this.SContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SContainer)).EndInit();
            this.SContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnDoctor;
        private System.Windows.Forms.ToolStripButton TsBtnPatient;
        private System.Windows.Forms.ToolStripButton TsBtnMedicament;
        private System.Windows.Forms.ToolStripButton TsBtnOrdonance;
        private System.Windows.Forms.ToolStripButton TsBtnConsultation;
        private System.Windows.Forms.ToolStripButton TsBtnClose;
    }
}

