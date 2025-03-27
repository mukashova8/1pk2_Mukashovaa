using System.Reflection.Emit;

namespace task_20_05
{
    internal class Program
    {
        //Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        //• Guest(только чтение)
        //• User(чтение + комментарии)
        //• Moderator(удаление контента)
        //• Admin(полный доступ)
        //Создайте метод, который проверяет, может ли пользователь выполнить действие(например, удалить пост).
        //На основе уровня доступа выводите сообщение(например,"Ошибка: Недостаточно прав!")
        static void Main(string[] args)
        {
            int level;
            int n;
            Console.WriteLine("Выберите, кто Вы: \n1. Гость \n2. Пользователь \n3. Модератор \n4. Админ");
            while (!int.TryParse(Console.ReadLine(), out level))
            {
                Console.WriteLine("Введите снова");
            }
            AccessLevel accessLevel = AccessLevel.Guest;
            switch (level)
            {
                case 1:
                    accessLevel = AccessLevel.Guest;
                    break;
                case 2:
                    accessLevel = AccessLevel.User;
                    break;
                case 3:
                    accessLevel = AccessLevel.Moderator;
                    break;
                case 4:
                    accessLevel = AccessLevel.Admin;
                    break;
            }
            Console.WriteLine("Выберите, что Вам нужно: \n1. только чтение \n2. чтение + комментарии \n3. удаление контента \n4. полный доступ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введите снова");
            }
            Access.Rights(accessLevel, n);

        }
    }
}
