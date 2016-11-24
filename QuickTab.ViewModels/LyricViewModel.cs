using QuickTab.Generics;
using QuickTab.Models;

namespace QuickTab.ViewModels
{
    public class LyricViewModel : ICompositionLine
    {
        #region [ Properties ]
        private Lyric _model;
        
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
        /// <param name="lyricContent">The contents of the lyric</param>
        public LyricViewModel(string lyricContent)
        {
            _model = new Lyric(lyricContent);
        }
        #endregion
    }
}
