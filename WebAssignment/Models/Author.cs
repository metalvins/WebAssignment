using System;
using System.ComponentModel.DataAnnotations;

namespace WebAssignment.Models
{
    public class Author
    {
        [Required(ErrorMessage = "Please provide your first name.")]
        [MaxLength(200)]
        [Display(Name = "First Name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Please provide your last name.")]
        [MaxLength(200)]
        [Display(Name = "Last Name (Surname)")]
        public string Lname { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime Bday { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please provide an email address.")]
        [MaxLength(500)]
        public string Email { get; set; }

        [RegularExpression(@"^((http | https)://)?([\w-]+\.)+[\w]+(/[\w- ./?]*)?$", ErrorMessage = "Invalid Website")]
        [MaxLength(1000)]
        [Display(Name = "Website Address")]
        public string Website { get; set; }

        [Phone]
        [MaxLength(20)]
        [Display(Name = "Telephone Number")]
        public string Phone { get; set; }

        [MaxLength(70)]
        public string Country { get; set; }

        [MaxLength(70)]
        public string Province { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [MaxLength(20)]
        [Display(Name = "Postal Code")]
        public string Zip { get; set; }


        public override string ToString()
        {
            return Fname + " " + Lname;
        }
    }
}
