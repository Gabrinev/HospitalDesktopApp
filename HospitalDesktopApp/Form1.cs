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
        List<Patient> patients = new List<Patient>();
        List<Medico> doctors = new List<Medico>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            AddDocForm addDocForm = new AddDocForm();
            addDocForm.ShowDialog();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
            patients.Add(addPatientForm.p);

        }

        private void btnDocsList_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            foreach (Medico m in doctors)
            {
                listView1.Items.Add(m.ToString());
            }

            
            foreach (Patient p in patients)
            {
                listView1.Items.Add(p.ToString());
            }
        }
    }
}
