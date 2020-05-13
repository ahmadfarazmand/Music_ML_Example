using Piano.Player;
using Piano.Tempo;
using Piano.Tempo.BarsTempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Generate
{
    public abstract class GenerateTemplateAutoPlayCreator
    {
        public static PlayLineHarmony GetResult(ITempoForBars tempo,List<Note.Note> noteList, List<IBarTemplateModel> templates)
        {
            PlayLineHarmony playLine = new PlayLineHarmony();
            playLine.Instrument = Sanford.Multimedia.Midi.GeneralMidiInstrument.Banjo;
            playLine.Order = 1;
            playLine.Vol = 127;
            playLine.NoteQueue = new List<PlayLineNotes>();

            Random r = new Random();
            templates = templates.OrderBy(a => Guid.NewGuid()).ToList();
            for (int i = 0; i < templates.Count(); i++)
            {
                var repeatRandom = r.Next(0, 19);
                var minOctav = r.Next(2, 5);
                var maxOctav = r.Next(5, 8);
                var skipRandom = r.Next(1, 8);
                var template = templates[i];
                int[] notes = noteList.Where(a=> a.Octave >= minOctav && a.Octave <= maxOctav).Skip(skipRandom).Take(template.NoteCount).OrderByDescending(a => a.Number).Select(a => a.Number).ToArray();

                if (repeatRandom >= 17)
                    notes = notes.OrderBy(a => a).ToArray();
                else if (repeatRandom >= 2)
                    notes = notes.Randomize().Take(notes.Length).ToArray();

                var repeat = new List<PlayLineNotes>();
                for (int j = 0; j < notes.Length; j++)
                {
                    var newNote = GetNote(playLine.NoteQueue.Count + 1, tempo, template.AllNoteValues[j].NoteValue, noteList, notes[j]);
                    playLine.NoteQueue.Add(newNote);
                    repeat.Add(newNote);
                }

                if(repeatRandom > 15)
                {
                    foreach (var item in repeat)
                        playLine.NoteQueue.Add(item);
                    foreach (var item in repeat)
                        playLine.NoteQueue.Add(item);
                }
                else if(repeatRandom > 12)
                    foreach (var item in repeat)
                        playLine.NoteQueue.Add(item);

                if (repeatRandom % 3 == 0)
                    playLine.NoteQueue.Add(new PlayLineNotes() { IsPlayed = false, Length = tempo.QuarterLength, Note = null, Order = playLine.NoteQueue.Count + 1, Silence = true });
            }

            return playLine;
        }

        private static PlayLineNotes GetNote(int order, ITempoForBars tempo, NoteValue value, List<Note.Note> noteList, int noteNumber)
        {
            return new PlayLineNotes()
            {
                IsPlayed = false,
                Length = tempo.LengthByTempo(value),
                Note = noteNumber != 0 ? noteList.FirstOrDefault(a => a.Number == noteNumber) : null,
                Order = order,
                Silence = false
            };

        }

    }
}
