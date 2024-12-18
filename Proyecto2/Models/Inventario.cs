using System.ComponentModel.DataAnnotations;

namespace Proyecto2.Models
{
    public class Inventario
    {
        
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre de la máquina es obligatorio.")]
            [MaxLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
            public string? NombreMaquina { get; set; }

            [Required(ErrorMessage = "La vida útil es obligatoria.")]
            [MaxLength(50, ErrorMessage = "La vida útil no puede superar los 50 caracteres.")]
            public string ?VidaUtil { get; set; }

            [Required(ErrorMessage = "La fecha de compra es obligatoria.")]
            public DateTime FechaCompra { get; set; }
        }
    }