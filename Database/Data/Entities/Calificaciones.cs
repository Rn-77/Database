namespace Database.Models
{
    using Database.ModelsData;
    using System;
    public class Calificaciones
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Alumnos Alumno { get; set; }
        public int TipoCalificacion { get; set; }
        public decimal Calificacion { get; set; }
        public Cursos Curso { get; set; }
        public string  Observaciones { get; set; }


    }
}
