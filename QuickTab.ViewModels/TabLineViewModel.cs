using System.Collections.Generic;
using QuickTab.Generics;
using QuickTab.Models;

namespace QuickTab.ViewModels
{
    public class TabLineViewModel : ICompositionLine
    {
        #region [ Properties ]
        /// <summary>
        /// A collection of items that are on this line of tabliture
        /// </summary>
        private List<ICompositionLineItem> _items = new List<ICompositionLineItem>();

        /// <summary>
        /// Returns a string representation of this line of tabliture
        /// </summary>
        public string Content
        {
            get
            {
                // NOTE: in the view, a tabitem would bind to a datacontext that is either null or an ITabLineItem
                string lineContent = string.Empty;

                foreach (ICompositionLineItem cli in _items)
                {
                    lineContent += cli.Text.PadLeft(cli.Text.Length + cli.PreceedingSpaces, '-');
                }

                return lineContent;
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a new tab line with the given content
        /// </summary>
        /// <param name="lineContent"></param>
        public TabLineViewModel(string lineContent)
        {
            int fretNumber;
            int preceedingSpaces = 0;
            string fretText = string.Empty;
            string accentText = string.Empty;
            bool IsNumber,
                 IsSpace,
                 IsAccent;

            foreach (char c in lineContent)
            {
                // Determine the character type
                IsNumber = char.IsNumber(c);
                IsSpace = c == '-';
                IsAccent = !IsNumber && !IsSpace && c != '|';

                // IF fretText is NOT empty AND
                // IF c is NOT a number
                // - Create a note from the fretText
                // - Reset the fretText
                // - Reset the space count
                // ELSE IF accentText is NOT empty AND
                //      IF c is a number OR a space
                // - Create an accent from the accentText
                // - Reset accentText
                // - Reset the space count
                // ENDIF
                if ((fretText != string.Empty) && (!IsNumber))
                {
                    int.TryParse(fretText, out fretNumber);
                    AddNote(fretNumber, preceedingSpaces);
                    fretText = string.Empty;
                    preceedingSpaces = 0;
                }
                else if ((accentText != string.Empty) && (IsNumber || IsSpace))
                {
                    AddAccent(accentText, preceedingSpaces);
                    accentText = string.Empty;
                    preceedingSpaces = 0;
                }

                // IF c is a space
                // - Increment the space counter
                // ELSE IF c is a number
                // - Record the number for later use
                // ELSE IF c is an accent
                // - Record the accent for later use
                // ENDIF
                if (IsSpace)
                {
                    preceedingSpaces++;
                }
                else if (IsNumber)
                {
                    fretText += c;
                }
                else if (IsAccent)
                {
                    accentText += c;
                }
            }
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Adds a note to the list of items on this line
        /// </summary>
        /// <param name="fret">The fret number to play</param>
        /// <param name="predeedingSpaces">The number of spaces preceeding this note</param>
        public void AddNote(int fret, int preceedingSpaces)
        {
            _items.Add(new Note(fret, preceedingSpaces));
        }

        /// <summary>
        /// Adds an acent to the list of items on this line
        /// </summary>
        /// <param name="accentText">The accent text</param>
        /// <param name="preceedingSpaces">The number of spaces preceeding this accent</param>
        public void AddAccent(string accentText, int preceedingSpaces)
        {
            _items.Add(new Accent(accentText, preceedingSpaces));
        }
        #endregion
    }
}
