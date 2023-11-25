using InMemoryModel;

namespace Main
{
    class Observer2 : IModelChangeObserver
    {
        public void ApplyUpdateModel()
        {
            Console.WriteLine("Observer2 реагирует на изменения ...");
        }
    }
}
