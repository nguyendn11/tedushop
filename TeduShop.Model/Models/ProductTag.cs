﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag tag { get; set; }
    }
}
