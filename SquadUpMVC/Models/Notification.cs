using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models
{
    public class Notification : CurrentAndRecievingUser
    {
        public int Id { get; set; }
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }

    }
}
