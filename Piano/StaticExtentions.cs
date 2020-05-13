using Piano;
using Piano.Generate;
using Piano.Player;
using Piano.Tempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    public static class StaticExtentions
    {
        public static double LengthByTempo(this ITempoForBars tempo, NoteValue value)
        {
            switch (value)
            {
                case NoteValue.Quarter:
                    return tempo.QuarterLength;
                case NoteValue.DottedQuarter:
                    return tempo.DottedQuarterLength;
                case NoteValue.Half:
                    return tempo.HalfLength;
                case NoteValue.Eighth:
                    return tempo.EighthLength;
                case NoteValue.DottedEighth:
                    return tempo.DottedEighthLength;
                case NoteValue.Sixteenth:
                    return tempo.SixteenthLength;
                case NoteValue.DottedSixteenth:
                    return tempo.DottedSixteenthLength;
                case NoteValue.ThirtySecond:
                    return tempo.ThirtySecondLength;
                case NoteValue.DottedThirtySecond:
                    return tempo.DottedThirtySecondLength;
                case NoteValue.SixtyFourth:
                    return tempo.SixtyFourthLength;
                case NoteValue.DottedSixtyFourth:
                    return tempo.DottedSixtyFourthLength;
                case NoteValue.HundredTwentyEighth:
                    return tempo.HundredTwentyEighthLength;
                default:
                    return 0;
            }
        }

        public static IEnumerable<int> Randomize(this int[] notes)
        {
            Random r = new Random();
            int diceBy5 = r.Next(0, 6);
            Randomization randomNotes;
            switch (diceBy5)
            {
                case 0:
                    randomNotes = new Randomization(PlayTypeSign.Melody, notes);
                    return randomNotes.GetList();
                case 1:
                    randomNotes = new Randomization(PlayTypeSign.GetByBase, notes);
                    return randomNotes.GetList();
                case 2:
                    randomNotes = new Randomization(PlayTypeSign.Melody2, notes);
                    return randomNotes.GetList();
                case 3:
                    randomNotes = new Randomization(PlayTypeSign.OrderAsc, notes);
                    return randomNotes.GetList();
                case 4:
                    randomNotes = new Randomization(PlayTypeSign.OrderAscBy2Step, notes);
                    return randomNotes.GetList();
                case 5:
                    randomNotes = new Randomization(PlayTypeSign.OrderAscBy3Step, notes);
                    return randomNotes.GetList();
                case 6:
                    randomNotes = new Randomization(PlayTypeSign.OrderDes, notes);
                    return randomNotes.GetList();
                case 7:
                    randomNotes = new Randomization(PlayTypeSign.OrderDesBy2Step, notes);
                    return randomNotes.GetList();
                case 8:
                    randomNotes = new Randomization(PlayTypeSign.OrderDesBy3Step, notes);
                    return randomNotes.GetList();
                case 9:
                    randomNotes = new Randomization(PlayTypeSign.OrderingStep3, notes);
                    return randomNotes.GetList();
                case 10:
                    randomNotes = new Randomization(PlayTypeSign.OrderingStep3Backward, notes);
                    return randomNotes.GetList();
                case 11:
                    randomNotes = new Randomization(PlayTypeSign.OrderNotes, notes);
                    return randomNotes.GetList();
                case 12:
                    randomNotes = new Randomization(PlayTypeSign.Shuffle1, notes);
                    return randomNotes.GetList();
                case 13:
                    randomNotes = new Randomization(PlayTypeSign.Shuffle2, notes);
                    return randomNotes.GetList();
                case 14:
                    randomNotes = new Randomization(PlayTypeSign.Shuffle3, notes);
                    return randomNotes.GetList();
                default:
                    break;
            }
            randomNotes = new Randomization(PlayTypeSign.Melody, notes);
            return randomNotes.GetList();
        }

        private static PlayLineNotes GetNote(this NoteValue value, int order, ITempoForBars tempo, List<Note.Note> asNotes, List<Note.Note> deNotes, int noteNumber)
        {
            return new PlayLineNotes()
            {
                IsPlayed = false,
                Length = tempo.LengthByTempo(value),
                Note = noteNumber != 0 ? asNotes.FirstOrDefault(a => a.Number == noteNumber) : null,
                Order = order,
                Silence = false
            };
        }
    }
}
