using System;
using System.Collections.Generic;
using System.Text;

namespace NHLAPIClassLibrary
{
    class Team : BaseInformation
    {
        private Venue Arena { get; set; }
        private string Abbriviation { get; set; } 
        private string teamName { get; set; }
        private string locationName { get; set; }
        private string firstYearOfPlay { get; set; }
        private Division division { get; set; }
        private Conference conference { get; set; }
        private Franchise FranchiseInformation { get; set; }
        private List<Player> Roster { get; set; }
        private string shortName { get; set; }
        private string OfficialSiteUrl { get; set; }
        private bool IsActive { get; set; }
    }
}
