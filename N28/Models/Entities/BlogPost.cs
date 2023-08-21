using N28.Models.Common;

namespace N28.Models.Entities;

public class BlogPost : IEntity, IUpdatableEntity<BlogPost>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string HeaderImageUrl { get; set; }
    public Guid AuthorId { get; set; }

    public void Update(BlogPost model)
    {
        Title = model.Title;
        Content = model.Content;
        HeaderImageUrl = model.HeaderImageUrl;
        AuthorId = model.AuthorId;
    }

    public BlogPost(string title, string content, string headerImageUrl, Guid authorId)
    {
        Id = Guid.NewGuid();
        Title = title;
        Content = content;
        HeaderImageUrl = headerImageUrl;
        AuthorId = authorId;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}";
    }
}