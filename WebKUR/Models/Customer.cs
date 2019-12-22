using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebKUR.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Wprowadz max 30 znakow")]
        [StringLength(30)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearIsAMember]
        public DateTime? Birthdate { get; set; }
    }
}