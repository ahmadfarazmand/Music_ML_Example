using Piano.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Generate
{
    public class HeptatonicAscendingTemplate : HeptatonicGenerator
    {
        public override PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo,template,noteList,orderType);
        }
        public override PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
    }

    public class PentatonicAscendingTemplate : PentatonicGenerator
    {
        public override PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
        public override PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
    }

    public class HeptatonicDescendingTemplate : HeptatonicGenerator
    {
        public override PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
        public override PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
    }

    public class PentatonicDescendingTemplate : PentatonicGenerator
    {
        public override PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
        public override PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType)
        {
            return GenerateTemplateCreator.GetResult(tempo, template, noteList, orderType);
        }
    }
}
