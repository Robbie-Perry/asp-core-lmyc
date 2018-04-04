using asp_core_lmyc.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LmycWeb.Models
{
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }

        [Required]
        [DisplayName("Boat Name")]
        public string BoatName { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        [DisplayName("Length (ft)")]
        public int LengthInFeet { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Record Creation Date")]
        public DateTime RecordCreationDate { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [DisplayName("Added By")]
        public ApplicationUser ApplicationUser { get; set; }

        public Boat()
        {
            RecordCreationDate = DateTime.Now;
        }
    }
}
