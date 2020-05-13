using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Scale
{
    //https://en.wikipedia.org/wiki/Scale_(music) Learn about sacales 

    public interface IScale
    {
        ScaleType Type { get; }
        ScalePos Pos { get; }
    }

    public interface IHeptaScaleIdentity
    {
        string Name { get; }
        int ID { get; }
        string[] AscendingNotes { get; }
        string[] DescendingNotes { get; }
        string StartNote { get; }
        string DescendingStartNote { get; }
        string FinishNote { get; }
        string DescendingFinishNote { get; }
    }

    public interface IPentaScaleIdentity
    {
        string Name { get; }
        int ID { get; }
        string[] AscendingNotes { get; }
        string[] DescendingNotes { get; }
        string StartNote { get; }
        string DescendingStartNote { get; }
        string FinishNote { get; }
        string DescendingFinishNote { get; }
    }

    public interface IMajorHeptatonicScale : IScale
    {
        bool AcceptModelation { get; }
        int[] ModelationSupportScalesId { get; }
    }

    public interface IMinorHeptatonicScale : IScale
    {
        bool AcceptModelation { get; }
        int[] ModelationSupportScalesId { get; }
    }

    public interface IMajorPentatonicScale : IScale
    {
        bool AcceptModelation { get; }
        int[] ModelationSupportScalesId { get; }
    }

    public interface IMinorPentatonicScale : IScale
    {
        bool AcceptModelation { get; }
        int[] ModelationSupportScalesId { get; }
    }

    public class Major_Scale_Hepta : IMajorHeptatonicScale
    {
        public ScaleType Type { get { return ScaleType.Heptatonic; } }
        public ScalePos Pos { get { return ScalePos.Major; } }
        public bool AcceptModelation { get { return false; } }
        public int[] ModelationSupportScalesId { get { return null; } }
    }

    public class Minor_Scale_Hepta : IMinorHeptatonicScale
    {
        public ScaleType Type { get { return ScaleType.Heptatonic; } }
        public ScalePos Pos { get { return ScalePos.Minor; } }
        public bool AcceptModelation { get { return false; } }
        public int[] ModelationSupportScalesId { get { return null; } }
    }

    public class Major_Scale_Penta : IMajorPentatonicScale
    {
        public ScaleType Type { get { return ScaleType.Pentatonic; } }
        public ScalePos Pos { get { return ScalePos.Major; } }
        public bool AcceptModelation { get { return false; } }
        public int[] ModelationSupportScalesId { get { return null; } }
    }

    public class Minor_Scale_Penta : IMinorPentatonicScale
    {
        public ScaleType Type { get { return ScaleType.Pentatonic; } }
        public ScalePos Pos { get { return ScalePos.Minor; } }
        public bool AcceptModelation { get { return false; } }
        public int[] ModelationSupportScalesId { get { return null; } }
    }


    public class C_Sharp_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public C_Sharp_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Heptatonic C# Major"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C#", "D#", "F", "F#", "G#", "A#", "C", "C#" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C#", "D#", "F", "F#", "G#", "A#", "C", "C#" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }

    //https://www.johndcook.com/blog/2017/09/30/how-many-musical-scales-are-there/

    public class Lydian_Mode_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Lydian_Mode_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Lydian Mode"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D","E","F#","G","A","B","C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "E", "F#", "G", "A", "B", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }

    public class Root_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Root_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Major"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "E", "F", "G", "A", "B", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "E", "F", "G", "A", "B", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }

    public class Mixolydian_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Mixolydian_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Mixolydian Mode"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "E", "F", "G", "A", "B", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "E", "F", "G", "A", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }

    public class Phrygian_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Phrygian_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Phrygian Mode"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "C#", "D#", "F", "G", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "C#", "D#", "F", "G", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }


    public class Phrygian_Dominant_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Phrygian_Dominant_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Phrygian Dominant"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "C#", "E", "F", "G", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "C#", "E", "F", "G", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }

    public class Locrian_Dominant_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Locrian_Dominant_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Locrian"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "C#", "D#", "F", "F#", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "C#", "D#", "F", "F#", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }


    public class Ukrainian_Dorian_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Ukrainian_Dorian_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Ukrainian Dorian"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }

    public class Dorian_Major_Scale_Hepta : IMajorHeptatonicScale, IHeptaScaleIdentity
    {
        IMajorHeptatonicScale Heptatonic;
        public Dorian_Major_Scale_Hepta(IMajorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Dorian Mode"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C"; } }
        public virtual string DescendingStartNote { get { return "G"; } }
        public virtual string FinishNote { get { return "F"; } }
        public virtual string DescendingFinishNote { get { return "C"; } }
    }




















    public class C_Sharp_Minor_Scale_Hepta : IMinorHeptatonicScale, IHeptaScaleIdentity
    {
        IMinorHeptatonicScale Heptatonic;
        public C_Sharp_Minor_Scale_Hepta(IMinorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Heptatonic C# Minor"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C#", "D#", "E", "F#", "G#", "A#", "B#", "C#" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C#", "D#", "E", "F#", "G#", "A#", "B#", "C#" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }


    public class Hungarian_Minor_Scale_Hepta : IMinorHeptatonicScale, IHeptaScaleIdentity
    {
        IMinorHeptatonicScale Heptatonic;
        public Hungarian_Minor_Scale_Hepta(IMinorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Hungarian Minor"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "B", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "D#", "F#", "G", "G#", "B", "C" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }


    public class Natural_Minor_Scale_Hepta : IMinorHeptatonicScale, IHeptaScaleIdentity
    {
        IMinorHeptatonicScale Heptatonic;
        public Natural_Minor_Scale_Hepta(IMinorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Natural Minor"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "D", "D#", "F", "G", "G#", "A#", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "D", "D#", "F", "G", "G#", "A#", "C" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }


    public class Double_Harmonic_Minor_Scale_Hepta : IMinorHeptatonicScale, IHeptaScaleIdentity
    {
        IMinorHeptatonicScale Heptatonic;
        public Double_Harmonic_Minor_Scale_Hepta(IMinorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Double Harmonic"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "C#", "E", "F", "G", "G#", "B", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "C#", "E", "F", "G", "G#", "B", "C" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }

    public class Persian_Minor_Scale_Hepta : IMinorHeptatonicScale, IHeptaScaleIdentity
    {
        IMinorHeptatonicScale Heptatonic;
        public Persian_Minor_Scale_Hepta(IMinorHeptatonicScale heptaScale)
        {
            this.Heptatonic = heptaScale;
        }
        public ScaleType Type { get { return this.Heptatonic.Type; } }
        public ScalePos Pos { get { return this.Heptatonic.Pos; } }
        public string Name { get { return "Persian Minor"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C", "C#", "E", "F", "F#", "G#", "B", "C" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C", "C#", "E", "F", "G", "G#", "B", "C" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }

















































    public class C_Sharp_Major_Scale_Penta : IMajorPentatonicScale, IPentaScaleIdentity
    {
        IMajorPentatonicScale Pentatonic;
        public C_Sharp_Major_Scale_Penta(IMajorPentatonicScale pentaScale)
        {
            this.Pentatonic = pentaScale;
        }
        public ScaleType Type { get { return this.Pentatonic.Type; } }
        public ScalePos Pos { get { return this.Pentatonic.Pos; } }
        public string Name { get { return "Heptatonic C# Major"; } }
        public int ID { get { return 1; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 2 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C#", "D#", "F", "G#", "A#", "C#" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C#", "D#", "F", "G#", "A#", "C#" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }

    public class C_Sharp_Minor_Scale_Penta : IMinorPentatonicScale, IPentaScaleIdentity
    {
        IMinorPentatonicScale Pentatonic;
        public C_Sharp_Minor_Scale_Penta(IMinorPentatonicScale pentaScale)
        {
            this.Pentatonic = pentaScale;
        }
        public ScaleType Type { get { return this.Pentatonic.Type; } }
        public ScalePos Pos { get { return this.Pentatonic.Pos; } }
        public string Name { get { return "Heptatonic C# Minor"; } }
        public int ID { get { return 2; } }
        public virtual bool AcceptModelation { get { return true; } }
        public virtual int[] ModelationSupportScalesId { get { return new int[] { 1 }; } }
        public virtual string[] AscendingNotes { get { return new string[] { "C#", "E", "F#", "G#", "B", "C#" }; } }
        public virtual string[] DescendingNotes { get { return new string[] { "C#", "E", "F#", "G#", "B", "C#" }; } }
        public virtual string StartNote { get { return "C#"; } }
        public virtual string DescendingStartNote { get { return "G#"; } }
        public virtual string FinishNote { get { return "F#"; } }
        public virtual string DescendingFinishNote { get { return "C#"; } }
    }

    public enum ScaleType
    {
        Chromatic = 0,
        Octatonic = 1,
        Heptatonic = 2,
        Hexatonic = 3,
        Pentatonic = 4
    }

    public enum ScalePos
    {
        Major = 0,
        Minor = 1
    }
}
