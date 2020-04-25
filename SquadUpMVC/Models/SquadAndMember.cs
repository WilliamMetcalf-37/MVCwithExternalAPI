using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class SquadAndMember
    {
        public string SquadMemberId { get; set; }
        public ApplicationUser SquadMember { get; set; }
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
    }
}
