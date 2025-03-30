namespace task_20_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
            //• Red
            //• Yellow
            //• Green
            //Реализуйте автоматическое переключение цветов(каждые 3 секунды).
            //При смене цвета выводите его в консоль(можно с задержкой Thread.Sleep). 
            //Добавьте возможность ручного переключения(например, по нажатию клавиши).

            Traffic traffic = new Traffic();
            traffic.AutoSwitch();
            traffic.ManualSwitch();
        }
    }
}
