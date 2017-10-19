using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataSaving.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Adress { get; set; }

        [StringLength(6)]
        public string PostCode { get; set; }
    }
}