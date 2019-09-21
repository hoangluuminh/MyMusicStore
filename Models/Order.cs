using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyMusicStore.Models {
    public class Order {
        [Required]
        [HiddenInput]
        public int OrderId { get; set; }

        [Required]
        [ReadOnly(true)]
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

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DisplayName("Postal Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ReadOnly(true)]
        public decimal Total { get; set; }
        //public List<OrderDetails> OrderDetails { get; set; }

        public Order() {
        }
    }
}
