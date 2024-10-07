using Microsoft.EntityFrameworkCore;
using MinimalApiProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// CRUD Endpoints

// Create new post
app.MapPost("posts", async (PostModel post, AppDbContext db) =>
{
    post.CreatedAt = DateTime.UtcNow;
    db.Posts.Add(post);
    await db.SaveChangesAsync();
    return Results.Created($"posts/{post.Id}", post);
})
    .WithName("CreatePost")
    .WithTags("Posts");


// Get all posts
app.MapGet("/posts", async (AppDbContext db) =>
    await db.Posts.ToListAsync())
    .WithName("GetAllPosts")
    .WithTags("Posts");


// Get a post by id
app.MapGet("/posts/{id}", async (int id, AppDbContext db) =>
{
    var post = await db.Posts.FindAsync(id);
    return post is not null ? Results.Ok(post) : Results.NotFound();
})
    .WithName("GetPostById")
    .WithTags("Posts");


// Update an post
app.MapPut("/posts/{id}", async (int id, PostModel updatedPost, AppDbContext db) =>
{
    var post = await db.Posts.FindAsync(id);
    if (post is null) return Results.NotFound();

    post.Title = updatedPost.Title;
    post.Content = updatedPost.Content;
    post.UpdatedAt = DateTime.UtcNow;

    await db.SaveChangesAsync();
    return Results.NoContent();
})
    .WithName("UpdatePost")
    .WithTags("Posts");


// Delete a post
app.MapDelete("/posts/{id}", async (int id, AppDbContext db) =>
{
    var post = await db.Posts.FindAsync(id);
    if (post is null) return Results.NotFound();

    db.Posts.Remove(post);
    await db.SaveChangesAsync();
    return Results.NoContent();
})
    .WithName("DeletePost")
    .WithTags("Posts");


app.Run();
