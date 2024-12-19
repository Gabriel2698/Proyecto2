namespace Proyecto2.Services
{
    public class UserRoleService
    {
        public string UserRole { get; private set; } = string.Empty;

        // Método para establecer el rol del usuario
        public void SetUserRole(string role)
        {
            UserRole = role;
        }

        // Método para verificar si el usuario tiene acceso a una página
        public bool CanAccessPage(string pageName)
        {
            return UserRole switch
            {
                "Admin" => true, // Admin tiene acceso a todas las páginas
                "Cliente" => pageName == "Metricas" || pageName == "Matriculas", // Cliente tiene acceso solo a estas páginas
                "Entrenador" => pageName == "Facturas" || pageName == "BuscarMatriculas" || pageName == "Horarios", // Entrenador tiene acceso a estas páginas
                _ => false // Si no hay rol, no tiene acceso a nada
            };
        }
    }
}
