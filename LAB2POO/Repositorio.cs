using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2POO
{
    public class Repositorio
    {
        private List<Carreras> _carreras;
        private List<Estudiante> _estudiante;

        
        //envia de manera predeterminada a la gruilla informacion ya existente
        public Repositorio()
        {
            
            //envia todo a una lista 
            _carreras = new List<Carreras>()
            {
                //codigo de carrera, "nombre de carrera"
                new Carreras (0, "Mostrar Todos"),
                new Carreras (1, "Lic. en Computación"),
                new Carreras (2, "Ing. en Computación"),
                new Carreras (3, "Tec. en Computación"),
                new Carreras (4, "Lic. en Admin Empresa"),
                new Carreras (5, "Lic. en Contaduria"),
                new Carreras (6, "Lic. en Turismo"),
                new Carreras (7, "Lic. en Enfermeria"),
                new Carreras (8, "Tec. en Enfermeria"),
                new Carreras (9, "Lic. en Mercadeo"),
                new Carreras (10, "Lic. en Ciencias juridicas")
            };
            
            _estudiante = new List<Estudiante>()
            {
               // Estudiante(string nombre, string apellido, string dui, string telefono, string direccion, int carreraId)
                new Estudiante(500,"Miguel "," Henríquez"," 01010101-1","70006000","Sonsonate",1),
                new Estudiante(501,"Kevin "," Pérz"," 01010101-2","70006001","Nahuizalco",2),
                new Estudiante(502,"Elena "," Rosa"," 01010101-3","70006002","Nahuizalco",3),
                new Estudiante(503,"Silvia "," Gonzales"," 01010101-4","70006003","Juayua",1),
                new Estudiante(504,"Marta "," Cruz"," 01010101-5","70006004","San Julian",2),
                new Estudiante(505,"Felix "," Herrera"," 01010101-6","70006005","Sonzacate",2),
                new Estudiante(506,"Rigoberto "," Campos"," 01010101-7","70006006","Nahuilingo",1),
                new Estudiante(507,"Rosenda "," Guzman"," 01010101-8","70006007","Santo Domingo G.",1),
                new Estudiante(508,"Lucas "," Castro"," 01010101-9","70006008","Acajutla",2),
                new Estudiante(509,"Maria "," Gomez"," 01010110-1","70006009","Armenia",1),
              
            };
            
        }
        
        //envia lo que tendra en el repositorio
        public List<Carreras> Carreras
        {
            get
            {
                return _carreras;
            }
        }

        public List<Estudiante> Estudiantes
        {
            get
            {
                return _estudiante;
            }
        }

    }
}
