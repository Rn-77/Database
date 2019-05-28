using System;

namespace Database.Models
{
    public class Archivos
    {
        public int Id { get; set; }
        public DateTime FechaEnviado { get; set; }
        public Usuarios Usuario { get; set; }
        public int TipoArchivo { get; set; }
        public string Ruta { get; set; }
       


    }
}
