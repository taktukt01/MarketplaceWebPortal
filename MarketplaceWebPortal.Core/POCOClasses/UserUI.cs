using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketplaceWebPortal.Core.POCOClasses
{
    public class UserUI
    {
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Max length 50 characters")]
        [Display(Name = "Username:")]
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [StringLength(100, ErrorMessage = "Max length 100 characters")]
        [Display(Name = "Email Adddress:")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password:")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Password_Comp { get; set; }

        //Image
        [Required(ErrorMessage = "Upload Profile Image")]
        [Display(Name = "Profile Image")]
        public string ImgUrl { get; set; }
    }
}