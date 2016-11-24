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
        /// <param name="lyricContent">The contents of the lyric</param>
        public Lyric(string lyricContent)
        {
            Content = lyricContent;
        }
        #endregion
    }
}
