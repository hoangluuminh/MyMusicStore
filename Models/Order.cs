using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMusicStore.Models {
    public class Order {
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Username { get; set; }
        [Required(ErrorMessage="Vui lòng điền {0}")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(160)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        //public List<OrderDetails> OrderDetails { get; set; }

        public Order() {
        }
    }
}
