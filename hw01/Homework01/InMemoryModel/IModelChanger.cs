namespace InMemoryModel
{
    interface IModelChanger
    {
        void NotifyChange(IModelChanger sender);
    }
}
