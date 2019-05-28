
namespace Database.Models
{

    using System;
    using System.Collections.Generic;

    ///Entidad que representa las salas de chat.
    public class Salas
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CodigoAula { get; set; }
        public string NombreSala { get; set; }
        public string DescripcionSala { get; set; }
        //Propietario de la sala y consecuente administrador.
        public Usuarios Propietario { get; set; }
        public List<Usuarios> ListaUsuarios { get; set; }
    }
}