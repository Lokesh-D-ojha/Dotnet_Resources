namespace ViewData.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }        

        public string NameAndDescription => $"{Name} {Description}";
        public string IdAndName => $"{Id} {Name}";
    }
}
