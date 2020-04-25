using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class DirectMessage
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public int FriendChatId { get; set; }
        public FriendChat FriendChat { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
