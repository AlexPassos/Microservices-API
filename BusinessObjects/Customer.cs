using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
    }
}
