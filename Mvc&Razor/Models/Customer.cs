using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_Razor.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Adress { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string City { get; set; }
        public virtual ICollection<CustomerBookList>? CustomerBookLists { get; set; }
    }
}
