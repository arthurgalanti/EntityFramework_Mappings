using BALTA.IO_FundamentosEF.Data;
using BALTA.IO_FundamentosEF.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using(var context = new BlogDataContext())
        {
            // var tag = new Tag { Name= "TesteEF", Slug="test"};
            // context.Tags.Add(tag);
            // context.SaveChanges();

            // var tag = context.Tags.AsNoTracking().FirstOrDefault(x=> x.Id == 2);
            // Console.WriteLine(tag?.Name);

            // var tag = context.Tags.FirstOrDefault(x=> x.Id == 2);
            // tag.Name = ".NET";
            // tag.Slug = "dotnet";

            // context.Update(tag);
            // context.SaveChanges();

            //  var tag = context.Tags.FirstOrDefault(x=> x.Id == 16);
            // context.Remove(tag);
            // context.SaveChanges();

            // var tags = context.Tags.ToList();

            // foreach (var tag in tags)
            //     Console.WriteLine(tag.Name);
        }
    }
}