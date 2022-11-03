using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCConcesionaria.Models
{
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Boolean EsUsado { get; set; }
        public double CantKm { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(int ID, string marca, string modelo, Boolean esUsado, double cantKm)
        {
            this.ID = ID;
            this.Marca = marca;
            this.Modelo = modelo;
            this.EsUsado = esUsado;
            this.CantKm = cantKm;
        }

    }




}
