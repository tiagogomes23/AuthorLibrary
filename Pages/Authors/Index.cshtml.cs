﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthorLibrary.Data;
using AuthorLibrary.Models;

namespace AuthorLibrary.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly AuthorLibrary.Data.AuthorLibraryContext _context;

        public IndexModel(AuthorLibrary.Data.AuthorLibraryContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
