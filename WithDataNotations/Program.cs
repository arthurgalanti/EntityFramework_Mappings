using WithDataNotation.Data;
using WithDataNotation.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        // var user = new User
        // {
        //     Name = "Arthur Galanti2",
        //     Slug = "arthur-galanti2",
        //     Email = "arthur@galanti.dev2",
        //     Bio = ".NET Developer Jr",
        //     Image="http://",
        //     PasswordHash="12345"
        // };

        // var category = new Category
        // {
        //     Name="Teste1",
        //     Slug="Teste1"
        // };

        // var post = new Post
        // {
        //     Author = user,
        //     Category = category,
        //     Body = "hello word",
        //     Slug = "comecando-com-ef",
        //     Summary = "sobre ef",
        //     Title ="Fundamentos EF",
        //     CreateDate = DateTime.Now,
        //     LastUpdateDate = DateTime.Now
        // };

        // context.Posts.Add(post);
        // context.SaveChanges();

        // var posts = context
        // .Posts
        // .AsNoTracking()
        // .Include(x=> x.Author)
        // .Include(x=> x.Category)
        // .OrderByDescending(x=> x.LastUpdateDate)
        // .ToList();

        // foreach (var post in posts)
        //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");

        // var post = context
        // .Posts
        // // .AsNoTracking()
        // .Include(x=> x.Author)
        // .Include(x=> x.Category)
        // .OrderByDescending(x=> x.LastUpdateDate)
        // .FirstOrDefault();

        // post.Author.Name = "Teste";

        // context.Posts.Update(post);
        // context.SaveChanges();

    }
}