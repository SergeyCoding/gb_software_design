namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software Design");
            Console.WriteLine("Homework 01");

            Console.WriteLine("Описание проблемы:" +
                "Есть класс Summator." +
                "Вносить изменения в этот класс нельзя." +
                "Требуется добавить логирование до и после вызовов метода Execute," +
                "Воспользуемся паттерном Декоратор");


            var summator = new WrapperSummator(1, 2);

            var value = summator.GetResult();

            Console.WriteLine($"Результат: {value}");
        }
    }
}
