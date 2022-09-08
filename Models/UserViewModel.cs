using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UCTprojecthub.Models
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
