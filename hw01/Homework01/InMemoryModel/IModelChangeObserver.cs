namespace InMemoryModel
{
    public interface IModelChangeObserver
    {
        void ApplyUpdateModel();
        void ApplyUpdateModel(string info);

    }
}
