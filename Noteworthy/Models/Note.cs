using System.Collections.Generic;

namespace Noteworthy.Models
{
    public class Note
    {
        public int Id { get; set; }
        public List<NoteField> NoteFields { get; set; } = new();



    }
}
