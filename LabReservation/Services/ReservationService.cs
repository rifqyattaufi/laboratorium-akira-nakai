using System.Text.Json;
public class Reservation {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int LabId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; } // pending, approved, rejected
}

public class ReservationService {
    private const string FilePath = "Data/Reservations.json";
    public List<Reservation> LoadAll() =>
        File.Exists(FilePath) ? JsonSerializer.Deserialize<List<Reservation>>(File.ReadAllText(FilePath))! : new();

    public void SaveAll(List<Reservation> data) =>
        File.WriteAllText(FilePath, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));

    public void Create(Reservation newRes) {
        var data = LoadAll();
        if (data.Any(r => r.LabId == newRes.LabId &&
                          ((newRes.StartTime < r.EndTime) && (newRes.EndTime > r.StartTime)))) {
            throw new Exception("Jadwal bentrok dengan reservasi lain.");
        }

        newRes.Id = data.Count > 0 ? data.Max(r => r.Id) + 1 : 1;
        newRes.Status = "pending";
        data.Add(newRes);
        SaveAll(data);
    }

    public List<Reservation> GetByUser(int userId) =>
        LoadAll().Where(r => r.UserId == userId).ToList();

    public void Cancel(int reservationId, int userId) {
        var data = LoadAll();
        var res = data.FirstOrDefault(r => r.Id == reservationId && r.UserId == userId);
        if (res == null) throw new Exception("Reservasi tidak ditemukan.");
        res.Status = "cancelled";
        SaveAll(data);
    }
}
