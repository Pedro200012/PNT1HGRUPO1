using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCConcesionaria.Models
{
    public class Auto : Vehiculo
    {
        public int CantPuertas { get; set; }

        public Auto()
        {
        }

        public Auto(int ID, string marca, string modelo, Boolean esUsado, double cantKm, int puertas) : base(ID, marca, modelo, esUsado, cantKm)
        {
            this.CantPuertas = puertas;
        }

    }
}
