using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto2.Models
{
    public class Horario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del entrenador es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre del entrenador no puede superar los 100 caracteres.")]
        public string? NombreEntrenador { get; set; }

        [Required(ErrorMessage = "El horario de clase es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El horario de clase no puede superar los 100 caracteres.")]
        public string? HorarioClase { get; set; }

        [Required(ErrorMessage = "El punto fuerte de la clase es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El punto fuerte no puede superar los 50 caracteres.")]
        public string? PuntoFuerte { get; set; }

       
    }
}
