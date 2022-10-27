using System;
using System.Collections.Generic;
using System.Text;

namespace Concesionaria
{
    public class Persona
    {
        //PREGUNTAR!!!!!!!!!!!!!!!!!!
        public int PersonaId { get; set; }
        public int PersonaDNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {

        }

        public Persona(string n, string a, int d)
        {
            Nombre = n;
            Apellido = a;
            PersonaDNI = d;
        }
    }
}
