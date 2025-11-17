using System.ComponentModel.DataAnnotations;

namespace TruequeTextil.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }="";

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; } = "";
        
        [Required(ErrorMessage = "El número telefónico es obligatorio")]
        public string NumeroTelefono { get; set; } = "";
        
        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        public string CorreoElectronico { get; set; } = "";

        public bool Editando = false;
    }
}

