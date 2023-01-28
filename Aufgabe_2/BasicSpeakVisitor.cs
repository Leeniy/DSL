using static SpeakParser;

namespace Aufgabe_2
{
    public class BasicSpeakVisitor : SpeakBaseVisitor<object>
    {
        public List<SpeakLine> Lines = new List<SpeakLine>();
        public override object VisitLine(SpeakParser.LineContext context)
        {            
            NameContext name = context.name();
            OpinionContext opinion = context.opinion();
            SpeakLine line = new SpeakLine() { Person = name.GetText(), Text = opinion.GetText().Trim('"') };
            Lines.Add(line);
            return line;
        }
    }
}