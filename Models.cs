public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}

public class Comment
{
    public int Id { get; set; }
    public int BlogPostId { get; set; }
    public string Content { get; set; }
}
