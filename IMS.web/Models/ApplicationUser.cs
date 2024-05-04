using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IMS.web.Models
{
    public class ApplicationUser:IdentityUser
    {
        
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Username { get; set; }
        public int StoreId { get; set; }
        public int UserRollId { get; set; }
        public bool IsActive { get; set; }
        public string ProfileImage { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
