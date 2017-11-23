using System.ComponentModel.DataAnnotations;

namespace ClassLibraryForSiebePaesschesoone
{
    public class ValidationViewModel
    {
        [DataType(DataType.Password), Display(Name = "This action requires authentication. Give password: ")]
        public string password { get; set; }
    }
}
