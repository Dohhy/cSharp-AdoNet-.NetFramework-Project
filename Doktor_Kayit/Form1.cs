using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doktor_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DoctorDal _doctorDal = new DoctorDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListDoctors();
        }

        void ListDoctors()
        {
            dgwDoctors.DataSource = _doctorDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                Name = tbxNameAdd.Text,
                Surname = tbxSurnameAdd.Text,
                Polyclinic = tbxPolyclinicAdd.Text
            };

            _doctorDal.Add(doctor);

            ListDoctors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                Id = Convert.ToInt32(dgwDoctors.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Surname = tbxSurnameUpdate.Text,
                Polyclinic = tbxPolyclinicUpdate.Text
            };

            _doctorDal.Update(doctor);

            ListDoctors();
        }

        private void dgwDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwDoctors.CurrentRow.Cells[1].Value.ToString();
            tbxSurnameUpdate.Text = dgwDoctors.CurrentRow.Cells[2].Value.ToString();
            tbxPolyclinicUpdate.Text = dgwDoctors.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                Id = Convert.ToInt32(dgwDoctors.CurrentRow.Cells[0].Value),
                Name = dgwDoctors.CurrentRow.Cells[1].Value.ToString(),
                Surname = dgwDoctors.CurrentRow.Cells[2].Value.ToString(),
                Polyclinic = dgwDoctors.CurrentRow.Cells[3].Value.ToString()
            };

            _doctorDal.Delete(doctor);

            ListDoctors();
        }
    }
}
