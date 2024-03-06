
using BlogBackEnd;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {

            // Create and save new user & post
            var user = new User { Id = Guid.NewGuid(), Name = "Someone" };
            var post = new BlogPost { Author = user, Id = Guid.NewGuid(), Title = "My Title" };

            db.Users.Add(user);
            db.Posts.Add(post);
            db.SaveChanges();

            // Display all posts in DB
            var query = from p in db.Posts
                        orderby p.Title
                        select p;

            Console.WriteLine("All posts in DB:");
            foreach(var item in query) Console.WriteLine(item.Title);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



    }
}
