using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebKUR.Models;

namespace WebKUR.ViewModels
{
    public class UserViewModel
    {
        public IdentityUser users { get; set; }
        public IdentityUserClaim userClaim { get; set; }
        public IdentityRole role { get; set; }
        public IdentityUserLogin userlogin { get; set; }
    }
}