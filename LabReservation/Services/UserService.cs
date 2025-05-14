using LabReservation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LabReservation.Services
{
    public class UserService
    {
        private const string FilePath = "Data/Users.json";
        public List<User> LoadAll() =>
            File.Exists(FilePath) ? JsonSerializer.Deserialize<List<User>>(File.ReadAllText(FilePath))! : new();

        public void SaveAll(List<User> data) =>
            File.WriteAllText(FilePath, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));

        public void Register(string username, string password, string role)
        {
            var data = LoadAll();
            if (data.Any(u => u.Username == username))
                throw new Exception("Username sudah terdaftar.");
            data.Add(new User
            {
                Id = data.Count > 0 ? data.Max(u => u.Id) + 1 : 1,
                Username = username,
                Password = password,
                Role = role
            });
            SaveAll(data);
        }

        public User Login(string username, string password)
        {
            var user = LoadAll().FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null) throw new Exception("Login gagal.");
            return user;
        }
    }
}
