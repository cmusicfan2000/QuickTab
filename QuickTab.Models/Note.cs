﻿using QuickTab.Generics;

namespace QuickTab.Models
{
    public class Note : ITabLineItem
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
        /// Used to sort a group of notes on the same line
        /// </summary>
        public int Order { get; private set; }

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
        /// <param name="order">The order of this accent in relation to other ITabLineItems</param>
        /// <param name="preceedingSpaces">The number of spaces which preceed this note</param>
        public Note(int fret, int order, int preceedingSpaces)
        {
            Fret = fret;
            Order = order;
            PreceedingSpaces = preceedingSpaces;
        }
        #endregion
    }
}
