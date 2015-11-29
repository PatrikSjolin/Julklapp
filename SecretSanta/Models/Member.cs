using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecretSanta.Models
{
    public class Member
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? Receiver { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasGotPresent { get; set; }
    }
}