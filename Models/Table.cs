using System.ComponentModel.DataAnnotations;
using TableBackend.DataAnnotations;

namespace TableBackend.Models
{
    public class TableObj
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "מספרים בלבד")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string Name { get; set; }

        [EmailAddressOrEmpty]
        public string Email { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string Birthday { get; set; }

        public string Gender { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "מספרים בלבד")]
        public string Phone { get; set; }
    }
}
