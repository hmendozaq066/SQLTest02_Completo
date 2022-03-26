using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTest02.Models
{
    public class Actividad
    {
        [Key]
        [Display(Name = "#")]
        public int Actividad_id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1024)]
        public string Detalles { get; set; }

        [Display(Name = "Resuelto")]
        public bool Resuelto { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public int Estado_id { get; set; }

        [ForeignKey("Estado_id")]
        public Estado Estado { get; set; }
    }
}
