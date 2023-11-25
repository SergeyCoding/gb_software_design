namespace InMemoryModel
{
    class ModelStore : IModelChanger
    {
        private List<IModelChangeObserver> _observers = new();


        public void NotifyChange(IModelChanger sender)
        {
        }
    }
}
