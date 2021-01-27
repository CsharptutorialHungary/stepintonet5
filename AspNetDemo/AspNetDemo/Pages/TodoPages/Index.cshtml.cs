using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetDemo.Backend;
using AspNetDemo.Backend.Model;

namespace AspNetDemo.Pages.TodoPages
{
    public class IndexModel : PageModel
    {
        private readonly AspNetDemo.Backend.TodoDbContext _context;

        public IndexModel(AspNetDemo.Backend.TodoDbContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; }

        public async Task OnGetAsync()
        {
            Todo = await _context.Todos.ToListAsync();
        }
    }
}
