
namespace HospitalDesktopApp
{
    partial class AddPatientForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.txtIdPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(77, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(158, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdDoc.Location = new System.Drawing.Point(96, 197);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(100, 20);
            this.txtIdDoc.TabIndex = 19;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Location = new System.Drawing.Point(96, 139);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(96, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Location = new System.Drawing.Point(96, 82);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "AÑADIR PACIENTE";
            // 
            // labId
            // 
            this.labId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(37, 200);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(59, 13);
            this.labId.TabIndex = 14;
            this.labId.Text = "ID Doctor: ";
            // 
            // labSurname
            // 
            this.labSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(37, 142);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(50, 13);
            this.labSurname.TabIndex = 13;
            this.labSurname.Text = "Apellido: ";
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(37, 111);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(50, 13);
            this.labName.TabIndex = 12;
            this.labName.Text = "Nombre: ";
            // 
            // labDni
            // 
            this.labDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(37, 84);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(32, 13);
            this.labDni.TabIndex = 11;
            this.labDni.Text = "DNI: ";
            // 
            // txtIdPatient
            // 
            this.txtIdPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdPatient.Location = new System.Drawing.Point(96, 168);
            this.txtIdPatient.Name = "txtIdPatient";
            this.txtIdPatient.Size = new System.Drawing.Size(100, 20);
            this.txtIdPatient.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Patient: ";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 262);
            this.Controls.Add(this.txtIdPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtIdDoc);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDni);
            this.Name = "AddPatientForm";
            this.Text = "Añadir Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDni;
        private System.Windows.Forms.TextBox txtIdPatient;
        private System.Windows.Forms.Label label2;
    }
}