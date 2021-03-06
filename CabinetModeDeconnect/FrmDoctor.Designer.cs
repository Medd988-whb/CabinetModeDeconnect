
namespace CabinetModeDeconnect
{
    partial class FrmDoctor
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
            this.rbEndBy = new System.Windows.Forms.RadioButton();
            this.rbContent = new System.Windows.Forms.RadioButton();
            this.rbStartBy = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.LstDoctor = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEndBy
            // 
            this.rbEndBy.AutoSize = true;
            this.rbEndBy.Location = new System.Drawing.Point(190, 36);
            this.rbEndBy.Margin = new System.Windows.Forms.Padding(4);
            this.rbEndBy.Name = "rbEndBy";
            this.rbEndBy.Size = new System.Drawing.Size(69, 20);
            this.rbEndBy.TabIndex = 36;
            this.rbEndBy.Text = "End By";
            this.rbEndBy.UseVisualStyleBackColor = true;
            // 
            // rbContent
            // 
            this.rbContent.AutoSize = true;
            this.rbContent.Checked = true;
            this.rbContent.Location = new System.Drawing.Point(97, 36);
            this.rbContent.Margin = new System.Windows.Forms.Padding(4);
            this.rbContent.Name = "rbContent";
            this.rbContent.Size = new System.Drawing.Size(71, 20);
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
            this.rbStartBy.Size = new System.Drawing.Size(72, 20);
            this.rbStartBy.TabIndex = 34;
            this.rbStartBy.Text = "Start By";
            this.rbStartBy.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(4, 4);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(255, 22);
            this.txtFind.TabIndex = 33;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.LstDoctor);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.rbEndBy);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.rbContent);
            this.panel1.Controls.Add(this.rbStartBy);
            this.panel1.Location = new System.Drawing.Point(16, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 464);
            this.panel1.TabIndex = 37;
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
            // LstDoctor
            // 
            this.LstDoctor.FormattingEnabled = true;
            this.LstDoctor.ItemHeight = 16;
            this.LstDoctor.Location = new System.Drawing.Point(4, 64);
            this.LstDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.LstDoctor.Name = "LstDoctor";
            this.LstDoctor.Size = new System.Drawing.Size(363, 340);
            this.LstDoctor.TabIndex = 37;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(592, 424);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 44);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(446, 424);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(5);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(136, 44);
            this.btnValidate.TabIndex = 41;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(674, 370);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(545, 370);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 44);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(411, 370);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 44);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(817, 81);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(72, 41);
            this.btnPicture.TabIndex = 44;
            this.btnPicture.Text = "Get Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 22);
            this.txtEmail.TabIndex = 45;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(144, 112);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 22);
            this.txtNom.TabIndex = 46;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(144, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 22);
            this.txtId.TabIndex = 47;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(144, 170);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(191, 22);
            this.txtPrenom.TabIndex = 48;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(144, 271);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 22);
            this.txtTel.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTel);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Location = new System.Drawing.Point(401, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 331);
            this.panel2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Réf :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Telephone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Les Information du Medecin :";
            // 
            // picBx
            // 
            this.picBx.Location = new System.Drawing.Point(896, 68);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(242, 236);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx.TabIndex = 43;
            this.picBx.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(950, 100);
            this.txt_img.Margin = new System.Windows.Forms.Padding(4);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(10, 22);
            this.txt_img.TabIndex = 51;
            this.txt_img.TextChanged += new System.EventHandler(this.txt_img_TextChanged);
            // 
            // FrmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.picBx);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_img);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoctor";
            this.Text = "Gestion Medecin";
            this.Load += new System.EventHandler(this.FrmDoctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEndBy;
        private System.Windows.Forms.RadioButton rbContent;
        private System.Windows.Forms.RadioButton rbStartBy;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LstDoctor;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txt_img;
    }
}