using QuickTab.Generics;

namespace QuickTab.Models
{
    public class Note : ICompositionLineItem
    {
        #region [ Properties ]
        private int _fret;
        /// <summary>
        /// The fret to play to make the note
        /// </summary>
        public int Fret
        {
            get
            {
                return _fret;
            }
            private set
            {
                if (value >= 0)
                {
                    _fret = value;
                }
            }
        }

        /// <summary>
        /// This note as text
        /// </summary>
        public string Text
        {
            get
            {
                return Fret.ToString();
            }
        }

        private int _preceedingSpaces;
        /// <summary>
        /// The number of spaces which preceed the note
        /// </summary>
        public int PreceedingSpaces
        {
            get
            {
                return _preceedingSpaces;
            }
            set
            {
                if(value > 0)
                {
                    _preceedingSpaces = value;
                }
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a note with the given fret and order
        /// </summary>
        /// <param name="fret">The fret number to play</param>
        /// <param name="preceedingSpaces">The number of spaces which preceed this note</param>
        public Note(int fret, int preceedingSpaces)
        {
            Fret = fret;
            PreceedingSpaces = preceedingSpaces;
        }
        #endregion
    }
}
