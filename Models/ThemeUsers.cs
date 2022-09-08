using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCTprojecthub.Areas.Identity.Data;

namespace UCTprojecthub.Models
{
    public class ThemeUsers
    {
        #region class attributes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();

        #endregion

        #region navigational attributes
        public Theme Theme { get; set; }

        public ICollection<UCTprojecthubUser>? Users { get; set; }

        public int? UserCount { get; set; }
        #endregion
    }
}
