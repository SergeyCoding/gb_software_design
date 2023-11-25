namespace InMemoryModel
{
    public interface IModelChanger
    {
        void NotifyChange(IModelChanger sender);
        void NotifyChange(IModelChanger sender, string info);
    }
}
