using System.Collections.Generic;
using WebKUR.Models;

namespace WebKUR.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}