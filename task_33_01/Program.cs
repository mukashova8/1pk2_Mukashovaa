namespace task_33_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<IDrawable> list = new List<IDrawable>
                   {
                       new Circle(5),
                       new Square(2,7),
                       new Circle(10),
                       new Rectangle(4)

                   };


                foreach (var item in list)
                    item.Draw();
                
                list.Add(new Rectangle(0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
