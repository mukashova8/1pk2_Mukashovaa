using task_12_01.Publications;

namespace task_12_01
{
    internal class Program
    {
        //в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
        //дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса:
        //покупка журнала
        //просмотр содержания журнала
        //в этом же проекте реализуйте класс Newspaper(газета) со следующими данными:
        //дата издания, название газеты, заголовок главной полосы, количество страниц, цена
        //функционал класса:
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            // возврат книги
            book2.ReturnBook();
            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            Console.WriteLine();

            Journal journal1 = new Journal();
            journal1.title = "Непоседа";
            journal1.date = new DateTime(2015, 7, 20);
            journal1.price = 45;
            journal1.tema = "Детский";
            journal1.countOfStr = 123;
            journal1.View();
            journal1.Buy();

            Console.WriteLine();

            Newspaper newspaper1 = new Newspaper();
            newspaper1.date = new DateTime(2008, 3, 26);
            newspaper1.title = "Новости Оренбург";
            newspaper1.heading = "Новости дня";
            newspaper1.countOfStr = 10;
            newspaper1.price = 50;
            newspaper1.GetInformation();
            newspaper1.ToTakeTheFlourFactory();

        }
    }
}