using Core.CoreEntity;
using Core.CoreEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class AppUser:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePhotoPath { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public Guid ActivationId { get; set; }
        public bool IsActive { get; set; }


       
    }
}
