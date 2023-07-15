using Support_Library.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class DisplayPersonModel : IPersonModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
