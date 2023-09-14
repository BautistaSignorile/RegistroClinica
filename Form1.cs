using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class Clinica : Form
    {
        public Clinica()
        {
            InitializeComponent();
        }

        private void Clinica_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Especialidades objEspecialidad = new Especialidades();
            objEspecialidad.Especialidad = Convert.ToInt32(txtEspecialidad.Text);
            objEspecialidad.Nombre = txtNombre.Text;
            objEspecialidad.grabar();
            txtEspecialidad.Text = "";
            txtNombre.Text = "";
            
        }
    }
}
