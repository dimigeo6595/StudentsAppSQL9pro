using System.ComponentModel.DataAnnotations;

namespace StudentsAppSQL9pro.DTO
{
    public record StudentUpdateDTO(
        
        int Id,

        [property: Required (ErrorMessage = "{0} is RequiredAttribute.")]
        [property: MinLength(1, ErrorMessage = "{0} must be at most {1} characters long.")]
        string? Firstname,

        [property: Required (ErrorMessage = "{0} is RequiredAttribute.")]
        [property: MinLength(1, ErrorMessage = "{0} must be at most {1} characters long.")]
        string? Lanstname
        ) : BaseDTO (Id)
    {
        public StudentUpdateDTO() : this(0, string.Empty, string.Empty)
        {
        }

    }
}
