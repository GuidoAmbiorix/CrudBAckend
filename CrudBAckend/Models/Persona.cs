using System.ComponentModel.DataAnnotations.Schema;

namespace CrudBAckend.Models
{
    [Table("Persona")]
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

    }
}
