using System;
using System.Collections.Generic;
using System.Text;

namespace NHLAPIClassLibrary
{
    class Division : BaseInformation
    {
        private string Abbreviation { get; set; }
        private bool active { get; set; }
        private Conference conference { get; set; }
    }
}
