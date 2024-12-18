using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto2.Models
{

    [Table("Matriculas")]
    public class Matricula
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }  // Relación con la tabla Clientes

        [Required]
        public int HorarioId { get; set; }  // Relación con la tabla Horarios

        public Cliente? Cliente { get; set; }  // Propiedad de navegación
        public Horario? Horario { get; set; }  // Propiedad de navegación

        [Required]
        [MaxLength(100)]
        public string? NombreEntrenador { get; set; }  // Nombre del Entrenador

        [Required]
        [MaxLength(255)]
        public string? PuntoFuerte { get; set; }

       
    }

}