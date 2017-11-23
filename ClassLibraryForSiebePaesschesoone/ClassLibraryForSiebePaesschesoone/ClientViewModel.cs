using System.ComponentModel.DataAnnotations;

namespace ClassLibraryForSiebePaesschesoone
{
    public class ClientViewModel
    {
        [Required]
        public string SerialKey { get; set; }

        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text)]
        public string FamilyName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
		public string DateOfBirth { get; set; }
    }
}