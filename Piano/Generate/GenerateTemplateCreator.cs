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
    public abstract class GenerateTemplateCreator
    {
        public static PlayLineHarmony GetResult(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            PlayLineHarmony playLine = new PlayLineHarmony();
            playLine.Instrument = Sanford.Multimedia.Midi.GeneralMidiInstrument.Accordion;
            playLine.Order = 1;
            playLine.Vol = 127;
            playLine.NoteQueue = new List<PlayLineNotes>();
            Random r = new Random();
            var repeatRandom = r.Next(0, 19);
            var minOctav = r.Next(3, 5);
            var maxOctav = r.Next(5, 7);
            var skipRandom = r.Next(1, 8);
            int[] notes = noteList.Where(a => a.Octave >= minOctav && a.Octave <= maxOctav).Skip(skipRandom).Take(template.NoteCount).OrderByDescending(a => a.Number).Select(a => a.Number).ToArray();
            if (orderType == PlayOrderType.Ascending)
                notes = notes.OrderBy(a => a).ToArray();
            else if (orderType == PlayOrderType.Randomize)
                notes = notes.Randomize().Take(notes.Length).ToArray();
            for (int j = 0; j < notes.Length; j++)
            {
                var newNote = GetNote(playLine.NoteQueue.Count + 1, tempo, template.AllNoteValues[j].NoteValue, noteList, notes[j]);
                playLine.NoteQueue.Add(newNote);
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

    public enum PlayOrderType
    {
        Ascending = 0,
        Descending = 1,
        Randomize = 2
    }

    public interface IBarTemplateModel
    {
        List<NoteValueLengthIdentity> AllNoteValues { get; }
        int NoteCount { get; }
        bool HaveError { get; }
    }

    public interface ITempoForBars
    {
        double ComputeBarLength { get; }
        double CountOfBeats { get; }
        double BarLength { get; }
        double QuarterLength { get; }
        double DottedQuarterLength { get; }
        double TripletQuarterLength { get; }
        bool SupportingHalfLength { get; }
        double HalfLength { get; }
        double EighthLength { get; }
        double DottedEighthLength { get; }
        double TripletEighthLength { get; }
        double SixteenthLength { get; }
        double DottedSixteenthLength { get; }
        double TripletSixteenthLength { get; }
        double ThirtySecondLength { get; }
        double DottedThirtySecondLength { get; }
        double TripletThirtySecondLength { get; }
        double SixtyFourthLength { get; }
        double DottedSixtyFourthLength { get; }
        double TripletSixtyFourthLength { get; }
        double HundredTwentyEighthLength { get; }
    }
}
