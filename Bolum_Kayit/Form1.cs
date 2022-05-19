using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PolyclinicDal _polyclinicDal = new PolyclinicDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListPolyclinics();
        }

        void ListPolyclinics()
        {
            dgwPolyclinics.DataSource = _polyclinicDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Polyclinic polyclinic = new Polyclinic()
            {
                Name = tbxNameAdd.Text,
                EmployeeCount = Convert.ToInt32(tbxEmploeeCountAdd.Text)
            };
            _polyclinicDal.Add(polyclinic);

            ListPolyclinics();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Polyclinic polyclinic = new Polyclinic()
            {
                Id = Convert.ToInt32(dgwPolyclinics.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                EmployeeCount = Convert.ToInt32(tbxEmployeeCountUpdate.Text)
            };
            _polyclinicDal.Update(polyclinic);

            ListPolyclinics();
        }

        private void dgwPolyclinics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwPolyclinics.CurrentRow.Cells[1].Value.ToString();
            tbxEmployeeCountUpdate.Text = dgwPolyclinics.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Polyclinic polyclinic = new Polyclinic()
            {
                Id = Convert.ToInt32(dgwPolyclinics.CurrentRow.Cells[0].Value),
                Name = dgwPolyclinics.CurrentRow.Cells[1].Value.ToString(),
                EmployeeCount = Convert.ToInt32(dgwPolyclinics.CurrentRow.Cells[2].Value)
            };
            _polyclinicDal.Delete(polyclinic);

            ListPolyclinics();
        }
    }
}
