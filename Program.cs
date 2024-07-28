var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var posts = new List<BlogPost>();

app.MapGet("/api/posts", () => posts.Select(p => new { p.Id, p.Title, CommentCount = p.Comments.Count }));

app.MapPost("/api/posts", (BlogPost post) => {
    post.Id = posts.Count + 1;
    posts.Add(post);
    return Results.Created($"/api/posts/{post.Id}", post);
});

app.MapGet("/api/posts/{id}", (int id) => 
    posts.FirstOrDefault(p => p.Id == id) is BlogPost post ? Results.Ok(post) : Results.NotFound());

app.MapPost("/api/posts/{id}/comments", (int id, Comment comment) => {
    var post = posts.FirstOrDefault(p => p.Id == id);
    if (post == null) return Results.NotFound();

    comment.Id = post.Comments.Count + 1;
    post.Comments.Add(comment);
    return Results.Created($"/api/posts/{id}/comments/{comment.Id}", comment);
});

app.Run();
