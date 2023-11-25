namespace ModelElements
{
    class Scene
    {
        public int Id { get; set; }
        public List<PoligonalModel> Models { get; set; } = new List<PoligonalModel>();
        public Flash Flashas { get; set; }
    }
}