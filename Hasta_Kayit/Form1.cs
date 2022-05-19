using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasta_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PatientDal _patientDal = new PatientDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListPatients();
        }

        void ListPatients()
        {
            dgwPatients.DataSource = _patientDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                Name = tbxNameAdd.Text,
                Age = Convert.ToInt32(tbxAgeAdd.Text)
            };

            _patientDal.Add(patient);

            ListPatients();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _patientDal.Update(new Patient
            {
                Id = Convert.ToInt32(dgwPatients.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Age = Convert.ToInt32(tbxAgeUpdate.Text)
            });

            ListPatients();
        }

        private void dgwPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwPatients.CurrentRow.Cells[1].Value.ToString();
            tbxAgeUpdate.Text = dgwPatients.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _patientDal.Delete(Convert.ToInt32(dgwPatients.CurrentRow.Cells[0].Value));

            ListPatients();
        }
    }
}
