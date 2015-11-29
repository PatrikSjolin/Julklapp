using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecretSanta.Models
{
    public class SelectGroupViewModel
    {
        public Guid SelectedGroupId { get; set; }

        public IEnumerable<SelectListItem> Groups
        {
            get; set;
        }
    }
}