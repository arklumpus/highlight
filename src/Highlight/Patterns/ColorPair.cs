using VectSharp;

namespace Highlight.Patterns
{
    public class ColorPair
    {
        public Colour ForeColor { get; set; }
        public Colour BackColor { get; set; }

        public ColorPair()
        {
        }

        public ColorPair(Colour foreColor, Colour backColor)
        {
            ForeColor = foreColor;
            BackColor = backColor;
        }
    }
}