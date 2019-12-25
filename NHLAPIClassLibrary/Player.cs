using System;

namespace NHLAPIClassLibrary
{
    public class Player
    {
        private string FullName { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private Person personalInfo { get; set; }
        private int jerseyNumber { get; set; }
        private bool active { get; set; }
        private bool alternateCaptian { get; set; }
        private bool captian { get; set; }
        private bool rookie { get; set; }
        private string shootsCatches { get; set; }
        private char rosterStatus { get; set; } //wtf is this API doc has "Y" as the valiue
        private Franchise currentTeam { get; set; }
        private Position primaryposition { get; set; }
        

    }
}
