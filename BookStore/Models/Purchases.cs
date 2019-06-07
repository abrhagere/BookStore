﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Total { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }
        public string Supplier { get; set; }
        public string FSNumber { get; set; }
        public virtual Books Book { get; set; }
    }
}
