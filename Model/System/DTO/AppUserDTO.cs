using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoPago_API.Model.System.DTO
{
    public class AppUserDTO
    {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string DynamicsId { get; set; }

        public List<string> Roles { get; set; }

        public AppUserDTO()
        {
            Roles = new List<string>();
        }
    }
}
