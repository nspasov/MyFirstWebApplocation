using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApplication
{
    public class Customer
    {
        [Required, StringLength(10)]
        public string Name { get; set; }

        public int Id { get; set; }
    }
}