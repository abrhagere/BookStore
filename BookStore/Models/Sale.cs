using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name ="Book_Title")]
        public int BookId { get; set; }
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }       
        public virtual Books Book { get; set; }
        public virtual Customers Customer { get; set; }
    }
}