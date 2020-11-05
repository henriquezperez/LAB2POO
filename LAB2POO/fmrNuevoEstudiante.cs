using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2POO
{
    public partial class fmrNuevoEstudiante : Form
    {
        private List<Carreras> _listaCarreras;
        int cerrar = 0;

        public fmrNuevoEstudiante()
        {
            InitializeComponent(); 
        }

        public fmrNuevoEstudiante(ref List<Estudiante> estudiantes)
        {
            InitializeComponent();
          
        }
        //lanza el nuevo formulario
        private void fmrNuevoEstudiante_Load(object sender, EventArgs e)
        {
            Repositorio repo = new Repositorio();
            _listaCarreras = repo.Carreras;
            UpdateCombox();
           
        }

        private void UpdateCombox()//muestra las categorias para seleccionar
        {
            comboBoxCarrera.DataSource = _listaCarreras;
            comboBoxCarrera.DisplayMember = "Nombre";
            comboBoxCarrera.ValueMember = "CarreraId";
        }

       // Guid guid = Guid.NewGuid();//generar id 
        private void buttonGuardarAlumno_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (cerrar == 1)
            {
                FormPrincipal._listaEstudiantes.Any();
                buttonCancelar_Click(null, null);
            }
            Estudiante entity = new Estudiante()
            {
                EstudianteId = rnd.Next(600, 2000),
                Nombre = textBoxNombre.Text.Trim(),
                Apellido = textBoxApellido.Text.Trim(),
                DUI = textBoxDUI.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Direccion = textBoxDireccion.Text.Trim(),
                CarreraId = (int)comboBoxCarrera.SelectedValue

            };
            
            //pasara estos datos a la grilla para agregar
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxDUI.Text == "" || textBoxTelefono.Text == "" || textBoxDireccion.Text == "")
            {
                MessageBox.Show("Hay Campos vacíos: rellenar espacio", "Espacio Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // iniciar = 0;
                // InitializeComponent();
               
            }
            else if ((int)comboBoxCarrera.SelectedValue == 0)
            {
                    //sino especifica la carrera
                    MessageBox.Show("Especifique la carrera", "¿Carrera?", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
                FormPrincipal._listaEstudiantes.Add(entity);
                this.Close();
            }
            if (cerrar == 1)
            {
                FormPrincipal._listaEstudiantes.Any();
                buttonCancelar_Click(null, null);
            }

        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            // buttonGuardarAlumno_Click(null, null);
            this.Close();
            
        }
    }
}
