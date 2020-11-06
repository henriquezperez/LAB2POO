using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2POO
{
    public class Carreras
    {
        //definimos la clase
        //campos
        public int CarreraId { get; set; }
        public string Nombre { get; set; }

        //constructores
        //
        public Carreras()
        {

        }

        public Carreras(int carreraId)
        {
            CarreraId = carreraId;
        }
         
        public Carreras(int carreraId, string nombre)
        {
            CarreraId = carreraId;
            Nombre = nombre;
        }


    }
}
