using System.ComponentModel.DataAnnotations;

namespace ApiTest.Src.InspectionType.Dto
{
    public class CreateInspectionTypeDto
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }

    public class ReadInspectionTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class UpdateInspectionTypeDto
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
