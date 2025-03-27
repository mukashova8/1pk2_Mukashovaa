using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_05
{
    public static class Access
    {
        public static void Rights(AccessLevel level, int n)
        {
            switch (n)
            {
                case 1:
                    if (level >= AccessLevel.Guest)
                        Console.WriteLine("Доступ разрешен: чтение доступно всем");
                    else
                        Console.WriteLine("Доступ запрещен");
                    break;
                case 2:
                    if (level >= AccessLevel.User)
                        Console.WriteLine("Доступ разрешен: чтение и комментарии доступны");
                    else
                        Console.WriteLine("Доступ запрещен");
                    break;
                case 3:
                    if (level >= AccessLevel.Moderator)
                        Console.WriteLine("Доступ разрешен: чтение, комментарии и удаление постов доступны");
                    else
                        Console.WriteLine("Доступ запрещен");
                    break;
                case 4:
                    if (level == AccessLevel.Admin)
                        Console.WriteLine("Разрешен полный доступ");
                    else
                        Console.WriteLine("Доступ запрещен");
                    break;
            }
        }
    }
}
