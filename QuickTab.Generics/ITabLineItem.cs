namespace QuickTab.Generics
{
    public interface ITabLineItem
    {
        /// <summary>
        /// The text of this line item
        /// </summary>
        string Text { get; }

        /// <summary>
        /// How this line item is ordered with other line items
        /// </summary>
        int Order { get; }

        /// <summary>
        /// The number of spaces which preceed this line item
        /// </summary>
        int PreceedingSpaces { get; }
    }
}
