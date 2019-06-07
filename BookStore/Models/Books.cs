using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace BookStore.Models
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Book_Title { get; set; }
        public string auther { get; set; }
        public DateTime PublishedDate { get; set; }
        public string edition { get; set; }
        [DataType(DataType.ImageUrl)]
       public string img { get; set; }
        public int available { get; set; }
        public Books()
        {
            available = 1;
        }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Purchases>Purchases { get; set; }
    }
}