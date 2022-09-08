using UCTprojecthub.Areas.Identity.Data;

namespace UCTprojecthub.IRepository
{
    public interface iUserRepository
    {
        ICollection<UCTprojecthubUser> GetUsers();

        UCTprojecthubUser GetUser(string id);

        UCTprojecthubUser UpdateUser(UCTprojecthubUser user);   
    }
}
