using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class SquadChat : SquadAndMember
    {
        public int Id { get; set; }    
        public string Message { get; set; }
    }
}
