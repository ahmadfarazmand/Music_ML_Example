using Piano.Generate;
using Piano.Scale;
using Piano.Tempo.BarsTempo;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano.Player
{
    public partial class Listen : Form
    {
        ChannelMessageBuilder builder;
        OutputDevice outDevice;

        private List<NameValue> _scaleType = new List<NameValue>();
        private List<NameValue> _scalePosType = new List<NameValue>();
        private List<NameValue> _playType = new List<NameValue>();
        private List<NameValue> _rythmType = new List<NameValue>();
        private List<NameValue> _orderNoteType = new List<NameValue>();
        private List<ScaleNameValue> _scales = new List<ScaleNameValue>();
        private PlayLineHarmony _currentPlay = new PlayLineHarmony();
        private Tempo.Tempo _tempo = new Tempo.Tempo();
        private List<IBarTemplateModel> _templates = new List<IBarTemplateModel>();
        private List<ScaleNameValue> _scalesSeleted = new List<ScaleNameValue>();
        private int _tempoValue = 80;
        private ITempoForBars _tempoForBars;

        public Listen()
        {
            InitializeComponent();

            _playType = GetPlayTypes();
            _rythmType = GetRythmTypes();
            _scales = GetScales();
            _scaleType = GetScaleTypes();
            _scalePosType = GetScalePosTypes();
            _orderNoteType = GetScaleNoteOrderTypes();

            numericTempoValue.Maximum = 240;
            playType.DataSource = _playType.Select(a => a.Name).ToArray();
            comboBoxRythm.DataSource = _rythmType.Select(a => a.Name).ToArray();
            comboBoxRythm.SelectedIndex = 0;
            comboBoxScalePos.DataSource = _scalePosType.Select(a => a.Name).ToArray();
            comboBoxScalePos.SelectedIndex = 0;
            comboBoxScaleType.DataSource = _scaleType.Select(a => a.Name).ToArray();
            comboBoxScaleType.SelectedIndex = 0;
            listBoxScale.DataSource = _scales.Select(a => a.Name).ToArray();
            numericTempoValue.Value = _tempoValue;
            comboBoxScaleNoteOrder.DataSource = _orderNoteType.Select(a => a.Name).ToArray();
            comboBoxScaleNoteOrder.SelectedIndex = 0;
            _tempo = new Tempo.Tempo((int)numericTempoValue.Value);
            playType.SelectedIndex = 0;
            outDevice = new OutputDevice(0);
            Console.Beep();
            UpdateTempaltes(comboBoxRythm.SelectedIndex);
            UpdataScaleList();
        }

        private void BuildPlay()
        {
            switch (comboBoxScaleNoteOrder.SelectedIndex)
            {
                case 0:
                    TemplateGeneratorFactory desGnerator = new DescendingFactory();
                    GenerateTemplate generatorDes = new GenerateTemplate(desGnerator);
                    BuildScaleType(generatorDes);
                    break;
                case 1:
                    TemplateGeneratorFactory ascGnerator = new DescendingFactory();
                    GenerateTemplate generatorAsc = new GenerateTemplate(ascGnerator);
                    BuildScaleType(generatorAsc);
                    break;
                default:
                    break;
            }
        }

        public void BuildScaleType(GenerateTemplate generator)
        {
            switch (comboBoxScaleType.SelectedIndex)
            {
                case 0:
                    GenerateByHeptaFactory(generator.GenerateHeptatonic());
                    break;
                case 1:
                    GenerateByPentaFactory(generator.GeneratePentatonic());
                    break;
                default:
                    break;
            }

        }

        public void GenerateByPentaFactory(PentatonicGenerator pentaGenerator)
        {
            switch (comboBoxScalePos.SelectedIndex)
            {
                case 0:
                    var scaleMinor = PentaMinor();
                    List<Note.Note> noteListMinor = Note.NoteList.GetList(0, 9).Where(n => scaleMinor.Any(a => a == n.Name)).ToList();
                    _currentPlay = pentaGenerator.Get4_4Templates(_tempoForBars, _templates[(int)numericTemplates.Value], noteListMinor, PlayOrderType());
                    break;
                case 1:
                    var scaleMajor = PentaMajor();
                    List<Note.Note> noteListMajor = Note.NoteList.GetList(0, 9).Where(n => scaleMajor.Any(a => a == n.Name)).ToList();
                    _currentPlay = pentaGenerator.Get3_4Templates(_tempoForBars, _templates[(int)numericTemplates.Value], noteListMajor, PlayOrderType());
                    break;
                default:
                    break;
            }
        }

        public void GenerateByHeptaFactory(HeptatonicGenerator heptaGenerator)
        {
            switch (comboBoxScalePos.SelectedIndex)
            {
                case 0:
                    var scaleMinor = HeptaMinor();
                    List<Note.Note> noteListMinor = Note.NoteList.GetList(0, 9).Where(n => scaleMinor.Any(a => a == n.Name)).ToList();
                    _currentPlay = heptaGenerator.Get4_4Templates(_tempoForBars, _templates[(int)numericTemplates.Value], noteListMinor, PlayOrderType());
                    break;
                case 1:
                    var scaleMajor = HeptaMajor();
                    List<Note.Note> noteListMajor = Note.NoteList.GetList(0, 9).Where(n => scaleMajor.Any(a => a == n.Name)).ToList();
                    _currentPlay = heptaGenerator.Get3_4Templates(_tempoForBars, _templates[(int)numericTemplates.Value], noteListMajor, PlayOrderType());
                    break;
                default:
                    break;
            }
        }

        public string[] HeptaMinor()
        {
            switch (_scales[listBoxScale.SelectedIndex].Name)
            {
                case "C#":
                    IMinorHeptatonicScale iMinorHeptaScaleC = new Minor_Scale_Hepta();
                    C_Sharp_Minor_Scale_Hepta scaleC = new C_Sharp_Minor_Scale_Hepta(iMinorHeptaScaleC);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleC.AscendingNotes;
                    else
                        return scaleC.DescendingNotes;
                case "Hungarian":
                    IMinorHeptatonicScale iMinorHeptaScaleHungarian = new Minor_Scale_Hepta();
                    Hungarian_Minor_Scale_Hepta scaleHungarian = new Hungarian_Minor_Scale_Hepta(iMinorHeptaScaleHungarian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleHungarian.AscendingNotes;
                    else
                        return scaleHungarian.DescendingNotes;
                case "Natural":
                    IMinorHeptatonicScale iMinorHeptaScaleNatural = new Minor_Scale_Hepta();
                    Natural_Minor_Scale_Hepta scaleNatural = new Natural_Minor_Scale_Hepta(iMinorHeptaScaleNatural);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleNatural.AscendingNotes;
                    else
                        return scaleNatural.DescendingNotes;
                case "Double Harmonic":
                    IMinorHeptatonicScale iMinorHeptaScaleDouble = new Minor_Scale_Hepta();
                    Double_Harmonic_Minor_Scale_Hepta scaleDouble = new Double_Harmonic_Minor_Scale_Hepta(iMinorHeptaScaleDouble);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleDouble.AscendingNotes;
                    else
                        return scaleDouble.DescendingNotes;

                case "Persian":
                    IMinorHeptatonicScale iMinorHeptaScalePersian = new Minor_Scale_Hepta();
                    Persian_Minor_Scale_Hepta scalePersian = new Persian_Minor_Scale_Hepta(iMinorHeptaScalePersian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scalePersian.AscendingNotes;
                    else
                        return scalePersian.DescendingNotes;
                case "":

                    break;
                default:
                    break;
            }
            return null;
        }

        public string[] HeptaMajor()
        {
            switch (_scalesSeleted[listBoxScale.SelectedIndex].Name)
            {
                case "C#":
                    IMajorHeptatonicScale iMajorHeptaScaleC = new Major_Scale_Hepta();
                    C_Sharp_Major_Scale_Hepta scaleC = new C_Sharp_Major_Scale_Hepta(iMajorHeptaScaleC);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleC.AscendingNotes;
                    else
                        return scaleC.DescendingNotes;
                case "Lydian":
                    IMajorHeptatonicScale iMajorHeptaScaleLydian = new Major_Scale_Hepta();
                    Lydian_Mode_Major_Scale_Hepta scaleLydian = new Lydian_Mode_Major_Scale_Hepta(iMajorHeptaScaleLydian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleLydian.AscendingNotes;
                    else
                        return scaleLydian.DescendingNotes;
                case "Major":
                    IMajorHeptatonicScale iMajorHeptaScaleMajor = new Major_Scale_Hepta();
                    Root_Major_Scale_Hepta scaleMajor = new Root_Major_Scale_Hepta(iMajorHeptaScaleMajor);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleMajor.AscendingNotes;
                    else
                        return scaleMajor.DescendingNotes;
                case "Mixolydian Mode":
                    IMajorHeptatonicScale iMajorHeptaScaleMixolydian = new Major_Scale_Hepta();
                    Mixolydian_Major_Scale_Hepta scaleMixolydian = new Mixolydian_Major_Scale_Hepta(iMajorHeptaScaleMixolydian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleMixolydian.AscendingNotes;
                    else
                        return scaleMixolydian.DescendingNotes;
                case "Phrygian Mode":
                    IMajorHeptatonicScale iMajorHeptaScalePhrygian = new Major_Scale_Hepta();
                    Phrygian_Major_Scale_Hepta scalePhrygian = new Phrygian_Major_Scale_Hepta(iMajorHeptaScalePhrygian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scalePhrygian.AscendingNotes;
                    else
                        return scalePhrygian.DescendingNotes;
                case "Phrygian Dominant":
                    IMajorHeptatonicScale iMajorHeptaScalePhrygianD = new Major_Scale_Hepta();
                    Phrygian_Dominant_Major_Scale_Hepta scalePhrygianD = new Phrygian_Dominant_Major_Scale_Hepta(iMajorHeptaScalePhrygianD);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scalePhrygianD.AscendingNotes;
                    else
                        return scalePhrygianD.DescendingNotes;
                case "Locrian":
                    IMajorHeptatonicScale iMajorHeptaScaleLocrian = new Major_Scale_Hepta();
                    Locrian_Dominant_Major_Scale_Hepta scaleLocrian = new Locrian_Dominant_Major_Scale_Hepta(iMajorHeptaScaleLocrian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleLocrian.AscendingNotes;
                    else
                        return scaleLocrian.DescendingNotes;
                case "Ukrainian Dorian":
                    IMajorHeptatonicScale iMajorHeptaScaleUkrainian = new Major_Scale_Hepta();
                    Ukrainian_Dorian_Major_Scale_Hepta scaleUkrainian = new Ukrainian_Dorian_Major_Scale_Hepta(iMajorHeptaScaleUkrainian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleUkrainian.AscendingNotes;
                    else
                        return scaleUkrainian.DescendingNotes;
                case "Dorian Mode":
                    IMajorHeptatonicScale iMajorHeptaScaleDorian = new Major_Scale_Hepta();
                    Dorian_Major_Scale_Hepta scaleDorian = new Dorian_Major_Scale_Hepta(iMajorHeptaScaleDorian);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scaleDorian.AscendingNotes;
                    else
                        return scaleDorian.DescendingNotes;
                case "":

                    break;
                default:
                    break;
            }
            return null;
        }

        public string[] PentaMinor()
        {
            switch (_scales[listBoxScale.SelectedIndex].Name)
            {
                case "C#":
                    IMinorPentatonicScale iMinorPentaScale = new Minor_Scale_Penta();
                    C_Sharp_Minor_Scale_Penta scale = new C_Sharp_Minor_Scale_Penta(iMinorPentaScale);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scale.AscendingNotes;
                    else
                        return scale.DescendingNotes;
                case "":

                    break;
                default:
                    break;
            }
            return null;
        }

        public string[] PentaMajor()
        {
            switch (_scales[listBoxScale.SelectedIndex].Name)
            {
                case "C#":
                    IMajorPentatonicScale iMajorPentaScale = new Major_Scale_Penta();
                    C_Sharp_Major_Scale_Penta scale = new C_Sharp_Major_Scale_Penta(iMajorPentaScale);
                    if (comboBoxScaleNoteOrder.SelectedIndex == 0)
                        return scale.AscendingNotes;
                    else
                        return scale.DescendingNotes;
                case "":

                    break;
                default:
                    break;
            }
            return null;
        }

        public void UpdataScaleList()
        {
            _scalesSeleted = _scales.Where(a => a.Pos == comboBoxScalePos.SelectedIndex && a.Type == comboBoxScaleType.SelectedIndex).ToList();
            listBoxScale.DataSource = _scalesSeleted.Select(a => a.Name).ToArray();
            listBoxScale.Refresh();
            listBoxScale.SelectedIndex = _scalesSeleted.Count - 1;
        }

        private void comboBoxScaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdataScaleList();
        }

        private void comboBoxScalePos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdataScaleList();
        }

        private void comboBoxRythm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTempaltes(comboBoxRythm.SelectedIndex);
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            try
            {
                PlayCurrent();
            }
            catch (Exception)
            {
            }
            
        }

        private void buttonNewPlay_Click(object sender, EventArgs e)
        {
            BuildPlay();
            PlayCurrent();
        }

        private void UpdateTempaltes(int index)
        {
            switch (_rythmType[index].Value)
            {
                case 0:
                    _templates = TempoFor4_4Bars.GetAllAvailableTemplates().ToList();
                    _tempoForBars = _tempo.Tempo4_4;
                    break;
                case 1:
                    _templates = TempoFor3_4Bars.GetAllAvailableTemplates().ToList();
                    _tempoForBars = _tempo.Tempo3_4;
                    break;
                default:
                    break;
            }
            numericTemplates.Maximum = _templates.Count - 1;
            numericTemplates.Value = 0;
        }

        private PlayOrderType PlayOrderType()
        {
            switch (playType.SelectedIndex)
            {
                case 0:
                    return Generate.PlayOrderType.Randomize;
                case 1:
                    return Generate.PlayOrderType.Ascending;
                case 2:
                    return Generate.PlayOrderType.Descending;
                default:
                    return Generate.PlayOrderType.Randomize;
            }
        }

        private void PlayCurrent()
        {
            builder = new ChannelMessageBuilder(new ChannelMessage(ChannelCommand.ProgramChange, 1, (int)_currentPlay.Instrument));
            _currentPlay.NoteQueue.ForEach(a => a.IsPlayed = false);
            Task.Run(() =>
            {
                var chooseNote = _currentPlay.NoteQueue.OrderBy(a => a.Order).FirstOrDefault(a => !a.IsPlayed);

                while (chooseNote != null && !outDevice.IsDisposed)
                {
                    if (!chooseNote.Silence && chooseNote.Note != null)
                    {
                        builder.Command = ChannelCommand.NoteOn;
                        builder.MidiChannel = 1;
                        builder.Data1 = chooseNote.Note.Number;
                        builder.Data2 = 127;
                        builder.Build();
                        outDevice.Send(builder.Result);
                        Thread.Sleep((int)chooseNote.Length);
                        builder.Command = ChannelCommand.NoteOff;
                        builder.Data2 = 0;
                        builder.Build();
                        try
                        {
                            if (!outDevice.IsDisposed)
                                outDevice.Send(builder.Result);
                        }
                        catch (Exception)
                        {
                        }
                        chooseNote.IsPlayed = true;
                    }
                    else
                    {
                        Thread.Sleep((int)chooseNote.Length);
                        chooseNote.IsPlayed = true;
                    }
                    chooseNote = _currentPlay.NoteQueue.OrderBy(a => a.Order).FirstOrDefault(a => !a.IsPlayed);
                }
            });
        }

        private List<NameValue> GetScaleTypes()
        {
            return new List<NameValue>()
            {
                new NameValue() { Name = "Heptatonic", Value = 0 },
                new NameValue() { Name = "Pentatonic", Value = 1 }
            };
        }

        private List<NameValue> GetScalePosTypes()
        {
            return new List<NameValue>()
            {
                new NameValue() { Name = "Minor", Value = 0 },
                new NameValue() { Name = "Major", Value = 1 }
            };
        }

        private List<NameValue> GetPlayTypes()
        {
            return new List<NameValue>()
            {
                new NameValue() { Name = "Randomize", Value = 0 },
                new NameValue() { Name = "Ascending", Value = 1 },
                new NameValue() { Name = "Desnending", Value = 2 },
            };
        }

        private List<ScaleNameValue> GetScales()
        {
            return new List<ScaleNameValue>()
            {
                //Heptatonic Minor
                new ScaleNameValue() { Name = "C#", Pos = 0, Type = 0 },
                new ScaleNameValue() { Name = "Hungarian", Pos = 0, Type = 0 },
                new ScaleNameValue() { Name = "Natural", Pos = 0, Type = 0 },
                new ScaleNameValue() { Name = "Double Harmonic", Pos = 0, Type = 0 },
                new ScaleNameValue() { Name = "Persian", Pos = 0, Type = 0 },

                //Heptatonic Major
                new ScaleNameValue() { Name = "C#", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Lydian", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Major", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Mixolydian Mode", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Phrygian Mode", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Phrygian Dominant", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Locrian", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Ukrainian Dorian", Pos = 1, Type = 0 },
                new ScaleNameValue() { Name = "Dorian Mode", Pos = 1, Type = 0 },
                
                
                
                
                
                //Pentatonics
                new ScaleNameValue() { Name = "C#", Pos = 0, Type = 1 },
                new ScaleNameValue() { Name = "C#", Pos = 1, Type = 1 },
            };
        }

        private List<NameValue> GetRythmTypes()
        {
            return new List<NameValue>()
            {
                new NameValue() { Name = "4/4", Value = 0 },
                new NameValue() { Name = "3/4", Value = 1 }
            };
        }

        private List<NameValue> GetScaleNoteOrderTypes()
        {
            return new List<NameValue>()
            {
                new NameValue() { Name = "Ascending Notes", Value = 0 },
                new NameValue() { Name = "Desnending Notes", Value = 1 }
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericTempoValue_ValueChanged(object sender, EventArgs e)
        {
            _tempo = new Tempo.Tempo((int)numericTempoValue.Value);
            switch (comboBoxRythm.SelectedIndex)
            {
                case 0:
                    _tempoForBars = _tempo.Tempo4_4;
                    break;
                case 1:
                    _tempoForBars = _tempo.Tempo3_4;
                    break;
                default:
                    break;
            }
        }

        private void Listen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            if (!outDevice.IsDisposed)
                outDevice.Dispose();
        }
    }

    public class ScaleNameValue
    {
        public string Name { get; set; }
        public int Pos { get; set; }
        public int Type { get; set; }

    }

    public class NameValue
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
