using System.Collections.Generic;
using QuickTab.Generics;

namespace QuickTab.ViewModels
{
    /// <summary>
    /// Represents instrument Tabliture
    /// </summary>
    public class TabViewModel : ViewModelBase, ICompositionLine
    {
        #region [ Properties ]
        /// <summary>
        /// A list of lines of tabliture
        /// </summary>
        private List<TabLineViewModel> _models = new List<TabLineViewModel>();

        /// <summary>
        /// The tab in the form of a string
        /// </summary>
        public string Content
        {
            get
            {
                string tabContent = string.Empty;
                foreach (TabLineViewModel tl in _models)
                {
                    tabContent += tl.Content + "\n";
                }
                return tabContent;
            }
        }
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Add a line of tabliture to this tab
        /// </summary>
        /// <param name="lineContent">The content of the tab line</param>
        public void AddLineOfTabliture(string lineContent)
        {
            _models.Add(new TabLineViewModel(lineContent));

            NotifyPropertyChanged("Content");
        }
        #endregion
    }
}