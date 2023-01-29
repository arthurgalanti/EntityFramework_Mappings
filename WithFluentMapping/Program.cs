using BALTA.IO_FundamentosEF.Data;
using BALTA.IO_FundamentosEF.Models;

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

        // context.Users.Add(new User
        // {
        //     Name = "Arthur Galanti2",
        //     Slug = "arthur-galanti2",
        //     Email = "arthur@galanti.dev2",
        //     Bio = ".NET Developer Jr",
        //     Image="http://",
        //     PasswordHash="12345"
        // });
        // context.SaveChanges();
        // var user = context.Users.FirstOrDefault();
        // var post = new Post
        // {
        //     Author = user,
        //     Body = "Meu artigo",
        //     Category = new Category{
        //         Name="Backend",
        //         Slug="backend"
        //     },
        //     CreateDate = System.DateTime.Now,
        //     // LastUpdateDate =
        //     Slug = "meu-artigo",
        //     Summary = "Neste artigo vamos conferir...",
        //     // Tags =null,
        //     Title = "Meu artigo",
        // };

        // context.Posts.Add(post);
        // context.SaveChanges();

        // context.Posts.Add(post);
        // context.SaveChanges();
    }
}