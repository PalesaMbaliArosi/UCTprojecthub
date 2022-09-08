using UCTprojecthub.Areas.Identity.Data;
using UCTprojecthub.Data;
using UCTprojecthub.IRepository;

namespace UCTprojecthub.Repository
{
    public class userRepository : iUserRepository
    {
        private readonly UCTprojecthubContext _context;

        public userRepository(UCTprojecthubContext context  )
        {
            _context = context;
        }

        public UCTprojecthubUser GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<UCTprojecthubUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public UCTprojecthubUser UpdateUser(UCTprojecthubUser user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}
