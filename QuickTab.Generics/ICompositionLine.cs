namespace QuickTab.Generics
{
    public interface ICompositionLine
    {
        /// <summary>
        /// The line number to which this line belongs.
        /// Used to sort lines.
        /// </summary>
        int LineNumber { get; }

        /// <summary>
        /// The content to be displayed on the line
        /// </summary>
        string Content { get; }
    }
}
