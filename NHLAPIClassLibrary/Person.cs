using System;
using System.Collections.Generic;
using System.Text;

namespace NHLAPIClassLibrary
{
    class Person : BaseInformation
    {
        private string fullName { get; set; }
        private Position playersPosition { get; set; }
        private DateTime birthDate { get; set; }
        private int currentAge { get; set; }
        private string birthCity { get; set; }
        private string birthStateProvince { get; set; }
        private string birthCountry { get; set; }
        private string nationality { get; set; }
        private string height { get; set; }
        private int weight { get; set; }

        public override string ToString()
        {
            return fullName;
        }

    }
}
