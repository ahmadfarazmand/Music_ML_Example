using Piano.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Tempo.BarsTempo
{
    public class TempoFor3_4Bars : ITempoForBars
    {
        private readonly short _binary = 2;
        // 120 = 500MS for each beat
        private readonly int _tempoBaseNumber = 120;
        private readonly int _tempoBaseLength = 1500;
        private readonly int _minute = 60000;
        private int _tempo = 120;
        private int _distance = 0;

        public TempoFor3_4Bars(int tempo)
        {
            _tempo = tempo;
            _distance = _tempoBaseNumber - tempo;
        }

        #region Properties

        public double ComputeBarLength
        {
            get
            {
                return QuarterLength * CountOfBeats;
            }
        }
        public double CountOfBeats { get { return 3; } }
        public double BarLength { get { return ComputeBarLength; } }
        public double QuarterLength { get { return _minute / _tempo; } }
        public double DottedQuarterLength { get { return QuarterLength + HalfLength; } }
        public double TripletQuarterLength { get { return QuarterLength / 3; } }
        public bool SupportingHalfLength { get { return CountOfBeats >= 2; } }
        public double HalfLength { get { return SupportingHalfLength ? QuarterLength * 2 : 0; } }
        public double EighthLength { get { return QuarterLength / _binary; } }
        public double DottedEighthLength { get { return EighthLength + SixteenthLength; } }
        public double TripletEighthLength { get { return EighthLength / 3; } }
        public double SixteenthLength { get { return EighthLength / _binary; } }
        public double DottedSixteenthLength { get { return SixteenthLength + ThirtySecondLength; } }
        public double TripletSixteenthLength { get { return SixteenthLength / 3; } }
        public double ThirtySecondLength { get { return SixteenthLength / _binary; } }
        public double DottedThirtySecondLength { get { return ThirtySecondLength + SixtyFourthLength; } }
        public double TripletThirtySecondLength { get { return ThirtySecondLength / 3; } }
        public double SixtyFourthLength { get { return ThirtySecondLength / _binary; } }
        public double DottedSixtyFourthLength { get { return SixtyFourthLength + HundredTwentyEighthLength; } }
        public double TripletSixtyFourthLength { get { return SixtyFourthLength / 3; } }
        public double HundredTwentyEighthLength { get { return SixtyFourthLength / _binary; } }

        #endregion

        public static IEnumerable<IBarTemplateModel> GetAllAvailableTemplates()
        {
            for (int i = 1; i < 14; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    for (int k = 1; k < 14; k++)
                    {
                        yield return new BarTemplateModel() { Beat1 = GetBeatModel1(i), Beat2 = GetBeatModel2(j), Beat3 = GetBeatModel3(k) };
                    }
                }
            }
        }

        public class BarTemplateModel : IBarTemplateModel
        {
            public BeatModel Beat1 { get; set; }
            public BeatModel Beat2 { get; set; }
            public BeatModel Beat3 { get; set; }
            public List<NoteValueLengthIdentity> AllNoteValues
            {
                get
                {
                    List<NoteValueLengthIdentity> result = new List<NoteValueLengthIdentity>();

                    result.AddRange(Beat1.NoteValues);
                    result.AddRange(Beat2.NoteValues);
                    result.AddRange(Beat3.NoteValues);

                    return result;
                }
            }
            public int NoteCount
            {
                get
                {
                    return AllNoteValues.Count;
                }
            }
            public bool HaveError
            {
                get
                {
                    var sum1 = Beat1.NoteValues.Sum(a => a.NormalLength);
                    var sum2 = Beat2.NoteValues.Sum(a => a.NormalLength);
                    var sum3 = Beat3.NoteValues.Sum(a => a.NormalLength);
                    return sum1 + sum2 + sum3 != 1500;
                }
            }
        }

        private static BeatModel GetBeatModel1(int swichMethod)
        {
            switch (swichMethod)
            {
                case 1:
                    return SimpleBeat1(1);
                case 2:
                    return SimpleBeat2(1);
                case 3:
                    return SimpleBeat3(1);
                case 4:
                    return SimpleBeat4(1);
                case 5:
                    return SimpleBeat5(1);
                case 6:
                    return SimpleBeat6(1);
                case 7:
                    return SimpleBeat7(1);
                case 8:
                    return SimpleBeat8(1);
                case 9:
                    return SimpleBeat9(1);
                case 10:
                    return SimpleBeat10(1);
                case 11:
                    return SimpleBeat11(1);
                case 12:
                    return SimpleBeat12(1);
                case 13:
                    return SimpleBeat13(1);
                default:
                    return SimpleBeat1(1);
            }
        }

        private static BeatModel GetBeatModel2(int swichMethod)
        {
            switch (swichMethod)
            {
                case 1:
                    return SimpleBeat1(2);
                case 2:
                    return SimpleBeat2(2);
                case 3:
                    return SimpleBeat3(2);
                case 4:
                    return SimpleBeat4(2);
                case 5:
                    return SimpleBeat5(2);
                case 6:
                    return SimpleBeat6(2);
                case 7:
                    return SimpleBeat7(2);
                case 8:
                    return SimpleBeat8(2);
                case 9:
                    return SimpleBeat9(2);
                case 10:
                    return SimpleBeat10(2);
                case 11:
                    return SimpleBeat11(2);
                case 12:
                    return SimpleBeat12(2);
                case 13:
                    return SimpleBeat13(2);
                default:
                    return SimpleBeat1(2);
            }
        }

        private static BeatModel GetBeatModel3(int swichMethod)
        {
            switch (swichMethod)
            {
                case 1:
                    return SimpleBeat1(3);
                case 2:
                    return SimpleBeat2(3);
                case 3:
                    return SimpleBeat3(3);
                case 4:
                    return SimpleBeat4(3);
                case 5:
                    return SimpleBeat5(3);
                case 6:
                    return SimpleBeat6(3);
                case 7:
                    return SimpleBeat7(3);
                case 8:
                    return SimpleBeat8(3);
                case 9:
                    return SimpleBeat9(3);
                case 10:
                    return SimpleBeat10(3);
                case 11:
                    return SimpleBeat11(3);
                case 12:
                    return SimpleBeat12(3);
                case 13:
                    return SimpleBeat13(3);
                default:
                    return SimpleBeat1(3);
            }
        }

        private static BeatModel SimpleBeat1(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate1()
            };
        }

        private static BeatModel SimpleBeat2(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate2()
            };
        }

        private static BeatModel SimpleBeat3(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate3()
            };
        }

        private static BeatModel SimpleBeat4(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate4()
            };
        }

        private static BeatModel SimpleBeat5(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate5()
            };
        }

        private static BeatModel SimpleBeat6(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate6()
            };
        }

        private static BeatModel SimpleBeat7(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate7()
            };
        }

        private static BeatModel SimpleBeat8(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate8()
            };
        }

        private static BeatModel SimpleBeat9(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate9()
            };
        }

        private static BeatModel SimpleBeat10(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate10()
            };
        }

        private static BeatModel SimpleBeat11(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate11()
            };
        }

        private static BeatModel SimpleBeat12(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate12()
            };
        }

        private static BeatModel SimpleBeat13(int i)
        {
            return new BeatModel()
            {
                OrderIndex = i,
                NoteValues = NoteValueTemplate13()
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate1()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Quarter,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate2()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate3()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = true
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate4()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.DottedEighth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate5()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.DottedEighth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate6()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate7()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate8()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate9()
        {
            return new List<NoteValueLengthIdentity>()
            { 
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate10()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.Eighth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                }
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate11()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 5,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 6,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 7,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 8,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate12()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 5,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 6,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 7,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 8,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
            };
        }

        private static List<NoteValueLengthIdentity> NoteValueTemplate13()
        {
            return new List<NoteValueLengthIdentity>()
            {
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 1,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 2,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 3,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 4,
                    NoteValue = NoteValue.ThirtySecond,
                    IsPulledFromPrevious = false
                },
                new NoteValueLengthIdentity()
                {
                    OrderIndex = 5,
                    NoteValue = NoteValue.Sixteenth,
                    IsPulledFromPrevious = false
                },
            };
        }


    }
}
