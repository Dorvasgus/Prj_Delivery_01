// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Delivery.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroIdentidad { get; set; }
        public int Rol { get; set; }
        public int Telefono { get; set; }

        public virtual Cliente IdPersonaNavigation { get; set; }
        public virtual Funcionario RolNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}