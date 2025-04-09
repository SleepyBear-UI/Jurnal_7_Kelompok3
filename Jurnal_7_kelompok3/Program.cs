// See https://aka.ms/new-console-template for more information
using Jurnal_7_kelompok3;
using System.Text.Json;

public class Program
{
    public static void ReadJSON()
    {
        string filePath = @"C:\tumbal\online\jurnal7_1_103022300113.json";
        string JsonString = File.ReadAllText(filePath);

        DataMahasiswa103022300113cs mhs = JsonSerializer.Deserialize<DataMahasiswa103022300113cs>
            (JsonString);
        Console.WriteLine($"Nama: {mhs.firstName} {mhs.lastName}");
        Console.WriteLine($"Gender: {mhs.gender}");
        Console.WriteLine($"Umur: {mhs.age}");
        Console.WriteLine("Mata Kuliah: ");
        foreach (var course in mhs.courses)
        {
            Console.WriteLine($"-{course.code}: {course.name}");
        }
        Console.WriteLine($"Alamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
        
    }

    public static void Main()
    {
        ReadJSON();
    }
}
