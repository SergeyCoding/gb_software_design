using ModelElements;
using System.Collections.ObjectModel;

namespace InMemoryModel
{
    public class ModelStore : IModelChanger
    {
        private readonly List<IModelChangeObserver> _changeObservers = [];

        public ObservableCollection<PoligonalModel> Models { get; } = [];
        public ObservableCollection<Scene> Scenes { get; } = [];
        public ObservableCollection<Flash> Flashes { get; } = [];
        public ObservableCollection<Camera> Cameras { get; } = [];

        public ModelStore()
        {
            Models.CollectionChanged += (_, _) => NotifyChange(this, "изменение в коллекции моделей");
            Scenes.CollectionChanged += (_, _) => NotifyChange(this, "изменение в коллекции сцен");
            Flashes.CollectionChanged += (_, _) => NotifyChange(this, "изменение в коллекции осветителей");
            Cameras.CollectionChanged += (_, _) => NotifyChange(this, "изменение в коллекции камер");
        }


        public Scene? GetScena(int Id)
        {
            return Scenes.FirstOrDefault(x => x.Id == Id);

        }
        public void AddObserver(IModelChangeObserver observer) => _changeObservers.Add(observer);

        public void NotifyChange(IModelChanger sender)
        {
            foreach (var item in _changeObservers)
            {
                item.ApplyUpdateModel();
            }
        }

        public void NotifyChange(IModelChanger sender, string info)
        {
            foreach (var item in _changeObservers)
            {
                item.ApplyUpdateModel(info);
            }
        }
    }
}
