using System;
using System.Collections.Generic;
using QuickTab.Generics;

namespace QuickTab.Models
{
    /// <summary>
    /// Represents a single line of tabliture which is part of a tab
    /// </summary>
    public class TabLine : ICompositionLine
    {
        #region [ Properties ]
        /// <summary>
        /// A collection of items that are on this line of tabliture
        /// </summary>
        private List<ITabLineItem> _items = new List<ITabLineItem>();

        /// <summary>
        /// Used to arrange strings of tabliture within a tab
        /// </summary>
        public int LineNumber { get; private set; }

        /// <summary>
        /// Returns a string representation of this line of tabliture
        /// </summary>
        public string Content
        {
            get
            {
                // NOTE: in the view, a tabitem would bind to a datacontext that is either null or an ITabLineItem
                string c = string.Empty;

                foreach(ITabLineItem i in _items)
                {
                    c += i.Text.PadLeft(i.PreceedingSpaces, '-');
                }

                return c;
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates an empty line of tabliture that is arranged with other tab lines
        /// </summary>
        /// <param name="order"></param>
        public TabLine(int order)
        {
            LineNumber = order;
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Adds a note to the list of items on this line
        /// </summary>
        /// <param name="fret">The fret number to play</param>
        /// <param name="predeedingSpaces">The number of spaces preceeding this note</param>
        /// <param name="order">Used to sort a line of ITabLineItems in a tab line</param>
        public void AddNote(int fret, int preceedingSpaces, int order)
        {
            _items.Add(new Note(fret, preceedingSpaces, order));
        }

        /// <summary>
        /// Adds an acent to the list of items on this line
        /// </summary>
        /// <param name="accentText">The accent text</param>
        /// <param name="preceedingSpaces">The number of spaces preceeding this accent</param>
        /// <param name="order">Used to sort a line of ITabLineItems in a tab line</param>
        public void AddAccent(string accentText, int preceedingSpaces, int order)
        {
            _items.Add(new Accent(accentText, order, preceedingSpaces));
        }
        #endregion
    }
}
