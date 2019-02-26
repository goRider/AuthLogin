using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewWiki.Models
{
    public class Users
    {
        [Required]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInit { get; set; }
        public string UserEmail { get; set; }
    }
}
