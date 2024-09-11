using StudentSystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica3APP.Forms
{
    public partial class StudentSystem : Form
    {
        public StudentSystem()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            Student student = new Student();

            career.Name = txtCarreraAlumno.Text;
            student.Firstname = txt
        }
    }
}
