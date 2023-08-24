using System.Text.Json;
using N30.Services;

var postService = new PostsService();
var messageService = new MessageService();

var createPostTask = postService.CreateAsync("About new updated in EF Core", "This is a new post about EF Core", "");
var createMessageTask = messageService.CreateAsync("Hello, I've received your message about EF Core");

Console.WriteLine(JsonSerializer.Serialize(await createMessageTask));
Console.WriteLine(JsonSerializer.Serialize(await createPostTask));
