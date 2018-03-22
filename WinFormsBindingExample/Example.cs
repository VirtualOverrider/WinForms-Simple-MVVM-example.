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
        private ExampleView _view;
        private ExampleViewModel _model;
        #endregion

        #region Ctor
        public Example()
        {
            _model = new ExampleViewModel();
            _view = new ExampleView(_model);


            this.Controls.Add(_view);
            InitializeComponent();

            
        }
        #endregion
    }
}
