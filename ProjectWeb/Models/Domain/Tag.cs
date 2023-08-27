namespace ProjectWeb.Models.Domain
    //2
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        //many to many (blog post)
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
