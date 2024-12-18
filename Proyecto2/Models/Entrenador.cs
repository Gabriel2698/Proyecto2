using System.ComponentModel.DataAnnotations;

namespace Proyecto2.Models
{
    public class Entrenador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El correo no puede superar los 100 caracteres.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El tipo no puede superar los 50 caracteres.")]
        public string? Tipo { get; set; }

        [Required(ErrorMessage = "Los puntos fuertes son obligatorios.")]
        [MaxLength(100, ErrorMessage = "Los puntos fuertes no pueden superar los 100 caracteres.")]
        public string ? PuntosFuertes { get; set; }
    }
}
