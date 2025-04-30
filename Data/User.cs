using e_commerce.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace E_CommerceProject.Data
{
    public class User : IdentityUser
    {
        [StringLength(150)]
        public string FullName { get; set; } = null!;



        public bool? IsActive { get; set; }



        //[Column(TypeName = "datetime")]
        //public DateTime? CreatedAt { get; set; }

        //[Column(TypeName = "datetime")]
        //public DateTime? UpdatedAt { get; set; }

        //[Column(TypeName = "datetime")]
        //public DateTime? LastLoginDate { get; set; }





        //public long CreatedBy { get; set; }


        public virtual ICollection<Address> Addresses { get; set; }

        public virtual Cart? Cart { get; set; }


        public virtual ICollection<Order> Orders { get; set; }


        public virtual ICollection<Review> Reviews { get; set; }
    }
}
