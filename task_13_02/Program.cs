namespace task_13_02
{
    internal class Program
    {
        //создать класс питомца
        //свойства:
        //кличка, вид животного, возраст, вес, отметка о состонии здоровья(здоров/нездоров)
        //методы:
        //вывод информации об объекте
        //изменение значения веса животного
        //изменение отметки о состоянии здоровья
        //конструторы:
        //предусмотрите разные варианты инициализации объектов
        static void Main(string[] args)
        {
            Pet pet = new Pet("Мурка", "Кошка");
            pet.Age = 2;
            pet.Weight = 6;
            pet.IsHealth = false;
            pet.GetInfo();
            pet.ChangeWeight(5);
            pet.ChangeHealht();

            Console.WriteLine();

            Pet pet1 = new Pet("Бобик", "Собка", 5, 40, true);
            pet1.GetInfo();
            pet1.ChangeWeight(50);
            pet1.ChangeHealht();

        }
    }
}
