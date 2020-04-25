using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadUpMVC.Models.ViewModels
{
    public class SquadFormViewModel
    {
        public List<Artist> ArtistList { get; set; }
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public string Tickets { get; set; }
        public List<ApplicationUser> SquadMembers { get; set; }
        public string SquadLeaderId { get; set; }
        public ApplicationUser SquadLeader { get; set; }
        public List<SelectListItem> Users { get; set; }
        public List<int> UserIds { get; set; }
    }
}
