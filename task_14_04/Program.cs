namespace task_14_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определите класс User, который будет иметь статическое свойство CurrentUser,
            //представляющее текущегопользователя, и метод для его установки.
            User.CurrentUser = "Алина";
            Console.WriteLine(User.CurrentUser);
        }
    }
}
