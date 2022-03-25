
namespace HospitalDesktopApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitle = new System.Windows.Forms.Label();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnDocsList = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnDelPatient = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxDoctores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(220, 24);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(355, 29);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "HOSPITAL SAN SAN DE SAN";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDoc.Location = new System.Drawing.Point(46, 343);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(344, 33);
            this.btnAddDoc.TabIndex = 1;
            this.btnAddDoc.Text = "Añadir Doctor";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPatient.Location = new System.Drawing.Point(46, 392);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(344, 33);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Añadir Paciente";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnDocsList
            // 
            this.btnDocsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocsList.Location = new System.Drawing.Point(46, 100);
            this.btnDocsList.Name = "btnDocsList";
            this.btnDocsList.Size = new System.Drawing.Size(344, 33);
            this.btnDocsList.TabIndex = 3;
            this.btnDocsList.Text = "Lista Doctores";
            this.btnDocsList.UseVisualStyleBackColor = true;
            this.btnDocsList.Click += new System.EventHandler(this.btnDocsList_Click);
            // 
            // btnAllList
            // 
            this.btnAllList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllList.Location = new System.Drawing.Point(46, 151);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(344, 33);
            this.btnAllList.TabIndex = 5;
            this.btnAllList.Text = "Lista de todos";
            this.btnAllList.UseVisualStyleBackColor = true;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // btnDelPatient
            // 
            this.btnDelPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelPatient.Location = new System.Drawing.Point(411, 392);
            this.btnDelPatient.Name = "btnDelPatient";
            this.btnDelPatient.Size = new System.Drawing.Size(344, 33);
            this.btnDelPatient.TabIndex = 6;
            this.btnDelPatient.Text = "Dar de baja un Paciente";
            this.btnDelPatient.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(411, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 276);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxDoctores
            // 
            this.comboBoxDoctores.FormattingEnabled = true;
            this.comboBoxDoctores.Location = new System.Drawing.Point(46, 220);
            this.comboBoxDoctores.Name = "comboBoxDoctores";
            this.comboBoxDoctores.Size = new System.Drawing.Size(344, 21);
            this.comboBoxDoctores.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista pacientes del doctor: ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDoctores);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelPatient);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnDocsList);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.labTitle);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnDocsList;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Button btnDelPatient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBoxDoctores;
        private System.Windows.Forms.Label label1;
    }
}

