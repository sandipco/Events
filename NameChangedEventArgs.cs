using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class NameChangedEventArgs:EventArgs
    {
        public string oldValue { get; set; }
        public string newValue { get; set; }
    }
}
