using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCTprojecthub.Areas.Identity.Data;

namespace UCTprojecthub.Models
{
    public class Allocation
    {
        #region class attributes
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        public UCTprojecthubUser User { get; set; }

        public Topic Topic { get; set; }

        #endregion
    }
}
