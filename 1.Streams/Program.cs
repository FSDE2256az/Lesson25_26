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

/// 1. Create                        --> File yoxdursa yaradir, varsa silir yeniden yazir
/// 2. Append                        --> File-in sonuna elave edir
/// 3. CreateNew                --> Eger file yoxdursa yaradir, varsa Exception atir
/// 4. Open                                --> Eger file varsa acir, yoxdursa Exception atir
/// 5. OpenOrCreate                --> Varsa acir, yoxdursa yaradir
/// 6. Truncate                        --> File varsa icerisini silir, melumatlari 0-dan yazir. Yoxdursa Exception atir




public class Program
{
    static void Main(string[] args)
    {

       
       
       

       

       

       



    }
}
