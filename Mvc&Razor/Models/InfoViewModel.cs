using System.ComponentModel.DataAnnotations;

namespace Mvc_Razor.Models
{
    public class InfoViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
    }
}
