using System.ComponentModel.DataAnnotations;

namespace SaludAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string PrimerApeliido { get; set; }
        public string? SegundoApellido { get; set; }
        
    }
}
