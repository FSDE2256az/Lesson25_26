using _1.Streams.Models;
using System.Text;

namespace _1.Streams;

// Stream => melumat axini. Biz melumatlari bir yerden diger yere 'byte'-lar seklinde gonderirik


// Stream-lerin novleri:

// 1. FileStream => File-a melumat yazmaq ucundur
// 2. Memory Stream => 2 GB
// 3. Network Stream => internet uzerinden protokol ile melumat gondermek ( Http, Https )
// 4. UnmanagedMemoryStream => Olcu limiti yoxdur
// 5. PipeStream => Thread-ler arasi melumatlar gondermek ucundur
// 6. Cripto Stream => Melumatlari Sifreleyib gondermek ucundur
// 7. Buffered Stream => Derived Classdir

////////////////////////////////////
/// Helper or Adapter class 

// 1. TextWriter, TextReader => abstract class
// 2. StreamWriter, StreamReader
// 3. BinaryWriter, BinaryReader => binary formatindadir
// 4. XmlWriter, XmlReader => xml formatindadir


// Json vs Xml 


// Application-in Run edilmis veziyeti proses adlanir.


////////////////////////////////////////////////////
// ---- File, Directory, Path ----

/// 1. File 
/// 2. FileInfo             -> File haqqinda melumatlar 
/// 3. Directory 
/// 4. DirectoryInfo        -> Folder haqqinda melumatlara baxmaq
/// 5. Path 

// "C:\Users\karimzade_k\source\repos\Lesson25_26\Lesson25_26\Extentions\"

////////////////////////////////////////////////////
// ---- File Mode ----

/// 1. Create         --> File yoxdursa yaradir, varsa silir yeniden yazir
/// 2. Append         --> File-in sonuna elave edir
/// 3. CreateNew      --> Eger file yoxdursa yaradir, varsa Exception atir
/// 4. Open           --> Eger file varsa acir, yoxdursa Exception atir
/// 5. OpenOrCreate   --> Varsa acir, yoxdursa yaradir
/// 6. Truncate       --> File varsa icerisini silir, melumatlari 0-dan yazir. Yoxdursa Exception atir


public class Program
{
    static void Main(string[] args)
    {

        // File strame 

        // // Example

        // FileStream fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write, FileShare.None);
        // 
        // fs.Flush(); // Bu yazdiqlarini yadda saxlayir
        // fs.Close(); // File-i baglayir
        // fs.Dispose(); // Elaqeni kesir


        ////////////////////////////////////////////////////////////////////////
        /// FileStream with using ( Write )

        // using (var fs = new FileStream("text.txt", FileMode.Create))
        // {
        //     Console.WriteLine("Enter some text: ");
        // 
        //     string str = Console.ReadLine();
        // 
        //     // fs.Write(str); // Yazsaq olmur, bizden Byte[] isteyir
        // 
        //     byte[] buffer = Encoding.UTF8.GetBytes(str);
        // 
        //     fs.Write(buffer, 0, buffer.Length);
        // 
        //     // File exe hardadirsa onun yaninda yaranacaq
        // }

        ////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////
        /// FileStream ( Read )

        // using (var fs = new FileStream("text.txt", FileMode.Open))
        // {
        //     byte[] buffer = new byte[fs.Length]; // Stream aciqdi deye olur
        // 
        //     fs.Read(buffer, 0, buffer.Length);
        // 
        //     string str = Encoding.UTF8.GetString(buffer);
        // 
        //     Console.WriteLine(str);
        // }

        ////////////////////////////////////////////////////////////////////////


        /// Write with StreamWriter ( Adapter )

        /// Way 1

        // using (var fs = new FileStream("test.txt", FileMode.OpenOrCreate))
        // {
        //     StreamWriter streamWriter = new StreamWriter(fs);
        // 
        //     streamWriter.WriteLine("Kamran");
        //     streamWriter.WriteLine("Karimzada");
        // 
        //     streamWriter.Close(); // yazmasam yadda saxlamir
        // }


        /// Way 2 -> Close etmemek ucun, usinng ozu Close, Dispose arxada cagirir

        // using FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate);
        // using StreamWriter streamWriter = new StreamWriter(fs);
        // 
        // 
        // streamWriter.WriteLine("Kamran1");
        // streamWriter.WriteLine("Karimzada1");

        ////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////
        //// StreamWriter ile Class yazmaq

        // using FileStream fs = new FileStream("book.txt", FileMode.OpenOrCreate);
        // using StreamWriter streamWriter = new StreamWriter(fs);
        // 
        // var books = new List<Book>()
        //  {
        //          new Book(1, "Kamran", "C#", "Education"),
        //          new Book(2, "Albahari", "C# Core", "Education"),
        //  };
        // 
        // //books.ForEach(x => Console.WriteLine(x));
        // 
        // // Yazmaq
        // books.ForEach(x => streamWriter.WriteLine(x));

        ////////////////////////////////////////////////////////////////////////

        // Adi melumati oxumaq
        // using StreamReader streamWriter1 = new StreamReader("text.txt");
        // Console.WriteLine(streamWriter1.ReadLine());

        ////////////////////////////////////////////////////////////////////////


        //////////
        /// Binary kimi yazmaq ve oxumaq


        // Write
        // using FileStream fileStream = new FileStream("some.bin", FileMode.Create);
        // using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        //
        // binaryWriter.Write("Kamran");
        // binaryWriter.Write("Karimzada");
        // binaryWriter.Write("26");

        // // Read
        // using FileStream fileStreamRead = new FileStream("some.bin", FileMode.Open);
        // using BinaryReader binaryReader = new BinaryReader(fileStreamRead);
        // 
        // Console.WriteLine(binaryReader.ReadString());
        // Console.WriteLine(binaryReader.ReadString());
        // Console.WriteLine(binaryReader.ReadString());

        ////////////////////////////////////////////////////////////////////////////////////////////////

        //// Folder yaratmaq

        // Directory.CreateDirectory("C:\\Users\\k.karimzada\\Desktop\\Folder1");
        // Directory.CreateDirectory("C:/Users/k.karimzada/Desktop/Folder2");
        // Directory.CreateDirectory(@"C:\Users\k.karimzada\Desktop\Folder3");
        // Directory.CreateDirectory(@$"C:\Users\{Environment.UserName}\Desktop\Folder4"); // UserName-i dinamik yaziriq
        // Directory.CreateDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Folder5"); // Desktopun path-in dinamik aliriq

        // Directory.Delete(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Folder5"); // Silirik

        ////////////////////////////////////////////////////////////////////////////////////////////////

        /// Directory Info

        //  DirectoryInfo directoryInfo = new(Directory.GetCurrentDirectory()); // Oldugu yer
        //  DirectoryInfo directoryInfo2 = new("."); // Oldugu yer
        //  DirectoryInfo directoryInfo3 = new(@$"C:\Users\{Environment.UserName}\Desktop");
        // 
        //  foreach (FileInfo file in directoryInfo.GetFiles())  // File-larin adlarini qaytarir
        //      Console.WriteLine(file.Name);
        // 
        // 

        // foreach (DirectoryInfo directory in directoryInfo.GetDirectories()) // Icersinde olan Folder-leri aliriq
        // {
        //     Console.WriteLine(directory.Root);          // C diski
        //     Console.WriteLine(directory.Parent);        // Hansi folder icerisindedir
        //     Console.WriteLine(directory.FullName);      // Fullname
        // }


        // . ile arxaya qabaga getmek

        // //DirectoryInfo directoryInfo = new(".");           // Oldugu yer
        // //DirectoryInfo directoryInfo = new("..");          // 1 Papka arxaya
        // DirectoryInfo directoryInfo = new("../../..");      // /.. yene 1 papka yere
        // // DirectoryInfo directoryInfo = new("./Images");   // Ireli getmek
        // // DirectoryInfo directoryInfo = new("Images/");    // Ireli getmek

        ////////////////////////////////////////////////////////////////////////////////////////////////
        /// File, FileInfo


        // File.WriteAllText("file.txt", "content");
        // var str = File.ReadAllText("file.txt");
        // Console.WriteLine(str);

        // 
        // Console.WriteLine(File.Exists("file.txt")); // Yoxlayirki var ya yox


        // FileInfo fileInfo = new("file.txt"); // Static olmayan versiya
        // 
        // 
        // Console.WriteLine(fileInfo.Extension);
        // Console.WriteLine(fileInfo.Name);
        // Console.WriteLine(fileInfo.CreationTime);
        // Console.WriteLine(fileInfo.Length);
        // Console.WriteLine(fileInfo.DirectoryName);
        // Console.WriteLine(fileInfo.Exists);

        ////////////////////////////////////////////////////////////////////////////////////////////////

        /// Path

        // string extension = ".txt";
        // string filename = "example";
        // 
        // string fullFilename = filename + extension;
        // 
        // 
        // var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fullFilename);
        // 
        // Console.WriteLine(path);

        ////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
