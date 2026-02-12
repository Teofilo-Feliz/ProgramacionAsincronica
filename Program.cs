using Programacion_Asicronica;

class Program
{
 
    static async Task Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("     Random User Console App     ");
        Console.WriteLine("=================================\n");

        var menu = new Menu();
        IUserService service = new ConexionAPI();

        bool continuar = true;

        while (continuar)
        {
            int cantidad = menu.SolicitudCant();

            try
            {
                var users = await service.GetRandomUsersAsync(cantidad);

                foreach (var user in users)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Nombre: {user.FullName}");
                    Console.WriteLine($"Género: {user.Gender}");
                    Console.WriteLine($"Email:  {user.Email}");
                    Console.WriteLine($"País:   {user.Country}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
            }

            continuar = menu.AgregarUsuario();
        }

        Console.WriteLine("Aplicación finalizada.");
    }

}
