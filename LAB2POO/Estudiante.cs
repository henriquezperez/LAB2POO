using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2POO
{
    public class Estudiante
    {

        //campos
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int CarreraId { get; set; }

        //constructores

        public Estudiante()
        {

        }

        public Estudiante(string nombre, string apellido, string dui, string telefono, string direccion, int carreraId)
        {
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Telefono = telefono;
            Direccion = direccion;
            CarreraId = carreraId;
        }

        public Estudiante(int estudianteId,string nombre, string apellido, string dui, string telefono, string direccion, int carreraId)
        {
            EstudianteId = estudianteId;
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Telefono = telefono;
            Direccion = direccion;
            CarreraId = carreraId;
        }

    }
}
