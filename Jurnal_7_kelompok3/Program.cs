using System.IO;
using System.Net;
using System.Text.Json;

class DatMahasiswa_103022300123
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103022300123.json");
        Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        Console.WriteLine("nama depan   : " + mahasiswa.firstName);
        Console.WriteLine("nama belakang: " + mahasiswa.lastName);
        Console.WriteLine("gender       : " + mahasiswa.gender);
        Console.WriteLine("umur         : " + mahasiswa.age);
        Console.WriteLine("jalan        : " + mahasiswa.address.streetAddress);
        Console.WriteLine("kota         : " + mahasiswa.address.city);
        Console.WriteLine("negara       : " + mahasiswa.address.state);

        Courses courses = JsonSerializer.Deserialize<Courses>(jsonString);
        List<Courses> Courses = mahasiswa.courses;
        for (int i = 0; i < mahasiswa.courses.Count; i++)
        {
            Console.WriteLine("nama : " + mahasiswa.courses[i].code);
            Console.WriteLine("nama : " + mahasiswa.courses[i].name);
        }
    }
}

class Mahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Courses> courses { get; set; }

    public Mahasiswa(string firstName, string lastName, string gender, int age,
        Address address, List<Courses> courses)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.address = address;
        this.courses = courses;
    }
}

class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }

    public Address(string streetAddress, string city, string state)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
    }
}

class Courses
{
    public string code { get; set; }
    public string name { get; set; }

    public Courses(string code, string name)
    {
        this.code = code;
        this.name = name;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DatMahasiswa_103022300123 dataMahasiswa = new DatMahasiswa_103022300123();
        dataMahasiswa.ReadJSON();
        Console.ReadLine();
    }
}