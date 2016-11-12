using System.Collections.ObjectModel;
using QuickTab.Generics;

namespace QuickTab.ViewModels
{
    public class CompositionViewModel
    {
        #region [ Properties ]
        private ObservableCollection<ICompositionLine> _lines;
        /// <summary>
        /// A list of lies
        /// </summary>
        public ObservableCollection<ICompositionLine> Lines
        {
            get
            {
                if(_lines == null)
                {
                    _lines = new ObservableCollection<ICompositionLine>();
                }
                return _lines;
            }
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Generates test lyrics for display
        /// </summary>
        public CompositionViewModel()
        {
            Lines.Add(new LyricViewModel(1, "F         C     G             C"));
            Lines.Add(new LyricViewModel(2, "I believe in night, I believe in day"));
            Lines.Add(new LyricViewModel(3, "F             C           G          Am     C"));
            Lines.Add(new LyricViewModel(4, "and I believe there's a light coming back around again"));
            Lines.Add(new LyricViewModel(5, "And I believe you're right cause I believe there's a way"));
            Lines.Add(new LyricViewModel(6, "And is believe is might have some catching up to do"));
        }
        #endregion
    }
}
