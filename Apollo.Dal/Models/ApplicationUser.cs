using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Apollo.Dal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Title { get; set; }
        public string CellPhone { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string FullName => string.Format("{0} {1}", FirstName, LastName);
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    }
}
