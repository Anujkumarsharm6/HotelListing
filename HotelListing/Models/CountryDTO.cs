using HotelListing.Data;
using System.ComponentModel.DataAnnotations;
using static HotelListing.Models.CreateHotelDTO;

namespace HotelListing.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }

        public  IList<HotelDTO> Hotels { get; set; }

    }

    public class CreateCountryDTO
    {
   
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "State Name is Too long")]
        public string State { get; set; }
    }
}
