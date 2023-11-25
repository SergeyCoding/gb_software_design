namespace ModelElements
{
    public class Scene
    {
        public int Id { get; set; }
        public List<PoligonalModel> Models { get; set; } = [];
        public List<Flash> Flashes { get; } = [];
    }
}