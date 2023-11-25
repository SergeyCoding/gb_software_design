using InMemoryModel;

namespace Main
{
    class Observer1 : IModelChangeObserver
    {
        public void ApplyUpdateModel()
        {
            Console.WriteLine("Observer1 реагирует на изменения ...");
        }
    }
}
