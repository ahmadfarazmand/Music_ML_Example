using Piano.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Generate
{
    public class GenerateTemplate
    {
        private HeptatonicGenerator _heptatonicGenerator;
        private PentatonicGenerator _pentatonicGenerator;

        // Constructor
        public GenerateTemplate(TemplateGeneratorFactory factory)
        {
            _heptatonicGenerator = factory.HeptatonicGenerator();
            _pentatonicGenerator = factory.PentatonicGenerator();
        }

        public HeptatonicGenerator GenerateHeptatonic()
        {
            return _heptatonicGenerator;
        }

        public PentatonicGenerator GeneratePentatonic()
        {
            return _pentatonicGenerator;
        }
    }

    public class DescendingFactory : TemplateGeneratorFactory
    {
        public override PentatonicGenerator PentatonicGenerator()
        {
            return new PentatonicDescendingTemplate();
        }
        public override HeptatonicGenerator HeptatonicGenerator()
        {
            return new HeptatonicDescendingTemplate();
        }
    }

    public class AccendingFactory : TemplateGeneratorFactory
    {
        public override PentatonicGenerator PentatonicGenerator()
        {
            return new PentatonicAscendingTemplate();
        }
        public override HeptatonicGenerator HeptatonicGenerator()
        {
            return new HeptatonicAscendingTemplate();
        }
    }

    public abstract class TemplateGeneratorFactory
    {
        public abstract PentatonicGenerator PentatonicGenerator();
        public abstract HeptatonicGenerator HeptatonicGenerator();
    }

    public abstract class HeptatonicGenerator
    {
        public abstract PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType);
        public abstract PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType);
    }

    public abstract class PentatonicGenerator
    {
        public abstract PlayLineHarmony Get4_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType);
        public abstract PlayLineHarmony Get3_4Templates(ITempoForBars tempo, IBarTemplateModel template, List<Note.Note> noteList, PlayOrderType orderType);
    }
}
