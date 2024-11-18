using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WPF_SlowkaProjekt.ClassModel
{
    public class WordsContext:DbContext
    {
        public DbSet<WordModel> Words { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public WordsContext()
        {
            
        }
        public WordsContext(DbContextOptions<WordsContext> options) : base(options)
        {

        }        

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.DBPath);
        }
    }
}
