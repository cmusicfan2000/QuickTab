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
        /// A collection of notes that are on this line of tabliture
        /// </summary>
        private List<Note> _notes = new List<Note>();
\
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
                string c = string.Empty;

                foreach(Note n in _notes)
                {
                    c += n.Fret.ToString().PadLeft(n.PrecedingSpaces);
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
        /// Adds a note to the list of 
        /// </summary>
        /// <param name="fret">The fret number to play</param>
        /// <param name="predeedingSpaces">The number of spaces preceeding this note</param>
        /// <param name="order">Used to sort a line of notes in a tab</param>
        public void AddNote(int fret, int preceedingSpaces, int order)
        {
            _notes.Add(new Note(fret, preceedingSpaces, order));
        }
        #endregion
    }
}
