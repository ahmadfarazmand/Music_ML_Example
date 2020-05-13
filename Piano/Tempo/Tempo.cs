using Piano.Tempo.BarsTempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Tempo
{
    public class Tempo
    {
        private int _tempo = 120;

        public Tempo()
        {

        }

        public Tempo(int tempo)
        {
            _tempo = tempo;
        }

        public TempoFor4_4Bars Tempo4_4
        {
            get
            {
                return new TempoFor4_4Bars(_tempo);
            }
        }

        public TempoFor3_4Bars Tempo3_4
        {
            get
            {
                return new TempoFor3_4Bars(_tempo);
            }
        }
    }

    public class BeatModel
    {
        public int OrderIndex { get; set; }
        public List<NoteValueLengthIdentity> NoteValues { get; set; }
    }

    public class NoteValueLengthIdentity
    {
        public int OrderIndex { get; set; }
        public NoteValue NoteValue { get; set; }
        public double NormalLength
        {
            get
            {
                TempoFor4_4Bars barModel = new TempoFor4_4Bars(120);
                switch (NoteValue)
                {
                    case NoteValue.Quarter:
                        return barModel.QuarterLength;
                    case NoteValue.DottedQuarter:
                        return barModel.DottedQuarterLength;
                    case NoteValue.Half:
                        return barModel.HalfLength;
                    case NoteValue.Eighth:
                        return barModel.EighthLength;
                    case NoteValue.DottedEighth:
                        return barModel.DottedEighthLength;
                    case NoteValue.Sixteenth:
                        return barModel.SixteenthLength;
                    case NoteValue.DottedSixteenth:
                        return barModel.DottedSixteenthLength;
                    case NoteValue.ThirtySecond:
                        return barModel.ThirtySecondLength;
                    case NoteValue.DottedThirtySecond:
                        return barModel.DottedThirtySecondLength;
                    case NoteValue.SixtyFourth:
                        return barModel.SixtyFourthLength;
                    case NoteValue.DottedSixtyFourth:
                        return barModel.DottedSixtyFourthLength;
                    case NoteValue.HundredTwentyEighth:
                        return barModel.HundredTwentyEighthLength;
                    default:
                        return 0;
                }
            }
        }
        public bool IsPulledFromPrevious { get; set; }
    }

    public enum NoteValue
    {
        Quarter = 0,
        DottedQuarter = 1,
        Half = 2,
        Eighth = 3,
        DottedEighth = 4,
        Sixteenth = 5,
        DottedSixteenth = 6,
        ThirtySecond = 7,
        DottedThirtySecond = 8,
        SixtyFourth = 9,
        DottedSixtyFourth = 10,
        HundredTwentyEighth = 11
    }


}
