namespace Programacion_Asicronica
{
    public class ImprimirUsuarios
    {
        public void PrintUsers(List<User> users)
        {
            Console.WriteLine("\nUsuarios obtenidos:\n");

            foreach (var user in users)
            {
                Console.WriteLine($"Nombre: {user.FullName}");
                Console.WriteLine($"Género: {user.Gender}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"País: {user.Country}");
                Console.WriteLine("---------------------------------");
            }
        }
    }
   
 }

