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
    public partial class ModDocForm : Form
    {
        
        public Medico currentDoc = null;
        List<Medico> docs;
        Boolean add = true;
        ComboBox combobox;
        public ModDocForm(List<Medico>docs, ComboBox a)
        {
            InitializeComponent();
            comboBoxSelected.SelectedItem = "0";
            combobox = a;


            this.docs = docs;

            if (docs.Count > 0)
            {
                add = false;
                foreach (Medico m in docs)
                {
                    comboBoxSelected.Items.Add(m.id_doc);
                }
            }
            
            
        }

        private void comboBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!add)
            {
                foreach (Medico m in docs)
                {
                    if (m.id_doc == Convert.ToInt32(comboBoxSelected.SelectedItem.ToString()))
                    {
                        txtDni.Text = m.dni;
                        txtName.Text = m.name;
                        txtSurname.Text = m.surname;
                        txtId.Text = m.id_doc.ToString();
                        currentDoc = m;
                        

                    }
                }
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentDoc != null)
            {
                currentDoc.dni = txtDni.Text;
                currentDoc.name = txtName.Text;
                currentDoc.surname = txtSurname.Text;
                currentDoc.id_doc = Convert.ToInt32(txtId.Text);

                Close();
            }
            else if (add) 
            { 
                Medico neew = new Medico(txtDni.Text, txtName.Text, txtSurname.Text, Convert.ToInt32(txtId.Text));
                docs.Add(neew);
                combobox.Items.Add(neew.id_doc);
                Close();
            }else Close();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
