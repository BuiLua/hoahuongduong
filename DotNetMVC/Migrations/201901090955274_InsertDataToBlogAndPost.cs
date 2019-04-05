namespace FirstDatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using FirstDatabaseProject.Database;
    using FirstDatabaseProject.Entities;

    public partial class InsertDataToBlogAndPost : DbMigration
    {
        public override void Up()
        {
            DatabaseContext context = new DatabaseContext();
            for(var i = 0; i < 10; ++i)
            {
                var blog = new Blog()
                {
                    BlogId = i + 1,
                    Name = "Blog Title" + (i + 1)
                };
                context.Blogs.Add(blog);
            }

            for (var i = 0; i < 10; ++i)
            {
                var post = new Post()
                {
                    PostId = i + 1,
                    Title = "Post Title" + (i + 1),
                    Content = "Content" + (i + 1),
                    BlogId = i + 1
                };
                context.Posts.Add(post);
            }
            context.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
