using System.ComponentModel.DataAnnotations;

namespace TareasMvc.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Descripcion { get; set; }

        public bool Completada { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
