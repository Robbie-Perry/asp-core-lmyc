using asp_core_lmyc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmycWeb.Models
{
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }

        [Required]
        public string BoatName { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        public int LengthInFeet { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RecordCreationDate { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Boat()
        {
            RecordCreationDate = DateTime.Now;
        }
    }
}
