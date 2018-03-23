using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingExample.Models
{
    public sealed class OtherViewModel : ViewModelBase
    {
        #region Private fields
        private StringBuilder _otherFunText;                // Backing data store for our Name property.
        #endregion

        #region Public Properties
        /// <summary>
        /// Property we will be allowing our Example Form to bind to.
        /// </summary>
        public string OtherFunText
        {
            // Return the string value of our StringBuilder, provide a sample default value if nothing was provided
            get => _otherFunText.ToString() != String.Empty ? _otherFunText.ToString() : "This is the 'Other' View.\r\n\r\nIt just displays text, but it could easily be something more, like a collection of controls or some other cool stuff.";
            set
            {
                // Clear the StringBuilder's buffer, throwing away any previous string value.
                _otherFunText.Clear();

                // Add the new value into the StringBuilder's buffer
                _otherFunText.Append(value);

                // Tell the binding system that this model's property value has changed, and that subscribers should update.
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(OtherFunText)));
            }

        }
        #endregion

        #region Ctor
        /// <summary>
        /// ViewModel responsible for the Example form.
        /// </summary>
        public OtherViewModel()
        {
            // Initialize backing fields
            _otherFunText = new StringBuilder();
        }

        #endregion
    }
}
