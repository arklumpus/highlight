namespace Highlight.Patterns
{
    public struct Font
    {
        public bool IsBold { get; }
        public bool IsItalic { get; }

        public Font(bool isBold, bool isItalic)
        {
            this.IsBold = isBold;
            this.IsItalic = isItalic;
        }
    }
}
