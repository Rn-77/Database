using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Data.Entities
{
    public class Agendas
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string TituloEvento { get; set; }
        public string DetalleEvento { get; set; }
        //Estado : Completado - Pendiente
        public bool Estado { get; set; }

        public Usuarios Usuario { get; set; }

    }
}
