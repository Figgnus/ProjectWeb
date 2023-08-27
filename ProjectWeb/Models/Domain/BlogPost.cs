namespace ProjectWeb.Models.Domain
    //1
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }   
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set;}
        public bool Visible { get; set;}

        //many to many (tag)
        public ICollection<Tag> Tags { get; set; }
    }
}
