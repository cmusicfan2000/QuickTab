using System;
using System.Collections.Generic;
using QuickTab.Models;
using QuickTab.Generics;

namespace QuickTab.ViewModels
{
    /// <summary>
    /// Represents instrument Tabliture
    /// </summary>
    public class TabViewModel : ViewModelBase, ICompositionLine
    {
        #region [ Properties ]
        /// <summary>
        /// A list of lines of tabliture
        /// </summary>
        private List<TabLine> _models = new List<TabLine>();

        /// <summary>
        /// The tab in the form of a string
        /// </summary>
        public string Content
        {
            get
            {
                string tabContent = string.Empty;
                foreach(TabLine tl in _models)
                {
                    tabContent += tl.Content + "\n";
                }
                return tabContent;
            }
        }

        /// <summary>
        /// Used to sort this tab with other tabs in the composition
        /// </summary>
        public int LineNumber { get; private set; }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates an empty tab at the given line number
        /// </summary>
        /// <param name="lineNumber">Orders this tab with other composition items</param>
        public TabViewModel(int lineNumber)
        {
            LineNumber = LineNumber;
        }
        #endregion
        
        #region [ Methods ]
        /// <summary>
        /// Add a line of tabliture to this tab
        /// </summary>
        /// <param name="lineContent">The content of the tab line</param>
        public void AddLineOfTabliture(string lineContent)
        {
            int fretNumber;
            int preceedingSpaces = 0;
            int noteCount = 0;
            string fret = string.Empty;
            TabLine newLine = new TabLine(_models.Count + 1);

            foreach(char c in lineContent)
            {
                // IF this character is a space character
                // - Process preceeding notes if applicable
                // - Increment the number of preceeding spaces for the next note
                // ELSE IF this character is a number
                // - add the number to the fret string (this handles frets > 9)
                // ENDIF
                if(c == '-')
                {
                    // IF a fret has been recorded
                    // - Add a new note to the line for it
                    // ENDIF
                    if(fret != string.Empty)
                    {
                        // Convert the fret into an integer
                        int.TryParse(fret, out fretNumber);

                        // Add the new note to the tab line
                        newLine.AddNote(fretNumber, preceedingSpaces, noteCount++);

                        // Reset the fret number
                        fret = string.Empty;

                        // Reset the number of preceeding spaces
                        preceedingSpaces = 1;
                    }

                    // Increment the number of preceeding spaces
                    preceedingSpaces++;
                }
                else if(char.IsNumber(c))
                {
                    fret += c;
                }
            }

            // Add the line to the models
            _models.Add(newLine);
        }
        #endregion
    }
}
