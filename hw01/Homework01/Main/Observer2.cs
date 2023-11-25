using InMemoryModel;

namespace Main
{
    class Observer2 : IModelChangeObserver
    {
        public void ApplyUpdateModel()
        {
            Console.WriteLine("Observer2 реагирует на изменения ...");
        }

        public void ApplyUpdateModel(string info)
        {
            Console.WriteLine($"Observer2: {info}");
        }
    }
}
