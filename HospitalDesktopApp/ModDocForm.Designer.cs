
namespace HospitalDesktopApp
{
    partial class ModDocForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.comboBoxSelected = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑADIR O MODIFICAR";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(275, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
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
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(200, 228);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Location = new System.Drawing.Point(200, 199);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(200, 168);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Location = new System.Drawing.Point(200, 142);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 15;
            // 
            // labId
            // 
            this.labId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(141, 231);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(59, 13);
            this.labId.TabIndex = 14;
            this.labId.Text = "ID Doctor: ";
            // 
            // labSurname
            // 
            this.labSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(141, 202);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(50, 13);
            this.labSurname.TabIndex = 13;
            this.labSurname.Text = "Apellido: ";
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(141, 171);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(50, 13);
            this.labName.TabIndex = 12;
            this.labName.Text = "Nombre: ";
            // 
            // labDni
            // 
            this.labDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(141, 144);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(32, 13);
            this.labDni.TabIndex = 11;
            this.labDni.Text = "DNI: ";
            // 
            // comboBoxSelected
            // 
            this.comboBoxSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSelected.FormattingEnabled = true;
            this.comboBoxSelected.Items.AddRange(new object[] {
            "0"});
            this.comboBoxSelected.Location = new System.Drawing.Point(176, 93);
            this.comboBoxSelected.Name = "comboBoxSelected";
            this.comboBoxSelected.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSelected.TabIndex = 21;
            this.comboBoxSelected.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelected_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = " DOCTOR";
            // 
            // ModDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 345);
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
            this.Name = "ModDocForm";
            this.Text = "ModDocForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox comboBoxSelected;
        private System.Windows.Forms.Label label2;
    }
}