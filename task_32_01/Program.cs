namespace task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<Obstacle> obstacles = new List<Obstacle>
            {
                new Hare(),
                new Pit(),  // Новое препятствие
                new Wolf(),
                new Tree(), // Новое препятствие
                new Bear(),
                new Wall(), // Новое препятствие
                new Fox()
            };

            foreach (var obstacle in obstacles)
            {
                if (!kolobok.IsAlive)
                {
                    break;
                }

                kolobok.Roll();
                kolobok.MeetObstacle(obstacle);
            }

            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior.NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}
