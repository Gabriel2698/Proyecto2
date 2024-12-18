using System.ComponentModel.DataAnnotations;

namespace Proyecto2.Models
{
    public class Metrica
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El pecho es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El pecho debe ser mayor a 0.")]
        public decimal Pecho { get; set; }

        [Required(ErrorMessage = "La espalda es obligatoria.")]
        [Range(0, double.MaxValue, ErrorMessage = "La espalda debe ser mayor a 0.")]
        public decimal Espalda { get; set; }

        [Required(ErrorMessage = "La pierna es obligatoria.")]
        [Range(0, double.MaxValue, ErrorMessage = "La pierna debe ser mayor a 0.")]
        public decimal Pierna { get; set; }

        [Required(ErrorMessage = "El bicep es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El bicep debe ser mayor a 0.")]
        public decimal Bicep { get; set; }

        [Required(ErrorMessage = "El tricep es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El tricep debe ser mayor a 0.")]
        public decimal Tricep { get; set; }
    }
}
