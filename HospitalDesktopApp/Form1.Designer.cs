
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
            this.btnDocsList = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnDelPatient = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxDoctores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDelPatient = new System.Windows.Forms.ComboBox();
            this.btnModPatient = new System.Windows.Forms.Button();
            this.btnModDoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnDelPatient.Size = new System.Drawing.Size(251, 33);
            this.btnDelPatient.TabIndex = 6;
            this.btnDelPatient.Text = "Dar de baja Paciente";
            this.btnDelPatient.UseVisualStyleBackColor = true;
            this.btnDelPatient.Click += new System.EventHandler(this.btnDelPatient_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(411, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 276);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // comboBoxDoctores
            // 
            this.comboBoxDoctores.FormattingEnabled = true;
            this.comboBoxDoctores.Location = new System.Drawing.Point(46, 220);
            this.comboBoxDoctores.Name = "comboBoxDoctores";
            this.comboBoxDoctores.Size = new System.Drawing.Size(344, 21);
            this.comboBoxDoctores.TabIndex = 8;
            this.comboBoxDoctores.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctores_SelectedIndexChanged);
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
            // comboBoxDelPatient
            // 
            this.comboBoxDelPatient.FormattingEnabled = true;
            this.comboBoxDelPatient.Items.AddRange(new object[] {
            "0"});
            this.comboBoxDelPatient.Location = new System.Drawing.Point(683, 404);
            this.comboBoxDelPatient.Name = "comboBoxDelPatient";
            this.comboBoxDelPatient.Size = new System.Drawing.Size(88, 21);
            this.comboBoxDelPatient.TabIndex = 10;
            // 
            // btnModPatient
            // 
            this.btnModPatient.Location = new System.Drawing.Point(46, 392);
            this.btnModPatient.Name = "btnModPatient";
            this.btnModPatient.Size = new System.Drawing.Size(344, 33);
            this.btnModPatient.TabIndex = 11;
            this.btnModPatient.Text = "Añadir o Modificar Paciente";
            this.btnModPatient.UseVisualStyleBackColor = true;
            this.btnModPatient.Click += new System.EventHandler(this.btnModPatient_Click);
            // 
            // btnModDoc
            // 
            this.btnModDoc.Location = new System.Drawing.Point(46, 343);
            this.btnModDoc.Name = "btnModDoc";
            this.btnModDoc.Size = new System.Drawing.Size(344, 33);
            this.btnModDoc.TabIndex = 12;
            this.btnModDoc.Text = "Añadir o Modificar Medico";
            this.btnModDoc.UseVisualStyleBackColor = true;
            this.btnModDoc.Click += new System.EventHandler(this.btnModDoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona paciente:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModDoc);
            this.Controls.Add(this.btnModPatient);
            this.Controls.Add(this.comboBoxDelPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDoctores);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelPatient);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnDocsList);
            this.Controls.Add(this.labTitle);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnDocsList;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Button btnDelPatient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBoxDoctores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDelPatient;
        private System.Windows.Forms.Button btnModPatient;
        private System.Windows.Forms.Button btnModDoc;
        private System.Windows.Forms.Label label2;
    }
}

