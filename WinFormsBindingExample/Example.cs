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
        private ExampleView _view;          // Field used to store our View
        private ExampleViewModel _model;    // Field used to store our ViewModel
        #endregion

        #region Ctor
        public Example()
        {
            // Create a new ViewModel
            _model = new ExampleViewModel();
            
            // Create a new View and inject the ViewModel into it.
            _view = new ExampleView(_model);

            // Add the View UserControl to our Form.
            this.Controls.Add(_view);
            
            InitializeComponent();
        }
        #endregion
    }
}
