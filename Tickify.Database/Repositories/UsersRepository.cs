using Tickify.Database.Context;
using Tickify.Database.Entities;
using Tickify.Infrastructure.Exceptions;

namespace Tickify.Database.Repositories
{
    public class UsersRepository(TickifyDatabaseContext tickifyDatabaseContext) : BaseRepository<Event>(tickifyDatabaseContext)
    {
        public async Task AddAsync(User user)
        {
            tickifyDatabaseContext.Users.Add(user);
            await tickifyDatabaseContext.SaveChangesAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var result = tickifyDatabaseContext.Users

                .Where(e => e.Email == email)
                .Where(e => e.DeletedAt == null)

                .FirstOrDefault();

            if (result == null)
                throw new ResourceMissingException("User not found");

            return result;
        }
    }
}
