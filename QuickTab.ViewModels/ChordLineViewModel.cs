using System.Collections.Generic;
using QuickTab.Generics;
using QuickTab.Models;

namespace QuickTab.ViewModels
{
    /// <summary>
    /// Represents a list of chords which are seperated by specific numbers of spaces
    /// </summary>
    public class ChordLineViewModel : ViewModelBase, ICompositionLine
    {
        #region [ Properties ]
        /// <summary>
        /// The list of chords on this line
        /// </summary>
        private List<ICompositionLineItem> _models = new List<ICompositionLineItem>();

        /// <summary>
        /// The text representing this line of chords
        /// </summary>
        public string Content
        {
            get
            {
                string lineContent = string.Empty;

                foreach (ICompositionLineItem cli in _models)
                {
                    lineContent += cli.Text.PadLeft(cli.Text.Length + cli.PreceedingSpaces, '-');
                }

                return lineContent;
            }
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Adds a new chord to the end of the list of chords
        /// </summary>
        /// <param name="name">The name of the chord</param>
        /// <param name="preceedingSpaces">The number of spaces preceeding the chord</param>
        public void AddChord(string name, int preceedingSpaces)
        {
            _models.Add(new Chord(name, preceedingSpaces));

            NotifyPropertyChanged("Content");
        }
        #endregion
    }
}
