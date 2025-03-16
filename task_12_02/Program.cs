namespace task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создайте проект с классом Cat и Dog, полностью самостоятельно продумайте данные для объектов класса и их
            //функционал

            Cat cat = new Cat();
            cat.Weight();
            cat.tailLenght = 25;
            cat.bodyLenght = 60;
            cat.name = "Мурка";
            cat.Age();

            Console.WriteLine($"Длина хвоста: {cat.tailLenght} см \nДлина тела: {cat.bodyLenght} см \nИмя: {cat.name}");

            Console.WriteLine();

            Dog dog = new Dog();
            dog.Weight();
            dog.tailLenght = 10;
            dog.bodyLenght = 100;
            dog.name = "Шарик";
            dog.Age();

            Console.WriteLine($"Длина хвоста: {dog.tailLenght} см \nДлина тела: {dog.bodyLenght} см \nИмя: {dog.name}");
        }
    }
}
