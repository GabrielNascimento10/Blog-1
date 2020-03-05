using Blog.Models.Blog.Categoria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CategoriaEntity> categoria { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);

            optionBuilder.UseMySql("Server=localhost;User=root;password=root;Database=blog");
        }
    }
}