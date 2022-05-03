using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationCRUD.Entities
{
    public class Registration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Dob { get; set; }
        public int Gender { get; set; }
        public int City { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }

      
        public string Password { get; set; }
    }
}
