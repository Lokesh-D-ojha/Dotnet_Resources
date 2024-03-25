namespace ViewData.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public string NameAndDescription => $"{CategoryName} {Description}";
        public string IdAndName => $"{Id} {CategoryName}";
}
}
