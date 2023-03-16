using Eleviant.Mentoring.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Eleviant.Mentoring.Data
{
	public class ApplicationContext : DbContext
	{
        public ApplicationContext()
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
