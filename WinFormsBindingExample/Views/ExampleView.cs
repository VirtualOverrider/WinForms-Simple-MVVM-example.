using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsBindingExample.Models;

namespace WinFormsBindingExample.Views
{
    public partial class ExampleView : UserControl
    {
        #region Private fields
        private ExampleViewModel _model;                                        // Backing store for the Model this View will bind with.
        #endregion

        #region Ctor
        public ExampleView()
        {
            _model = new ExampleViewModel();
            InitializeComponent();

            PerformBinding();
        }

        public ExampleView(ExampleViewModel model)
        {
            _model = model;
            InitializeComponent();

            PerformBinding();
        }

        public void PerformBinding()
        {
            tbName.DataBindings.Add("Text", _model, nameof(_model.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            lblName.DataBindings.Add("Text", _model, nameof(_model.Name), false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

    }
}