using Eleviant.Mentoring.Data;
using Eleviant.Mentoring.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleviant.Mentoring.Service
{
	public class UserService : IUserService
	{
		private readonly ApplicationContext context;

        public UserService(ApplicationContext context)
        {
			this.context = context;
        }

        public async Task<User> GetUser(Guid id)
		{
			return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
