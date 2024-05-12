using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class StoreInfo:BaseEntity
    {
        [Required]
        [Display(Name = "store name")]
        public string StoreName { get; set; }
        [Required]
        [Display(Name = "address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "registration number")]
        public string RegistrationNo { get; set; }
        [Required]
        [Display(Name = "pan number")]
        public string PanNo { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
