using InMemoryModel;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software Design");
            Console.WriteLine("Homework 01");

            var modelStore = new ModelStore();

            modelStore.AddObserver(new Observer1());
            modelStore.AddObserver(new Observer2());
        }
    }
}
