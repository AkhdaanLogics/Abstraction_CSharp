using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

public class ConvertToXml : ConvertObject
{
    public override void Convert(Mahasiswa mhs)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
        serializer.Serialize(Console.Out, mhs);
        string xml = Console.Out.ToString();
        Console.WriteLine("Hasil konversi ke XML\n");
        Console.WriteLine(xml);
    }
}


