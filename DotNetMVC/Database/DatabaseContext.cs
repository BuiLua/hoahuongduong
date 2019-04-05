using FirstDatabaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstDatabaseProject.Database
{
    public class DatabaseContext : DbContext
    {
        private static DatabaseContext instance;
        public static DatabaseContext Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DatabaseContext();
                }
                return instance;
            }
        }

        public DatabaseContext() : base("MyDatabaseContext"){ }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}