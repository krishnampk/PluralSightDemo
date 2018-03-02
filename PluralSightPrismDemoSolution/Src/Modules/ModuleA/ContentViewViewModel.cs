using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleA
{
    public class ContentViewViewModel : IContentViewViewModel
    {
        #region IViewModel Members

        public PluralsightPrismDemo.Infrastructure.IView View { get; set; }

        public ContentViewViewModel(IContentView contentView)
        {
            this.View = contentView;
            contentView.ViewModel = this;
        }

        #endregion
    }
}
