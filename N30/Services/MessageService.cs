using N30.Models;

namespace N30.Services;

public class MessageService
{
    private readonly List<Message> _messages = new();

    public Task<List<Message>> GetPostsAsync()
    {
        return Task.FromResult(_messages);
    }

    public Task<Message> CreateAsync(string body)
    {
        return Task.Run(() =>
        {
            var post = new Message(body);

            // recognizing harmful content

            // calculating tags from content #net, #vue

            // decompressing image for small, medium and large sizes

            Thread.Sleep(1000);

            _messages.Add(post);

            return post;
        });
    }

    public Task<Message> UpdateAsync(Message message)
    {
        return Task.Run(() =>
        {
            // recognizing harmful content

            // decompressing image for small, medium and large sizes

            var foundMessage = _messages.FirstOrDefault(p => p.Id == message.Id);

            if (foundMessage is null)
                throw new ArgumentException();

            foundMessage.Body = message.Body;

            return Task.FromResult(foundMessage);
        });
    }
}