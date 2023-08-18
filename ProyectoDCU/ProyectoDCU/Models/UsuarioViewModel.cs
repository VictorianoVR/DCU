namespace ProyectoDCU.Models
{
    public class UsuarioViewModel
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Celular { get; set; }
        public IFormFile Foto { get; set; }
    }
}