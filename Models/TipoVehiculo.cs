﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Delivery.Models
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Vehiculo = new HashSet<Vehiculo>();
        }

        public int IdTipoVehi { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}