//using System.Text;
//using System.Text.RegularExpressions;

//namespace Lesson8
//{
//    class classwork
//    {
//        static void Main(string[] args)
//        {
//            //Приклад1
//            string s = "Бик тупогуб, тупогубенький бичок, у бика була біла тупа губа";
//            var regex = new Regex(@"туп(\w*)");
//            MatchCollection matches = regex.Matches(s);

//            if (matches.Count > 0)
//            {
//                foreach (Match match in matches)
//                    Console.WriteLine(match.Value);
//            }
//            else
//            {
//                Console.WriteLine("Співпадінь не знайдено");
//            }



//            ////Приклад2
//            //string s = "Бик Тупогуб, тупогубенький бичок, у бика була біла тупа губа";

//            //Regex regex = new Regex(@"туп(\w*)", RegexOptions.IgnoreCase); //<= ігноруємо регістр (RegexOptions.IgnoreCase)
//            //MatchCollection matches = regex.Matches(s);

//            //if (matches.Count > 0)
//            //{
//            //    foreach (Match match in matches)
//            //        Console.WriteLine(match.Value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Співпадінь не знайдено");
//            //}



//            ////Приклад3            
//            //string s = "456-435-2318";
//            //Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
//            //MatchCollection matches = regex.Matches(s);

//            //if (matches.Count > 0)
//            //{
//            //    foreach (Match match in matches)
//            //        Console.WriteLine(match.Value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Співпадінь не знайдено");
//            //}



//            ////Приклад4
//            //string s = "456-435-2318";
//            //Regex regex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
//            //MatchCollection matches = regex.Matches(s);

//            //if (matches.Count > 0)
//            //{
//            //    foreach (Match match in matches)
//            //        Console.WriteLine(match.Value);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Співпадінь не знайдено");
//            //}


//            ////Приклад5
//            //string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
//            //                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
//            //var data = new string[]
//            //{
//            //    "tom@gmail.com",
//            //    "+12345678999",
//            //    "bob@yahoo.com",
//            //    "+13435465566",
//            //    "sam@ukrnet.ua",
//            //    "+55543989393"
//            //};
//            //Console.WriteLine("Email List");
//            //for (int i = 0; i < data.Length; i++)
//            //{
//            //    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
//            //    {
//            //        Console.WriteLine(data[i]);
//            //    }
//            //}



//            ////Приклад6
//            //string text = "Мама     мила  раму. ";
//            //string pattern = @"\s+";
//            //string target = " ";
//            //Regex regex = new Regex(pattern);
//            //string result = regex.Replace(text, target);
//            //Console.WriteLine(result);


//            ////Приклад7
//            //string unicodeString = "This string contains the unicode character Pi (\u03a0)";

//            //// Create two different encodings.
//            //Encoding ascii = Encoding.ASCII;
//            //Encoding unicode = Encoding.Unicode;

//            //// Convert the string into a byte array.
//            //byte[] unicodeBytes = unicode.GetBytes(unicodeString);

//            //// Perform the conversion from one encoding to the other.
//            //byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

//            //// Convert the new byte[] into a char[] and then into a string.
//            //char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
//            //ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
//            //string asciiString = new string(asciiChars);

//            //// Display the strings created before and after the conversion.
//            //Console.WriteLine("Original string: {0}", unicodeString);
//            //Console.WriteLine("Ascii converted string: {0}", asciiString);



//            ////Приклад8
//            //DriveInfo[] drives = DriveInfo.GetDrives();
//            //foreach (DriveInfo drive in drives)
//            //{
//            //    Console.WriteLine($"Назва: {drive.Name}");
//            //    Console.WriteLine($"Тип: {drive.DriveType}");
//            //    if (drive.IsReady)
//            //    {
//            //        Console.WriteLine($"Об'єм диску: {drive.TotalSize}");
//            //        Console.WriteLine($"Вільне місце: {drive.TotalFreeSpace}");
//            //        Console.WriteLine($"Мітка диску: {drive.VolumeLabel}");
//            //    }
//            //    Console.WriteLine();
//            //}



//            ////Приклад9
//            //string dirName = "C:\\";
//            //// чи папка існує
//            //if (Directory.Exists(dirName))
//            //{
//            //    Console.WriteLine("Підкаталоги:");
//            //    string[] dirs = Directory.GetDirectories(dirName);
//            //    foreach (string s in dirs)
//            //    {
//            //        Console.WriteLine(s);
//            //    }
//            //    Console.WriteLine();
//            //    Console.WriteLine("Файли:");
//            //    string[] files = Directory.GetFiles(dirName);
//            //    foreach (string s in files)
//            //    {
//            //        Console.WriteLine(s);
//            //    }
//            //}



//            ////Приклад10
//            //string dirName = @"C:\";
//            //var directory = new DirectoryInfo(dirName);
//            //if (directory.Exists)
//            //{
//            //    Console.WriteLine("Підкаталоги:");
//            //    DirectoryInfo[] dirs = directory.GetDirectories();
//            //    foreach (DirectoryInfo dir in dirs)
//            //    {
//            //        Console.WriteLine(dir.FullName);
//            //    }
//            //    Console.WriteLine();
//            //    Console.WriteLine("Файли:");
//            //    FileInfo[] files = directory.GetFiles();
//            //    foreach (FileInfo file in files)
//            //    {
//            //        Console.WriteLine(file.FullName);
//            //    }
//            //}



//            ////Приклад11
//            //string dirName = @"C:\";
//            //// класс Directory
//            //string[] dirs = Directory.GetDirectories(dirName, "books*.");
//            //// класс DirectoryInfo
//            //var directory = new DirectoryInfo(dirName);
//            //DirectoryInfo[] dirsInfo = directory.GetDirectories("books*.");


//            ////Приклад12
//            //string dirName = @"C:\";
//            //// класс Directory
//            //string[] files = Directory.GetFiles(dirName, "*.exe");
//            //// класс DirectoryInfo
//            //var directory = new DirectoryInfo(dirName);
//            //FileInfo[] filesInfo = directory.GetFiles("*.exe");



//            ////Приклад13
//            //string path = @"C:\SomeDir";
//            //string subpath = @"program\avalon";
//            //DirectoryInfo dirInfo = new DirectoryInfo(path);
//            //if (!dirInfo.Exists)
//            //{
//            //    dirInfo.Create();
//            //}
//            //dirInfo.CreateSubdirectory(subpath);



//            ////Приклад14
//            //string dirName = @"C:\SomeDir";
//            //DirectoryInfo dirInfo = new DirectoryInfo(dirName);
//            //if (dirInfo.Exists)
//            //{
//            //    dirInfo.Delete(true);
//            //    Console.WriteLine("Каталог видалено");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Каталог не існує");
//            //}



//            ////Приклад15
//            //string path = @"C:\Users\eugene\Documents\content.txt";
//            //// string path = "/Users/eugene/Documents/content.txt";  // для MacOS/Linux
//            //FileInfo fileInfo = new FileInfo(path);
//            //if (fileInfo.Exists)
//            //{
//            //    Console.WriteLine($"Ім'я файлу: {fileInfo.Name}");
//            //    Console.WriteLine($"Час створення: {fileInfo.CreationTime}");
//            //    Console.WriteLine($"Розмір: {fileInfo.Length}");
//            //}



//            ////Приклад16
//            //string path = @"C:\OldDir\content.txt";
//            //string newPath = @"C:\NewDir\index.txt";
//            //FileInfo fileInf = new FileInfo(path);
//            //if (fileInf.Exists)
//            //{
//            //    fileInf.MoveTo(newPath);
//            //    // альтернатива за допомогою класу File
//            //    // File.Move(path, newPath);
//            //}



//            ////Приклад17
//            //string path = @"C:\OldDir\content.txt";
//            //string newPath = @"C:\NewDir\index2.txt";
//            //FileInfo fileInf = new FileInfo(path);
//            //if (fileInf.Exists)
//            //{
//            //    fileInf.CopyTo(newPath, true);
//            //    // альтернатива за допомогою класу File
//            //    // File.Copy(path, newPath, true);
//            //}



//            ////Приклад18
//            //string path = @"C:\app\content.txt";
//            //FileInfo fileInf = new FileInfo(path);
//            //if (fileInf.Exists)
//            //{
//            //    fileInf.Delete();
//            //    // альтернатива за допомогою класу File
//            //    // File.Delete(path);
//            //}
//        }
//    }
//}