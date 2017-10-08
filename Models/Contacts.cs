using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Contacts
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int ContactNumber { get; set; }
        
        public int UserId { get; set; }
        public virtual Users User { get; set; }

    }
}