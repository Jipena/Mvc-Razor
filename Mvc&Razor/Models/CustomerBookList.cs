using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_Razor.Models
{
    public class CustomerBookList
    {
        [Key]
        public int CustomerBookListId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        [ForeignKey(name: "Books")]
        public int FkBookId { get; set; }
        public Book Books { get; set; }

        [ForeignKey(name: "Customers")]
        public int FkCustomerId { get; set; }
        public Customer Customers { get; set; }
    }
}
