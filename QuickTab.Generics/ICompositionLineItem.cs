namespace QuickTab.Generics
{
    public interface ICompositionLineItem
    {
        /// <summary>
        /// The text of this line item
        /// </summary>
        string Text { get; }

        /// <summary>
        /// The number of spaces which preceed this line item
        /// </summary>
        int PreceedingSpaces { get; }
    }
}
