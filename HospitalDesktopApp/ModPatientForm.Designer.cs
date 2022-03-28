
namespace HospitalDesktopApp
{
    partial class ModPatientForm
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
            this.comboBoxSelected = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.labId = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxSelected
            // 
            this.comboBoxSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSelected.FormattingEnabled = true;
            this.comboBoxSelected.Items.AddRange(new object[] {
            "0"});
            this.comboBoxSelected.Location = new System.Drawing.Point(175, 110);
            this.comboBoxSelected.Name = "comboBoxSelected";
            this.comboBoxSelected.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSelected.TabIndex = 33;
            this.comboBoxSelected.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelected_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(275, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(356, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(208, 251);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 30;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Location = new System.Drawing.Point(208, 222);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(208, 191);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 28;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Location = new System.Drawing.Point(208, 165);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 27;
            // 
            // labId
            // 
            this.labId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(133, 254);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(69, 13);
            this.labId.TabIndex = 26;
            this.labId.Text = "ID Paciente: ";
            // 
            // labSurname
            // 
            this.labSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(133, 225);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(50, 13);
            this.labSurname.TabIndex = 25;
            this.labSurname.Text = "Apellido: ";
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(133, 194);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(50, 13);
            this.labName.TabIndex = 24;
            this.labName.Text = "Nombre: ";
            // 
            // labDni
            // 
            this.labDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(133, 168);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(32, 13);
            this.labDni.TabIndex = 23;
            this.labDni.Text = "DNI: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "AÑADIR O MODIFICAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "PACIENTES";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID Doctor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "asignado: ";
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdDoc.Location = new System.Drawing.Point(208, 286);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(100, 20);
            this.txtIdDoc.TabIndex = 37;
            // 
            // ModPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 345);
            this.Controls.Add(this.txtIdDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelected);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDni);
            this.Controls.Add(this.label1);
            this.Name = "ModPatientForm";
            this.Text = "ModPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelected;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdDoc;
    }
}