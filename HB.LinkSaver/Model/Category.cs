namespace HB.LinkSaver
{
    public class Category
    {
        public string CategorGroupName { get; set; } = null!;
        public List<string> SubCategories { get; set; } = new();
    }
}
