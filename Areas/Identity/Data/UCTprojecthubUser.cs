using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using UCTprojecthub.Models;

namespace UCTprojecthub.Areas.Identity.Data;


public class UCTprojecthubUser : IdentityUser
{
    #region class attributes
    [Required, StringLength(9, MinimumLength = 9, ErrorMessage = "Your student number should be 9 digits in length")]
    [Display(Name = "Student Number")]
    public string StudentNumber { get; set; }

    [Required, StringLength(455)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required, StringLength(455)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required, Display(Name = "Date Created")]
    public DateTime DateCreated { get; set; } = DateTime.Now;

    [Required, Display(Name = "Last Updated")]
    public DateTime LastUpdated { get; set; }
    #endregion

    #region navigation attributes
    
    #endregion

}

