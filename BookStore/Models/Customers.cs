using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Customer_Name { get; set; }
         [DataType(DataType.PhoneNumber)]
        public string PhoneNumber{ get; set; }
        public string Address{ get; set; }
        [DataType(DataType.EmailAddress)]
        public string   Email { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}