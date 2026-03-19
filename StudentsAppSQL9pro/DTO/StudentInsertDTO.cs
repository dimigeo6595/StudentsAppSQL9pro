using System.ComponentModel.DataAnnotations;

namespace StudentsAppSQL9pro.DTO
{
    public record StudentInsertDTO(

        [property: Required (ErrorMessage = "{0} is RequiredAttribute.")]
        [property: MinLength(1, ErrorMessage = "{0} must be at most {1} characters long.")]
        string? Firstname,

        [property: Required (ErrorMessage = "{0} is RequiredAttribute.")]
        [property: MinLength(1, ErrorMessage = "{0} must be at most {1} characters long.")]
        string? Lanstname
        )
    {
        public StudentInsertDTO() : this(string.Empty, string.Empty)
        {
        }

    }
}
