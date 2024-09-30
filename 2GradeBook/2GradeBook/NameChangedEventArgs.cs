using System;
using System.Collections.Generic;

namespace GradeBook.Console
{
    public class NameChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
