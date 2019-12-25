using System;
using System.Collections.Generic;
using System.Text;

namespace NHLAPIClassLibrary
{
    class Conference : BaseInformation
    {
        private string Abbreviation { get; set; }
        private string shortName { get; set; }
        private bool active { get; set; }
    }
}
