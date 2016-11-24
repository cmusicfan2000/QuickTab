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
            ChordLineViewModel chordLineOne = new ChordLineViewModel();
            chordLineOne.AddChord("F", 0);
            chordLineOne.AddChord("C", 10);
            chordLineOne.AddChord("G", 5);
            chordLineOne.AddChord("C", 14);

            ChordLineViewModel chordLineTwo = new ChordLineViewModel();
            chordLineTwo.AddChord("F", 0);
            chordLineTwo.AddChord("C", 10);
            chordLineTwo.AddChord("G", 12);
            chordLineTwo.AddChord("Am", 9);
            chordLineTwo.AddChord("C", 5);

            TabViewModel testTab = new TabViewModel();
            testTab.AddLineOfTabliture("e--------------------------------------");
            testTab.AddLineOfTabliture("B---3---3---3---3---3-----3---5-5p3----");
            testTab.AddLineOfTabliture("G-----2-------2-------2h4---2-------2--");
            testTab.AddLineOfTabliture("D-0-------4-------5--------------------");
            testTab.AddLineOfTabliture("A--------------------------------------");
            testTab.AddLineOfTabliture("E--------------------------------------");

            Lines.Add(chordLineOne);
            Lines.Add(new LyricViewModel(" I believe in night, I believe in day"));
            Lines.Add(chordLineTwo);
            Lines.Add(new LyricViewModel(" and I believe there's a light coming back around again"));
            Lines.Add(new LyricViewModel(" And I believe you're right cause I believe there's a way"));
            Lines.Add(new LyricViewModel(" And is believe is might have some catching up to do"));
            Lines.Add(testTab);
        }
        #endregion
    }
}
