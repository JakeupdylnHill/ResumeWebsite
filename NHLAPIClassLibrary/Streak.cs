using System;
using System.Collections.Generic;
using System.Text;

namespace NHLAPIClassLibrary
{
    class Streak
    {
        private string streakType
        {
            get { return streakType; }
            set
            {
                if (value == "losses")
                    streakType = "loss";
                else
                    streakType = "win";
            }
        }
        private string streakCode { get; set; }
        private int streakNumber { get; set; }

        public override string ToString()
        {
            return streakType + " " + streakNumber;
        }
    }
}
