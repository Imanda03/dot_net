using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = " Email should be less than 51")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = " Password should be less than 51")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
