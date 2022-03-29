using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDesktopApp
{
    public partial class ModPatientForm : Form
    {        
        public Patient currentPat;
        List<Patient> patients;
        Boolean add;
        ComboBox combobox;
        public ModPatientForm(List<Patient> pats, ComboBox a)
        {
            InitializeComponent();
            combobox = a;
            currentPat = null;
            add = true;
            comboBoxSelected.SelectedItem = "0";


            this.patients = pats;

            if (patients.Count > 0)
            {
                
                foreach (Patient p in patients)
                {
                    comboBoxSelected.Items.Add(p.id_patient);
                }
            }
        }

        private void comboBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelected.SelectedItem.ToString() != "0")
            {
                add = false;
                foreach (Patient p in patients)
                {
                    if (p.id_patient == Convert.ToInt32(comboBoxSelected.SelectedItem.ToString()))
                    {
                        txtDni.Text = p.dni;
                        txtName.Text = p.name;
                        txtSurname.Text = p.surname;
                        txtId.Text = p.id_patient.ToString();
                        txtIdDoc.Text = p.id_asigned_doc.ToString();
                        currentPat = p;
                    }
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentPat != null)
            {
                currentPat.dni = txtDni.Text;
                currentPat.name = txtName.Text;
                currentPat.surname = txtSurname.Text;
                currentPat.id_patient = Convert.ToInt32(txtId.Text);
                currentPat.id_asigned_doc = Convert.ToInt32(txtIdDoc.Text);
                
                Close();
            }
            else if (add)
            {
                Patient neew = new Patient(txtDni.Text, txtName.Text, txtSurname.Text, Convert.ToInt32(txtId.Text), Convert.ToInt32(txtIdDoc.Text));
                patients.Add(neew);
                combobox.Items.Add(neew.id_patient);
                Close();
            }
            else Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
