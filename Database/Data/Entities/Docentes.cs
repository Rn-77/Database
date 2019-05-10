namespace Database.Models
{

using System.Collections.Generic;

    public class Docentes : Usuarios
	{
		public List<Cursos> Cursos { get; set; }
	}
}
