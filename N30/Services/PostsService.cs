using N30.Models;

namespace N30.Services;

public class PostsService
{
    private readonly List<Post> _posts = new();

    public Task<List<Post>> GetPostsAsync()
    {
        return Task.FromResult(_posts);
    }

    public Task<Post> CreateAsync(string title, string content, string headerImageUrl)
    {
        return Task.Run(() =>
        {
            var post = new Post(title, content, headerImageUrl);

            // recognizing harmful content

            // calculating tags from content #net, #vue

            // decompressing image for small, medium and large sizes

            Thread.Sleep(2000);

            _posts.Add(post);

            return post;
        });
    }

    public Task<Post> UpdateAsync(Post post)
    {
        return Task.Run(() =>
        {
            // recognizing harmful content

            // decompressing image for small, medium and large sizes

            var foundPost = _posts.FirstOrDefault(p => p.Id == post.Id);

            if (foundPost is null)
                throw new ArgumentException();

            foundPost.Title = post.Title;
            foundPost.Content = post.Content;
            foundPost.HeaderImageUrl = post.HeaderImageUrl;
            foundPost.Tags = post.Tags;

            return Task.FromResult(foundPost);
        });
    }
}