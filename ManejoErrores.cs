using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Asicronica
{
    public class ManejoErrores
    {
        public async Task<T> ExecuteAsync<T>(Func<Task<T>> funcion, int maxAttempts=3)
        {
            for (int i = 0; i < maxAttempts; i++)
            {
                try
                {
                    return await funcion();
                }
                catch 
                {
                    if (i == maxAttempts -1)
                        throw;
                    await Task.Delay(1000);

                }
            }
            throw new Exception("No se pudo completar la operación después de varios intentos.");
        }
    }
}
