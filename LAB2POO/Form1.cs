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
    public partial class FormPrincipal : Form
    {
        public static List<Estudiante> _listaEstudiantes;
        public List<Carreras> _listaCarreras;
        Repositorio repo = new Repositorio();
        //KEVIN MIGUEL HENRÍQUEZ PÉREZ
        //HP0826022019
        //LIC. EN COMP. CICLO-02-2020

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //se obtiene la lista creadas para mostrarlo en la grilla
            _listaCarreras = repo.Carreras; //lo que trae en el repositorio
            _listaEstudiantes = repo.Estudiantes;
            UpdateGrid();
        } 

        private void UpdateGrid()
        {
            // comboBoxFiltrarBusqueda.DisplayMember = "";
            comboBoxFiltrarBusqueda.DisplayMember = "Nombre";
            comboBoxFiltrarBusqueda.ValueMember = "CarreraId"; //muestra con el filtro de busqueda las carreras y alumnos
            //muestra con el filtro de busqueda las carreras y alumnos
            //_listaCarreras.Insert(0, new Carreras() { CarreraId = 0, Nombre = "Mostrar Todos"}); //agrega una nueva opcion en filtrado para las carreras de la CarreraId =0
            comboBoxFiltrarBusqueda.DataSource = _listaCarreras.ToList(); //muestra en el filtro de busqueda las carreras
            dataGridViewListadoAlumnos.DataSource = _listaEstudiantes.ToList();
        }

        //llamamos al formulario de nuevo estudiante
        private void buttonNuevoEstudiante_Click(object sender, EventArgs e)
        {
            fmrNuevoEstudiante nuevoEstudiante = new fmrNuevoEstudiante(ref _listaEstudiantes);
            nuevoEstudiante.ShowDialog();
            UpdateGrid(); //actualiza de nuevo la grilla
        }

        private void comboBoxFiltrarBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //busqueda por carreras
            if (comboBoxFiltrarBusqueda.SelectedIndex > 0)
            {
                List<Estudiante> query =  _listaEstudiantes.Where(a => a.CarreraId == (int)comboBoxFiltrarBusqueda.SelectedValue).ToList();

               // comboBoxFiltrarBusqueda.SelectedValue = query; 
                dataGridViewListadoAlumnos.DataSource = query;//se actualizara el grid segun el filtrado
            }
            else
            {
                dataGridViewListadoAlumnos.DataSource = _listaEstudiantes; //sino hay ninguno "Mostrar todos"
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //criterios de busqueda 
            string criterio = textBoxBuscar.Text.Trim().ToLower();
            int id = 0;
            bool valor = int.TryParse(textBoxBuscar.Text, out id);

            List<Estudiante> query = _listaEstudiantes
                .Where(
                a => a.EstudianteId.ToString().ToLower().Contains(criterio) ||
                a.Nombre.ToLower().Contains(criterio) ||
                a.CarreraId.Equals(id) ||
                a.DUI.ToLower().Contains(criterio) ||
                a.Telefono.ToLower().Contains(criterio) ||
                a.Apellido.ToLower().Contains(criterio)
                ).ToList();

            dataGridViewListadoAlumnos.DataSource = query;
        }
    }
}
