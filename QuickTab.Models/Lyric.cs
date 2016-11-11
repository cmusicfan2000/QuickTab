using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickTab.Generics;

namespace QuickTab.Models
{
    public class Lyric : ICompositionLine
    {
        #region [ Properties ]
        private int _lineNumber;
        /// <summary>
        /// The line number on which this lyrics resides
        /// Used to sort lyrics and other ICompositionLines
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

        private string _content;
        /// <summary>
        /// The lyric content
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }
            private set
            {
                if(value != null)
                {
                    _content = value;
                }
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a lyric with the specified line number
        /// </summary>
        /// <param name="lineNumber">The line on which the lyric resides</param>
        /// <param name="lyricContent">The contents of the lyric</param>
        public Lyric(int lineNumber, string lyricContent)
        {
            LineNumber = lineNumber;
            Content = lyricContent;
        }
        #endregion
    }
}
