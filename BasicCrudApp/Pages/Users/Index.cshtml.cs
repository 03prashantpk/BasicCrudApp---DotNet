using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasicCrudApp.Data;
using BasicCrudApp.Model;

namespace BasicCrudApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BasicCrudApp.Data.BasicCrudAppContext _context;

        public IndexModel(BasicCrudApp.Data.BasicCrudAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
