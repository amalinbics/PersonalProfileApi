using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PersonalProfileApi.Models
{
    public class Lender
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string MobileNo { get; set; }

        [StringLength(12)]
        public string AlternateMobileNo { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

    }
}