namespace task_20_04
{
    internal class Program
    {
        //Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        //• Car
        //• Bike
        //• Bus
        //• Truck
        //• Motorcycle
        //Храните список транспортных средств(можно просто List<VehicleType>).
        //Добавьте метод для подсчёта транспорта определённого типа(например, сколько грузовиков).
        //Реализуйте поиск по типу и вывод информации.
        static void Main(string[] args)
        {
            Vehicle vehicles = new Vehicle();
            vehicles.VehicleAdd(VehicleType.Car);
            vehicles.VehicleAdd(VehicleType.Bike);
            vehicles.VehicleAdd(VehicleType.Bus);
            vehicles.VehicleAdd(VehicleType.Truck);
            vehicles.VehicleAdd(VehicleType.Motorcycle);
            vehicles.VehicleAdd(VehicleType.Car);
            vehicles.VehicleAdd(VehicleType.Car);
            vehicles.VehicleAdd(VehicleType.Bus);

            int count = 0;
            count = vehicles.VehicleCount(VehicleType.Car);
            Console.WriteLine($"Машин: {count}");
            vehicles.FindOf(VehicleType.Bus);
        }
    }
}
