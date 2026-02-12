using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programacion_Asicronica;

namespace Programacion_Asicronica
{
    public class IndicadorProgreso
    {
        public async Task MostrarProgreso(List<Task<User>> tasks)
        {
            var tareaCombinada = Task.WhenAll(tasks);

            while (!tareaCombinada.IsCompleted)
            {
                int completados = tasks.Count(t => t.IsCompleted);
                Console.Write($"\rProgreso: {completados}/{tasks.Count} usuarios obtenidos...");
                await Task.Delay(5000);
            }
        }

    }
}
