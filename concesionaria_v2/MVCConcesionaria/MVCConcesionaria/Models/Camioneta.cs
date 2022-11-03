﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCConcesionaria.Models
{
    public class Camioneta : Vehiculo
    {
        public Boolean Es4x4 { get; set; }
        public Boolean EsDobleCabina { get; set; }

        public Camioneta()
        {

        }

        public Camioneta(int ID, string marca, string modelo, Boolean esUsado, double cantKm, Boolean es4x4, Boolean dobleCab) : base(ID, marca, modelo, esUsado, cantKm)
        {
            this.Es4x4 = es4x4;
            this.EsDobleCabina = dobleCab;
        }
    }
}
