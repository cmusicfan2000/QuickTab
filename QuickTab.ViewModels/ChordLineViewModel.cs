using System;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Chord> _models;

        private int _lineNumber;
        /// <summary>
        /// The line number on which this line of chords resides
        /// Used to sort chord lines with other ICompositionLines
        /// </summary>
        public int LineNumber
        {
            get
            {
                return _lineNumber;
            }
            private set
            {
                if(value > 0)
                {
                    _lineNumber = value;
                }
            }
        }

        /// <summary>
        /// The lyric content
        /// </summary>
        public string Content
        {
            get
            {
                string lienContent = string.Empty;

                foreach(Chord c in _models)
                {
                    lienContent += c.Name.PadLeft(c.PrecedingSpaces + c.Name.Length);
                }


                return lienContent;
            }
        }        
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a chord line with the specified line number
        /// </summary>
        /// <param name="lineNumber">The line on which the chords reside</param>
        public ChordLineViewModel(int lineNumber)
        {
            LineNumber = LineNumber;
            _models = new ObservableCollection<Chord>();
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Creates a new chord model and adds it to the collection
        /// </summary>
        /// <param name="name"></param>
        /// <param name="position"></param>
        /// <param name="precedingSpaces"></param>
        public void AddChord(string name, int position, int precedingSpaces)
        {
            _models.Add(new Chord(name, LineNumber, position, precedingSpaces));

            NotifyPropertyChanged("Content");
        }
        #endregion
    }
}
