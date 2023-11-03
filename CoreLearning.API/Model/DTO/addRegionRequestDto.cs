using System.ComponentModel.DataAnnotations;

namespace CoreLearning.API.Model.DTO
{
    public class addRegionRequestDto
    {
        [Required]
        [MinLength(1,ErrorMessage ="Code Has To be a Minimum 1 Character")]
        [MaxLength(5,ErrorMessage ="Code Has To be a Minimum 5 Characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Code Has To be a Minimum 100 Characters")]
        public string Name { get; set; } 
        public string? RegionImageUrl { get; set; }
    }
}
