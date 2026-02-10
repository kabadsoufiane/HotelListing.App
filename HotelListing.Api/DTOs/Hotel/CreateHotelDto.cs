using System.ComponentModel.DataAnnotations;
using HotelListing.Api.data.Models;

namespace HotelListing.Api.DTOs.Hotel
{
    public class CreateHotelDto
    {

        [Required]
        public required string Name { get; set; }

        [MaxLength(150)]
        public required string Address { get; set; }

        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
