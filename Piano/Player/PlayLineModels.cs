using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Player
{
    public class PlayControlTimer
    {
        public System.Windows.Forms.Timer OnTimer { get; set; }
        public System.Windows.Forms.Timer OffTimer { get; set; }
        public PlayLineHarmony PlayLine { get; set; }
    }

    public class PlayLineHarmony
    {
        public int Vol { get; set; } = 127;
        public int Order { get; set; }
        public GeneralMidiInstrument Instrument { get; set; }
        public List<PlayLineNotes> NoteQueue { get; set; }
    }

    public class PlayLineNotes
    {
        public int Order { get; set; }
        public Note.Note Note { get; set; }
        public double Length { get; set; }
        public bool Silence { get; set; } = false;
        public bool IsPlayed { get; set; } = false;
    }
}
