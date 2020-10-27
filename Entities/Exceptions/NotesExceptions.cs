using System;
using System.Collections.Generic;
using System.Text;

namespace FewerNotes.Entities.Exceptions
{
    class NotesExceptions : ApplicationException
    {
        public NotesExceptions(string message) : base(message) { }
    }
}
