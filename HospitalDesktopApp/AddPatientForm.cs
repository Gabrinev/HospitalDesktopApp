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
    public partial class AddPatientForm : Form
    {
        public Patient p;
        public AddPatientForm()
        {
            InitializeComponent();
        }

   

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            p = new Patient(txtDni.Text, txtName.Text, txtSurname.Text, Convert.ToInt32(txtIdPatient.Text), Convert.ToInt32(txtIdDoc.Text));
        }
    }
}
