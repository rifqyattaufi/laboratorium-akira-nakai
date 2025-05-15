﻿using LabReservation.Domain;
using LabReservation.Services;
using LabReservation.Utils;
using System;
using System.Diagnostics;

class Program
{
    static User? currentUser = null;

    static void Main()
    {
        var userService = new UserService();
        var labService = new LabService();
        var reservationService = new ReservationService();

        while (true)
        {
            if (currentUser == null)
            {
                Console.WriteLine("\n===== SISTEM RESERVASI LABORATORIUM =====");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Register(userService);
                        break;
                    case "2":
                        Login(userService);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Input tidak valid.");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"\n===== Halo, {currentUser.Username} ({currentUser.Role}) =====");
                Console.WriteLine("1. List Laboratorium");
                Console.WriteLine("2. Buat Reservasi");
                Console.WriteLine("3. Lihat Reservasi Saya");

                if (currentUser.Role == "admin")
                {
                    Console.WriteLine("4. Lihat Semua Reservasi");
                    Console.WriteLine("5. Ubah Status Reservasi");
                    Console.WriteLine("6. Tambah Laboratorium");
                    Console.WriteLine("7. Edit Laboratorium");
                    Console.WriteLine("8. Hapus Laboratorium");
                }
                Console.WriteLine("9. Performance Test");
                Console.WriteLine("10. Logout");
                Console.WriteLine("0. Keluar");

                Console.Write("Pilih: ");
                var menu = Console.ReadLine();

                try
                {
                    switch (menu)
                    {
                        case "1":
                            ListLabs(labService);
                            break;
                        case "2":
                            BuatReservasi(labService, reservationService);
                            break;
                        case "3":
                            LihatReservasi(reservationService);
                            break;
                        case "4":
                            if (currentUser.Role == "admin") LihatSemuaReservasi(reservationService);
                            break;
                        case "5":
                            if (currentUser.Role == "admin") UbahStatusReservasi(reservationService);
                            break;
                        case "6":
                            if (currentUser.Role == "admin") TambahLab(labService);
                            break;
                        case "7":
                            if (currentUser.Role == "admin") EditLab(labService);
                            break;
                        case "8":
                            if (currentUser.Role == "admin") HapusLab(labService);
                            break;
                        case "9":
                            Console.WriteLine("Performance test dimulai...");
                            reservationService.SaveAll(new List<Reservation>());
                            labService.SaveAll(new List<Laboratory>());
                            Console.WriteLine("Membuat 1000 reservasi...");
                            var sw1 = new Stopwatch();
                            sw1.Start();
                            for (int i = 0; i < 1000; i++)
                            {
                                reservationService.Create(new Reservation
                                {
                                    UserId = currentUser!.Id,
                                    LabId = 1,
                                    StartTime = DateTime.Now.AddHours(i),
                                    EndTime = DateTime.Now.AddHours(i + 1)
                                });
                            }
                            sw1.Stop();
                            Console.WriteLine($"Performance test Membuat Reservasi selesai dalam {sw1.ElapsedMilliseconds} ms.");
                            Console.WriteLine("Menampilkan semua reservasi...");
                            var sw2 = new Stopwatch();
                            sw2.Start();
                            var data = reservationService.LoadAll();
                            foreach (var r in data)
                            {
                                Console.WriteLine($"#{r.Id} | UserID: {r.UserId} | LabID: {r.LabId} | {r.StartTime:dd MMM HH:mm} - {r.EndTime:HH:mm} | Status: {r.Status}");
                            }
                            sw2.Stop();
                            Console.WriteLine($"Performance test Menampilkan Reservasi selesai dalam {sw2.ElapsedMilliseconds} ms.");
                            Console.WriteLine("Membuat 1000 laboratorium...");
                            var sw3 = new Stopwatch();
                            sw3.Start();
                            for (int i = 0; i < 1000; i++)
                            {
                                labService.AddLab($"Lab {i}", $"Deskripsi Lab {i}");
                            }
                            sw3.Stop();
                            Console.WriteLine($"Performance test Membuat Laboratorium selesai dalam {sw3.ElapsedMilliseconds} ms.");
                            Console.WriteLine("Menampilkan semua laboratorium...");
                            var sw4 = new Stopwatch();
                            sw4.Start();
                            var labs = labService.ListLabs();
                            foreach (var lab in labs)
                            {
                                Console.WriteLine($"[{lab.Id}] {lab.Name} - {lab.Description}");
                            }
                            sw4.Stop();
                            Console.WriteLine($"Performance test Menampilkan Laboratorium selesai dalam {sw4.ElapsedMilliseconds} ms.");
                            Console.WriteLine("Menghapus semua laboratorium...");
                            var sw6 = new Stopwatch();
                            sw6.Start();
                            for (int i = 0; i < 1000; i++)
                            {
                                labService.DeleteLab(i);
                            }
                            sw6.Stop();
                            Console.WriteLine($"Performance test Menghapus Laboratorium selesai dalam {sw6.ElapsedMilliseconds} ms.");
                            Console.WriteLine("-----Testing selesai-----");
                            Console.WriteLine("Menghapus semua reservasi...");
                            reservationService.SaveAll(new List<Reservation>());
                            Console.WriteLine("Menghapus semua laboratorium...");
                            labService.SaveAll(new List<Laboratory>());
                            Console.WriteLine("Semua reservasi dan laboratorium telah dihapus.");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Performance test selesai.");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Hasil performance test:");
                            Console.WriteLine($"Membuat 1000 reservasi: {sw1.ElapsedMilliseconds} ms");
                            Console.WriteLine($"Menampilkan semua reservasi: {sw2.ElapsedMilliseconds} ms");
                            Console.WriteLine($"Membuat 1000 laboratorium: {sw3.ElapsedMilliseconds} ms");
                            Console.WriteLine($"Menampilkan semua laboratorium: {sw4.ElapsedMilliseconds} ms");
                            Console.WriteLine($"Menghapus semua laboratorium: {sw6.ElapsedMilliseconds} ms");
                            Console.WriteLine("--------------------------");
                            break;
                        case "10":
                            currentUser = null;
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ ERROR: {ex.Message}");
                }
            }
        }
    }

    static void Register(UserService userService)
    {
        Console.Write("Username: ");
        var username = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();
        Console.Write("Role (admin/mahasiswa): ");
        var role = Console.ReadLine()?.ToLower();

        if (role != "admin" && role != "mahasiswa")
        {
            Console.WriteLine("Role tidak valid.");
            return;
        }

        userService.Register(username!, password!, role!);
        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login(UserService userService)
    {
        Console.Write("Username: ");
        var username = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();

        currentUser = userService.Login(username!, password!);
        Console.WriteLine("Login berhasil.");
    }

    static void ListLabs(LabService labService)
    {
        var labs = labService.ListLabs();
        Console.WriteLine("\n--- Daftar Laboratorium ---");
        foreach (var lab in labs)
        {
            Console.WriteLine($"[{lab.Id}] {lab.Name} - {lab.Description}");
        }
    }

    static void TambahLab(LabService labService)
    {
        Console.Write("Nama Lab: ");
        var name = Console.ReadLine();
        Console.Write("Deskripsi: ");
        var desc = Console.ReadLine();

        labService.AddLab(name!, desc!);
        Console.WriteLine("Lab berhasil ditambahkan.");
    }

    static void EditLab(LabService labService)
    {
        Console.Write("ID Lab: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.Write("Nama Baru: ");
        var name = Console.ReadLine();
        Console.Write("Deskripsi Baru: ");
        var desc = Console.ReadLine();

        labService.EditLab(id, name!, desc!);
        Console.WriteLine("Lab berhasil diubah.");
    }

    static void HapusLab(LabService labService)
    {
        Console.Write("ID Lab: ");
        int id = int.Parse(Console.ReadLine()!);
        labService.DeleteLab(id);
        Console.WriteLine("Lab berhasil dihapus.");
    }

    static void BuatReservasi(LabService labService, ReservationService reservationService)
    {
        ListLabs(labService);
        Console.Write("ID Lab yang ingin dipesan: ");
        int labId = int.Parse(Console.ReadLine()!);

        Console.Write("Tanggal (yyyy-MM-dd): ");
        var tanggal = DateTime.Parse(Console.ReadLine()!);

        Console.Write("Jam Mulai (HH:mm): ");
        var start = TimeSpan.Parse(Console.ReadLine()!);
        Console.Write("Jam Selesai (HH:mm): ");
        var end = TimeSpan.Parse(Console.ReadLine()!);

        var startTime = tanggal.Add(start);
        var endTime = tanggal.Add(end);

        if (!TimeValidator.IsValidReservationTime(startTime, endTime))
        {
            throw new Exception("Waktu reservasi tidak valid (07:00 - 18:00, tidak boleh bentrok).");
        }

        reservationService.Create(new Reservation
        {
            UserId = currentUser!.Id,
            LabId = labId,
            StartTime = startTime,
            EndTime = endTime
        });

        Console.WriteLine("Reservasi berhasil dibuat!");
    }

    static void LihatReservasi(ReservationService reservationService)
    {
        var data = reservationService.GetByUser(currentUser!.Id);
        Console.WriteLine("\n--- Reservasi Saya ---");
        foreach (var r in data)
        {
            Console.WriteLine($"#{r.Id} | Lab: {r.LabId} | {r.StartTime:dd MMM HH:mm} - {r.EndTime:HH:mm} | Status: {r.Status}");
        }
    }

    static void LihatSemuaReservasi(ReservationService reservationService)
    {
        var data = reservationService.LoadAll();
        Console.WriteLine("\n--- Semua Reservasi ---");
        foreach (var r in data)
        {
            Console.WriteLine($"#{r.Id} | UserID: {r.UserId} | LabID: {r.LabId} | {r.StartTime:dd MMM HH:mm} - {r.EndTime:HH:mm} | Status: {r.Status}");
        }
    }

    static void UbahStatusReservasi(ReservationService reservationService)
    {
        LihatSemuaReservasi(reservationService);
        Console.Write("ID Reservasi yang ingin diubah: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Status baru (approved/rejected): ");
        var status = Console.ReadLine()?.ToLower();

        if (status != "approved" && status != "rejected")
        {
            Console.WriteLine("Status tidak valid.");
            return;
        }

        reservationService.UpdateStatus(id, status);
        Console.WriteLine("Status berhasil diubah.");
    }

}
