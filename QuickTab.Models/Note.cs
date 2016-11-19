namespace QuickTab.Models
{
    public class Note
    {
        #region [ Properties ]
        private int _fret;
        /// <summary>
        /// The fret number
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

        private int _precedingSpaces;
        /// <summary>
        /// The number of spaces preceding this note
        /// </summary>
        public int PrecedingSpaces
        {
            get
            {
                return _precedingSpaces;
            }
            private set
            {
                if (value >= 0)
                {
                    _precedingSpaces = value;
                }
            }
        }

        /// <summary>
        /// Used to sort a group of notes on the same line
        /// </summary>
        public int LineOrder { get; private set; }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a note with the given fret and order
        /// </summary>
        /// <param name="fret">The fret number to play</param>
        /// <param name="predeedingSpaces">The number of spaces preceeding this note</param>
        /// <param name="order">Used to sort a line of notes in a tab</param>
        public Note(int fret, int predeedingSpaces, int order)
        {
            Fret = fret;
            LineOrder = order;
        }
        #endregion
    }
}
