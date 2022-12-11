using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuthorLibrary.Models;

namespace AuthorLibrary.Data
{
    public class AuthorLibraryContext : DbContext
    {
        public AuthorLibraryContext (DbContextOptions<AuthorLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<AuthorLibrary.Models.Author> Author { get; set; } = default!;
    }
}
