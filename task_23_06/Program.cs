using System.IO;
namespace task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу со следующими функциями:
            //1.Выведите информации о всех дисках в системе
            //2.Выведите содержимое каталога C: \Users(названия папок)
            //3.Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            //a) Создание вложенного каталога “temp”
            //b) Вывод информации о текущем каталоге(имя, родитель и тд)
            //c) Вывод информации о вложенном каталоге
            //4.Переместите каталог “temp” по пути “D:\work\newTemp”
            //a) Реализуйте вывод информационного сообщения об успешном(или нет)
            //перемещении
            //5.Удалите каталог “D:\work\temp” и выведите сообщение об успешном(или нет)
            //удалении.

            //1
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();

            Console.WriteLine("Диски, в текущей системе:\n");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"{drive.Name}: Размер диска: {drive.TotalSize / 1024 / 1024 / 1024} ГБ"
                                  + $"\t Доступное место на диске: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} ГБ\n"
                                  + $"Тип диска{drive.DriveType} \n"
                                  + $"Метка диска{drive.VolumeLabel}\n");
            }
            Console.WriteLine("\n");

            //2
            string pathName = @"C:\Users";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Каталоги в папке {pathName}");

                List<string> list = Directory.GetDirectories(pathName).ToList();

                if (list.Count > 0)
                {
                    int n = 1;
                    foreach (string s in list)
                    {
                        Console.WriteLine(n + ": " + s);
                        n++;
                    }
                }
                else
                {
                    Console.WriteLine("Нет вложенных каталогов");
                }
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
            Console.WriteLine("\n");

            //3
            pathName = @"C:\D\";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Каталог {pathName}");
                string work = $"{pathName}work";
                Directory.CreateDirectory(work);
                Console.WriteLine($"Каталог {work} успешно создан\n");

                //a)
                if (Directory.Exists(work))
                {
                    Console.WriteLine($"Каталог {work}");
                    string temp = Path.Combine(work, "temp");
                    Directory.CreateDirectory(temp);
                    Console.WriteLine($"Вложенный каталог {temp} успешно создан.");


                    // b) 
                    DirectoryInfo workDirInfo = new DirectoryInfo(work);
                    Console.WriteLine($"\nИнформация о каталоге '{work}':");
                    Console.WriteLine($"Имя: {workDirInfo.Name}");
                    Console.WriteLine($"Родительский каталог: {workDirInfo.Parent.FullName}");

                    // c) 
                    DirectoryInfo tempDirInfo = new DirectoryInfo(temp);
                    Console.WriteLine($"\nИнформация о вложенном каталоге '{temp}':");
                    Console.WriteLine($"Имя: {tempDirInfo.Name}");
                    Console.WriteLine($"Родительский каталог: {tempDirInfo.Parent.FullName}");

                    //4
                    string newTempPath = Path.Combine(work, "newTemp");

                    if (Directory.Exists(temp))
                    {
                        Directory.Move(temp, newTempPath);
                        Console.WriteLine($"\nКаталог '{temp}' успешно перемещён в '{newTempPath}'.");
                    }

                    //5
                    if (Directory.Exists(temp))
                    {
                        Directory.Delete(temp, recursive: true);
                        Console.WriteLine($"\nКаталог '{temp}' успешно удален.");
                    }
                    else
                    {
                        Console.WriteLine($"\nКаталог {temp} не существует");
                    }
                }
            }
        }
    }
}
