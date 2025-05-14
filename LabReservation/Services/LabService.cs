using System.Text.Json;
public class LabService
{
    private const string FilePath = "Data/Labs.json";
    public List<Laboratory> LoadAll() =>
        File.Exists(FilePath) ? JsonSerializer.Deserialize<List<Laboratory>>(File.ReadAllText(FilePath))! : new();

    public void SaveAll(List<Laboratory> data) =>
        File.WriteAllText(FilePath, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));

    public void AddLab(string name, string desc)
    {
        var data = LoadAll();
        data.Add(new Laboratory
        {
            Id = data.Count > 0 ? data.Max(l => l.Id) + 1 : 1,
            Name = name,
            Description = desc
        });
        SaveAll(data);
    }

    public void EditLab(int id, string name, string desc)
    {
        var data = LoadAll();
        var lab = data.FirstOrDefault(l => l.Id == id);
        if (lab == null) throw new Exception("Lab tidak ditemukan.");
        lab.Name = name;
        lab.Description = desc;
        SaveAll(data);
    }

    public void DeleteLab(int id)
    {
        var data = LoadAll();
        var lab = data.FirstOrDefault(l => l.Id == id);
        if (lab != null)
        {
            data.Remove(lab);
            SaveAll(data);
        }
    }

    public List<Laboratory> ListLabs() => LoadAll();
}