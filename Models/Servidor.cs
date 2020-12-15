using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCTransparencia.Models
{
    public class Servidor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(130)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(70)]
        public string Cargo { get; set; }

        [Required]
        [MaxLength(120)]
        public string Rendimentos { get; set; }

        [Required]
        [MaxLength(50)]
        public string Rgf { get; set; }
    }
}
