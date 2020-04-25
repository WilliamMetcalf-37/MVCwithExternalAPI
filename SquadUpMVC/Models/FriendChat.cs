using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class FriendChat : CurrentAndRecievingUser
    {
        public int Id { get; set; }

        public bool Confirmed { get; set; }
    }
}
