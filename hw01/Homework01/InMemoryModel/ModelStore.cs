using ModelElements;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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
            Models.CollectionChanged += ModelChanged;
            Scenes.CollectionChanged += ModelChanged;
            Flashes.CollectionChanged += ModelChanged;
            Cameras.CollectionChanged += ModelChanged;
        }

        private void ModelChanged(object? sender, NotifyCollectionChangedEventArgs e) => NotifyChange(this);

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
    }
}
