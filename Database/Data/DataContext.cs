namespace Database.Models
{
    using Database.Data.Entities;
    using Database.ModelsData;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Personas> Personas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Docentes> Docentes { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }
        public DbSet<Archivos> Archivos { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }
        public DbSet<CursosAlumnos> CursosAlumnos { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }
        public DbSet<Barrios> Barrios { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Domicilios> Domicilios { get; set; }
        public DbSet<Agendas> Agendas { get; set; }

    }
}
