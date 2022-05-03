using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationCRUD.Models
{
    public class RegistrationViewModel
    {
        public int Id { get; set; }


        [DisplayName("First Name")]
        [Required]
        public string Fname { get; set; }


        [Required]
        public string Lname { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }


        [Required]
        public int Gender { get; set; }

        public int City { get; set; }


        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }


        public string Image { get; set; }


        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
