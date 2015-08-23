using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class book
    {
        private string _name;
        public event NameChangedDelegate NameChanged;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //We want notify once the name has changed
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.oldValue = oldValue;
                        args.newValue = value;
                        NameChanged(this, args);
                    }
                }
            }
        }

    }
}
