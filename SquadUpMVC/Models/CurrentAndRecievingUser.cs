using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class CurrentAndRecievingUser
    {
        public string CurrentUserId { get; set; }
        public ApplicationUser CurrentUser { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
