using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteworthy.Models
{
    public class NoteField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NoteTypes NoteType { get; set; }

    }
}
