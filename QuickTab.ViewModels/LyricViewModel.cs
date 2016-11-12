using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickTab.Generics;
using QuickTab.Models;

namespace QuickTab.ViewModels
{
    public class LyricViewModel : ICompositionLine
    {
        #region [ Properties ]
        private Lyric _model;

        /// <summary>
        /// The line number on which this lyrics resides
        /// Used to sort lyrics and other ICompositionLines
        /// </summary>
        public int LineNumber
        {
            get
            {
                return _model.LineNumber;
            }
        }
        
        /// <summary>
        /// The lyric content
        /// </summary>
        public string Content
        {
            get
            {
                return _model.Content;
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Creates a lyric with the specified line number
        /// </summary>
        /// <param name="lineNumber">The line on which the lyric resides</param>
        /// <param name="lyricContent">The contents of the lyric</param>
        public LyricViewModel(int lineNumber, string lyricContent)
        {
            _model = new Lyric(lineNumber, lyricContent);
        }
        #endregion
    }
}
