using System;
using System.IO;
using Newtonsoft.Json;

public class ConvertToJson : ConvertObject
{
    public override void Convert(Mahasiswa mhs)
    {
        string json = JsonConvert.SerializeObject(mhs);
        Console.WriteLine("Hasil konversi ke JSON\n");
        Console.WriteLine(json);
    }
}

