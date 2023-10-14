using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1._2.Models
{
    public class Empleado 
    {
        public Empleado(string name, string lastName, DateTime bD, string email)
        {
            nombres = name;
            apellidos = lastName;
            fechaNac = bD;
            correo=email;
        }

        public String nombres { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNac { get; set; }
        public String correo { get; set; }



    }
}
