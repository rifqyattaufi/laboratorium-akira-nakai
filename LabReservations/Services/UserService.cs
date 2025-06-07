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

        public void SaveAll(List<User> data)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
            File.WriteAllText(FilePath, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));
        }

        public bool Register(string username, string password, string role)
        {
            var data = LoadAll();
            if (data.Any(u => u.Username == username))
                return false;
            data.Add(new User
            {
                Id = data.Count > 0 ? data.Max(u => u.Id) + 1 : 1,
                Username = username,
                Password = password,
                Role = role
            });
            SaveAll(data);

            return true;
        }

        public User? Login(string username, string password)
        {
            var user = LoadAll().FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null) return null;
            return user;
        }
    }
}
