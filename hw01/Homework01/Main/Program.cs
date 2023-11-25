using InMemoryModel;
using ModelElements;

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

            modelStore.Models.Add(new PoligonalModel());
            modelStore.Cameras.Add(new Camera());
            modelStore.Flashes.Add(new Flash());
            modelStore.Scenes.Add(new Scene());
            modelStore.Scenes.Add(new Scene());
            modelStore.Scenes.Add(new Scene());
            modelStore.Scenes.Clear();
        }
    }
}
