using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Asicronica
{
    public interface IUserService
    {
        Task<List<User>> GetRandomUsersAsync(int cantidad);
    }

}
