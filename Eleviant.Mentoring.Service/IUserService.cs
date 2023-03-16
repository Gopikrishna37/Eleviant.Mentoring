using Eleviant.Mentoring.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleviant.Mentoring.Service
{
	public interface IUserService
	{
		Task<User> GetUser(Guid id);
	}
}
