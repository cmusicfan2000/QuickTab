using QuickTab.Generics;

namespace QuickTab.Models
{
    public class Chord : ICompositionLineItem
    {
        #region [ Properties ]
        private string _text;
        /// <summary>
        /// The name of the chord
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            private set
            {
                if(value != null)
                {
                    _text = value;
                }
            }
        }

        private int _preceedingSpaces;
        /// <summary>
        /// The number of spaces preceding this chord
        /// </summary>
        public int PreceedingSpaces
        {
            get
            {
                return _preceedingSpaces;
            }
            private set
            {
                if(value >= 0)
                {
                    _preceedingSpaces = value;
                }
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a chord based on the given information
        /// </summary>
        /// <param name="name">The name of the chord</param>
        /// <param name="precedingSpaces">The number of spaces preceding the chord</param>
        public Chord(string name, int precedingSpaces)
        {
            Text = name;
            PreceedingSpaces = precedingSpaces;
        }
        #endregion
    }
}
