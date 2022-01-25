
namespace CabinetModeDeconnect
{
    partial class FrmMedicament
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.LstMedicament = new System.Windows.Forms.ListBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbEndBy = new System.Windows.Forms.RadioButton();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.rbContent = new System.Windows.Forms.RadioButton();
            this.rbStartBy = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Réf :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Les Information du Medicament :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(686, 367);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 44);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nom :";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(587, 421);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(5);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(136, 44);
            this.btnValidate.TabIndex = 56;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(815, 367);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(144, 145);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 20);
            this.txtId.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Location = new System.Drawing.Point(542, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 331);
            this.panel2.TabIndex = 60;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(144, 195);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 20);
            this.txtNom.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(733, 421);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 44);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(552, 367);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 44);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.LstMedicament);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.rbEndBy);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.rbContent);
            this.panel1.Controls.Add(this.rbStartBy);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 464);
            this.panel1.TabIndex = 52;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(294, 413);
            this.btnLast.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 39);
            this.btnLast.TabIndex = 41;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // LstMedicament
            // 
            this.LstMedicament.FormattingEnabled = true;
            this.LstMedicament.Location = new System.Drawing.Point(4, 64);
            this.LstMedicament.Margin = new System.Windows.Forms.Padding(4);
            this.LstMedicament.Name = "LstMedicament";
            this.LstMedicament.Size = new System.Drawing.Size(363, 329);
            this.LstMedicament.TabIndex = 37;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(4, 4);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(255, 20);
            this.txtFind.TabIndex = 33;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(234, 413);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 39);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbEndBy
            // 
            this.rbEndBy.AutoSize = true;
            this.rbEndBy.Location = new System.Drawing.Point(190, 36);
            this.rbEndBy.Margin = new System.Windows.Forms.Padding(4);
            this.rbEndBy.Name = "rbEndBy";
            this.rbEndBy.Size = new System.Drawing.Size(59, 17);
            this.rbEndBy.TabIndex = 36;
            this.rbEndBy.Text = "End By";
            this.rbEndBy.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(86, 413);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 39);
            this.btnPrevious.TabIndex = 39;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(26, 413);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 39);
            this.btnFirst.TabIndex = 38;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(281, 3);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 25);
            this.btnFind.TabIndex = 32;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbContent
            // 
            this.rbContent.AutoSize = true;
            this.rbContent.Checked = true;
            this.rbContent.Location = new System.Drawing.Point(97, 36);
            this.rbContent.Margin = new System.Windows.Forms.Padding(4);
            this.rbContent.Name = "rbContent";
            this.rbContent.Size = new System.Drawing.Size(62, 17);
            this.rbContent.TabIndex = 35;
            this.rbContent.TabStop = true;
            this.rbContent.Text = "Content";
            this.rbContent.UseVisualStyleBackColor = true;
            // 
            // rbStartBy
            // 
            this.rbStartBy.AutoSize = true;
            this.rbStartBy.Location = new System.Drawing.Point(4, 36);
            this.rbStartBy.Margin = new System.Windows.Forms.Padding(4);
            this.rbStartBy.Name = "rbStartBy";
            this.rbStartBy.Size = new System.Drawing.Size(62, 17);
            this.rbStartBy.TabIndex = 34;
            this.rbStartBy.Text = "Start By";
            this.rbStartBy.UseVisualStyleBackColor = true;
            // 
            // FrmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 530);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMedicament";
            this.Text = "Gestion Medicament";
            this.Load += new System.EventHandler(this.FrmMedicament_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.ListBox LstMedicament;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbEndBy;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rbContent;
        private System.Windows.Forms.RadioButton rbStartBy;
    }
}