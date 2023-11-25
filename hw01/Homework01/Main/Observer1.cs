using InMemoryModel;

namespace Main
{
    class Observer1 : IModelChangeObserver
    {
        public void ApplyUpdateModel()
        {
            Console.WriteLine("Observer1 реагирует на изменения ...");
        }

        public void ApplyUpdateModel(string info)
        {
            Console.WriteLine($"Observer1: {info}");
        }
    }
}
