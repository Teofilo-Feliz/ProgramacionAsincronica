using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Asicronica
{
    public class Menu
    {
        public int SolicitudCant()
        {
            int cantidad;
            Console.WriteLine("Ingrese la cantidad de usuarios que desea obtener: ");
            while (!int.TryParse(Console.ReadLine(), out  cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número mayor que 0 y que sea entero ");
                
            }

            return cantidad;

        }

        public bool AgregarUsuario()
        {
            Console.WriteLine("¿Desea agregar un nuevo usuario? (s/n)");
            string respuesta = Console.ReadLine()!.Trim().ToLower();
            return respuesta == "s" || respuesta == "si";
        }
    }
}
