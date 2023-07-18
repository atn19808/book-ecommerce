using Ecom.Models;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
		public void Update(ApplicationUser applicationUser);

	}
}
