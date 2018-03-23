using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsBindingExample.Models;
using WinFormsBindingExample.Views;

namespace WinFormsBindingExample
{
    public partial class Example : Form
    {
        #region Private Fields
        private ViewBase _view;          // Field used to store our View
        private ViewModelBase _model;    // Field used to store our ViewModel
        #endregion

        #region Private Methods
        /// <summary>
        /// Change the View this form is displaying.
        /// </summary>
        /// <param name="view">View type to display.</param>
        private void SwapView(ViewBase view = null)
        {
            // Check the passed View is a real object.
            if (view != null)
            {
                // Remove the current View from the Form's control collection, as its going to be swapped for the new View.
                this.Controls.Remove(_view);

                // Is the View an ExampleView
                if (view is ExampleView)
                {
                    _model = new ExampleViewModel();
                    _view = new ExampleView(_model as ExampleViewModel);
                }

                // If the View an OtherView
                if (view is OtherView)
                {
                    _model = new OtherViewModel();
                    _view = new OtherView(_model as OtherViewModel);
                }
            }
            else
            {
                // Todo: Perhaps implement some error handling here too, as well as just displaying an ExampleView as default?
                _model = new ExampleViewModel();
                _view = new ExampleView(_model as ExampleViewModel);
            }

            this.Controls.Add(_view);

        }
        #endregion

        #region Ctor
        public Example(ViewBase view = null)
        {
            // Load the View for this Form's initial state.
            SwapView(new ExampleView());

            InitializeComponent();
        }


        #endregion

        /// <summary>
        /// Event Handler for the 'Load ExampleView' Button.
        /// </summary>
        private void btnLoadExampleView_Click(object sender, EventArgs e)
        {
            SwapView(new ExampleView());
        }

        private void btnLoadOtherView_Click(object sender, EventArgs e)
        {
            SwapView(new OtherView());
        }
    }
}
