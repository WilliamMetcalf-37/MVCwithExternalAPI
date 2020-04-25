using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class SquadUser : SquadAndMember
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
