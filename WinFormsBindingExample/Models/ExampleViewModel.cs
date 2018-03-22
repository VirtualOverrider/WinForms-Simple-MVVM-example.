using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingExample.Models
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        #region Private fields
        private StringBuilder _name;                // Backing data store for our Name property.
        #endregion

        #region Public Properties
        /// <summary>
        /// Property we will be allowing our Example Form to bind to.
        /// </summary>
        public string Name
        {
            // Return the string value of our StringBuilder, provide a sample default value if nothing was provided
            get => _name.ToString() != String.Empty ? _name.ToString() : "Please enter your name";
            set
            {
                // Clear the StringBuilder's buffer, throwing away any previous string value.
                _name.Clear();

                // Add the new value into the StringBuilder's buffer
                _name.Append(value);

                // Tell the binding system that this model's property value has changed, and that subscribers should update.
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Name)));
            }

        }
        #endregion

        #region Ctor
        /// <summary>
        /// ViewModel responsible for the Example form.
        /// </summary>
        public ExampleViewModel()
        {
            // Initialize backing fields
            _name = new StringBuilder();
        }

        #endregion

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
