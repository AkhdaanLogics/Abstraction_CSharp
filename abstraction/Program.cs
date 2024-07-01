using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mhs = new Mahasiswa();
        mhs.npm = "23.11.5654";
        mhs.nama = "Muhammad Akhdaan";
        mhs.email = "akhdaan@students.amikom.ac.id";

        Console.WriteLine("Pilih format konversi data");
        Console.WriteLine("1. XML");
        Console.WriteLine("2. JSON");
        Console.WriteLine("3. CSV");
        Console.Write("Pilihan: ");
        int pilihan = int.Parse(Console.ReadLine());

        ConvertObject convert;

        if (pilihan == 1)
        {
            convert = new ConvertToXml();
        }
        else if (pilihan == 2)
        {
            convert = new ConvertToJson();
        }
        else
        {
            convert = new ConverToCsv();
        }
        convert.Convert(mhs);
    }
}

