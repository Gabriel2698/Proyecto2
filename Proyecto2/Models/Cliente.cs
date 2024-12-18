using System.ComponentModel.DataAnnotations;

namespace Proyecto2.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El nombre no puede superar los 20 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El correo no puede superar los 20 caracteres.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El tipo no puede superar los 20 caracteres.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MaxLength(10, ErrorMessage = "La contraseña no puede superar los 10 caracteres.")]
        public string Contraseña { get; set; }
    }
}

