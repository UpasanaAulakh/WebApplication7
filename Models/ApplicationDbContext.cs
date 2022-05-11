using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace WebApplication7.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Data Source=CHETUIWK385\\SQLEXPRESS;Initial" +
            " Catalog=newstudent;Integrated Security=True")
        { }
        public DbSet<student> student { get; set; }
    }
}