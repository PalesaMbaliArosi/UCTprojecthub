using UCTprojecthub.IRepository;

namespace UCTprojecthub.Repository
{
    public class UnitOfWork : iUnitOfWork
    {
        public iUserRepository User { get; set; }

        public UnitOfWork(iUserRepository user)
        {
            User = user;
        }
    }
}
