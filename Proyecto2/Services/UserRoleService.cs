namespace Proyecto2.Services
{
    public class UserRoleService
    {
        // Propiedad UserRole que almacena el rol del usuario
        private string userRole = "Admin"; // Valor predeterminado

        // Propiedad para obtener el rol
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }

        // Método para cambiar el rol
        public void SetUserRole(string role)
        {
            userRole = role;
        }
    }
}