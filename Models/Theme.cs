using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UCTprojecthub.Areas.Identity.Data;

namespace UCTprojecthub.Models
{
    public class Theme
    {
        #region class attributes
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; } = new Guid();


        [Required]
        [StringLength(455)]
        public string Title { get; set; }

        [Required]
        [StringLength(455)]
        public string Description { get; set; }


        [Required]
        [Column("Date Created")]
        public DateTime DateCreated { get; set; }


        [Column("Date Updated")]
        public DateTime? DateUpdated { get; set; }

        public int? StudentCount { get; set; } 
        #endregion

        #region navigational attributes
        public ICollection<Topic>? Topics { get; set; }

        [Display(Name ="Creator Id")]
        public UCTprojecthubUser? User { get; set; }
        #endregion

    }
}
