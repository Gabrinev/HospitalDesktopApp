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
    public partial class MainMenu : Form
    {
        public List<Patient> patients = new List<Patient>();
        public List<Medico> doctors = new List<Medico>();
        public MainMenu()
        {
            InitializeComponent();
            comboBoxDelPatient.SelectedItem = "0";
        }
       
        private void btnDocsList_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach (Medico m in doctors)
            {
                listView1.Items.Add(m.ToString());
            }
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach (Medico m in doctors)
            {
                listView1.Items.Add(m.ToString());
            }


            foreach (Patient p in patients)
            {
                listView1.Items.Add(p.ToString());
            }
        }

        private void comboBoxDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach (Patient p in patients)
            {
                if (p.id_asigned_doc == Convert.ToInt32(comboBoxDoctores.SelectedItem.ToString()))
                {
                    listView1.Items.Add(p.ToString());
                }
            }


        }

        private void btnDelPatient_Click(object sender, EventArgs e)
        {
            Patient temp = null;
            if (comboBoxDelPatient.SelectedItem.ToString() != null)
            {
                foreach (Patient p in patients)
                {
                    if (p.id_patient == Convert.ToInt32(comboBoxDelPatient.SelectedItem.ToString()))
                    {
                        temp = p;
                        comboBoxDelPatient.Items.Remove(p.id_patient);
                    }
                }
                patients.Remove(temp);
            }
            btnAllList_Click(sender, e);
        }

        private void btnModDoc_Click(object sender, EventArgs e)
        {
            ModDocForm modDocForm = new ModDocForm(doctors, comboBoxDoctores);
            modDocForm.ShowDialog();
            btnAllList_Click(sender, e);


        }

        private void btnModPatient_Click(object sender, EventArgs e)
        {
            ModPatientForm modPatientForm = new ModPatientForm(patients, comboBoxDelPatient);
            modPatientForm.ShowDialog();
            btnAllList_Click(sender, e);
        }
    }
}
