using System.Text.Json;
using System.Linq;

namespace Programacion_Asicronica
{
    public class ConexionAPI : IUserService
    {
        private readonly HttpClient _httpClient = new();

        public async Task<List<User>> GetRandomUsersAsync(int cantidad)
        {
            var url = $"https://randomuser.me/api/?results={cantidad}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<RandomUserResponse>(json);

            if (data?.Results == null || !data.Results.Any())
                throw new Exception("No se recibieron usuarios válidos.");

            return data.Results.Select(result => new User
            {
                FullName = $"{result.Name.First} {result.Name.Last}",
                Gender = result.Gender,
                Email = result.Email,
                Country = result.location.Country
            }).ToList();
        }
    }
}
