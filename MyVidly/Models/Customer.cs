using System;
using System.ComponentModel.DataAnnotations;


namespace MyVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter customer name")]
        [StringLength(255)]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        
        [Display(Name = "Date of birth")]
        [Min18YearsIfMember]
        public DateTime? DoB { get; set; }
        
        [Display(Name = "Subscribe to news letter?")]
        public bool IsSubscribedToNewsletter { get; set; }
        
        [Display(Name = "Membership type")]
        public MembershipType MembershipType { get; set; }
        
        [Required]
        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }


        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}