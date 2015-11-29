using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretSanta.Models
{
    public class AdminViewModel
    {
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}