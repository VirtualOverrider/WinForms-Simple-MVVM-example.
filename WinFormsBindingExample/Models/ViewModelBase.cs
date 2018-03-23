using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsBindingExample.Interfaces;

namespace WinFormsBindingExample.Models
{
    /// <summary>
    /// Base/Parent of all ViewModel type classes.
    /// </summary>
    public abstract class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies listeners of a change to the supplied proerty
        /// </summary>
        /// <param name="e">Arguments of the raised event</param>
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        #endregion
    }
}
