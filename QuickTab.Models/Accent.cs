﻿using QuickTab.Generics;

namespace QuickTab.Models
{
    public class Accent : ITabLineItem
    {
        #region [ Properties ]
        /// <summary>
        /// Used to sort a group of notes on the same line
        /// </summary>
        public int Order { get; private set; }
        
        /// <summary>
        /// The text of the accent
        /// </summary>
        public string Text { get; private set; }

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
                if (value > 0)
                {
                    _preceedingSpaces = value;
                }
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Generic constructor
        /// </summary>
        /// <param name="accentText">The string content of the accent</param>
        /// <param name="order">The order of this accent in relation to other ITabLineItems</param>
        /// <param name="preceedingSpaces">The number of spaces that preceed this accent</param>
        public Accent(string accentText, int order, int preceedingSpaces)
        {
            Order = order;
            Text = accentText;
            PreceedingSpaces = preceedingSpaces;
        }
        #endregion
    }
}
