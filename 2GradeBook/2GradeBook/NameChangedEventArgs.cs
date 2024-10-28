using System;
using System.Collections.Generic;

namespace GradeBook.ConsoleApp
{
    public class NameChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
