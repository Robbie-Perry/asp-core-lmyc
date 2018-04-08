using asp_core_lmyc.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmycWeb.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [ForeignKey("User")]
        [DisplayName("Reserved By")]
        public string ReservedBy { get; set; }

        [Required(ErrorMessage = "Need start date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("From")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Need end date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("To")]
        public DateTime EndDate { get; set; }

        public ApplicationUser User { get; set; }

        public string UserName { get; set; }

        [ForeignKey("Boat")]
        public int BoatId { get; set; }

        [DisplayName("Boat")]
        public Boat Boat { get; set; }
    }
}
