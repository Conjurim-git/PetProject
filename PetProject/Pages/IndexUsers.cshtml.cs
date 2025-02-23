using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetProject.Models;
using System.Linq;
//using PetProject.Migrations;

namespace PetProject.Pages
{
    public class IndexUsersModel : PageModel
    {
        ApplicationContext context;
        public List<User> Users { get; private set; }
        public IndexUsersModel(ApplicationContext db)
        {
            context = db;
        }

        public void OnGet()
        {
            Users = context.Users.AsNoTracking().ToList();
        }
    }
}
