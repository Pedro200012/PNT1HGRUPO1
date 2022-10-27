using System;
using System.Linq;

namespace Concesionaria
{
    class Program
    {
        //AGREGO PERSONA
        public static void Agregar(Persona std)
        {
            using (var contexto = new ConcesionariaContext())
            {
                contexto.Personas.Add(std);
                contexto.SaveChanges();
            }
            Console.WriteLine("Persona agregada con exito");
        }
        public static void Modificar(int id, string nombre, string Apellido, int DNI)
        {
            // Modificar una persona
            using (var contexto = new ConcesionariaContext())
            {
                var listaPersonas = contexto.Personas.ToList<Persona>();

                //Actualiza una persona
                Persona personaActualizada =
                listaPersonas.Where(s => s.PersonaId == id).FirstOrDefault<Persona>();
                personaActualizada.Nombre = nombre;
                personaActualizada.Apellido = Apellido;
                personaActualizada.PersonaDNI = DNI;

                contexto.SaveChanges();

                Console.WriteLine("Persona modificada!");

            }
        }

        public static void Eliminar(int ubicacion)
        {
                using (var contexto = new ConcesionariaContext())
            {
                var listaPersonas = contexto.Personas.ToList<Persona>();
                contexto.Personas.Remove(listaPersonas.ElementAt<Persona>(ubicacion));
                contexto.SaveChanges();
                Console.WriteLine("Persona eliminada");
            }
        }
        

        

        static void Main(string[] args)
        {
     
                var std = new Persona()
                {
          
                    Nombre = "Pablo",
                    Apellido = "Perez",
                   
                };

            var std1 = new Persona()
            {
                Nombre = "Jaime",
                Apellido = "Rodriguez",
                PersonaDNI = 1236789
            };

            var std2 = new Persona()
            {
                Nombre = "Paola",
                Apellido = "Diaz",
                PersonaDNI = 17896789
            };

            //          Agregar(std1);
            // Agregar(std);
            //Modificar(1, "Pablo", "Perez", 1231232);
            //Eliminar(1);
            Agregar(std2);
            Console.ReadKey();
        }
    }
}
