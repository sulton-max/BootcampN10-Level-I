namespace N30.Models;

public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<string> Tags { get; set; }
    public string HeaderImageUrl { get; set; }

    public Post(string title, string content, string headerImageUrl)
    {
        Id = Guid.NewGuid();
        Title = title;
        Content = content;
        HeaderImageUrl = headerImageUrl;
    }
}