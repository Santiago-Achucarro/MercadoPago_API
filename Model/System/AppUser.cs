using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago_API.Model.System
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(60)]
        public string FullName { get; set; }

        [StringLength(80)]
        public string Address { get; set; }

        [StringLength(80)]
        public string City { get; set; }

        [StringLength(80)]
        public string State { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [StringLength(2)]
        public string CountryCode { get; set; }

        [StringLength(15)]
        public string DynamicsId { get; set; }
    }
}
