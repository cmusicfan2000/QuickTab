namespace QuickTab.Models
{
    public class Chord
    {
        #region [ Properties ]
        private int _lineNumber;
        /// <summary>
        /// The line number on which this chord belongs
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

        private int _linePosition;
        /// <summary>
        /// Used to order chords on the same line
        /// </summary>
        public int LinePosition
        {
            get
            {
                return _linePosition;
            }
            private set
            {
                if(value > 0)
                {
                    _linePosition = value;
                }
            }
        }
        
        private string _name;
        /// <summary>
        /// The name of the chord
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if(value != null)
                {
                    _name = value;
                }
            }
        }

        private int _precedingSpaces;
        /// <summary>
        /// The number of spaces receding this chord
        /// </summary>
        public int PrecedingSpaces
        {
            get
            {
                return _precedingSpaces;
            }
            private set
            {
                if(value >= 0)
                {
                    _precedingSpaces = value;
                }
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a chord based on the given information
        /// </summary>
        /// <param name="name">The name of the chord</param>
        /// <param name="lineNo">The line on which the chord belongs</param>
        /// <param name="position">The position on the line in which the chord belongs</param>
        /// <param name="precedingSpaces">The number of spaces preceding the chord</param>
        public Chord(string name, int lineNo, int position, int precedingSpaces)
        {
            Name = name;
            LineNumber = lineNo;
            LinePosition = position;
            PrecedingSpaces = precedingSpaces;
        }
        #endregion
    }
}
