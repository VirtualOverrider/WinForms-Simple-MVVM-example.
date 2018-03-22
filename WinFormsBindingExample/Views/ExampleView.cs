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
        private ExampleViewModel _model;                // Local reference to the Model this View will use for Binding operations.
        #endregion

        #region Ctor
        /// <summary>
        /// Construct our ExampleView and create its Model ourselves.
        /// <para>The caller did not pass a ExampleViewModel argument</para>
        /// </summary>
        public ExampleView()
        {
            _model = new ExampleViewModel();
            InitializeComponent();

            PerformBinding();
        }

        /// <summary>
        /// Construct our ExampleView and use Dependancy Injection to use a passed Model.
        /// </summary>
        /// <param name="model">ExampleViewModel to use for Binding</param>
        public ExampleView(ExampleViewModel model)
        {
            _model = model;
            InitializeComponent();

            PerformBinding();
        }
        #endregion

        /// <summary>
        /// Sets up binding for the tbName and lblName controls used in this ExampleView.
        /// <para>You might want to also implement an interface that ensures all of your View types implement PerformBinding() to keep everything predictable.</para>
        /// </summary>
        public void PerformBinding()
        {
            tbName.DataBindings.Add("Text", _model, nameof(_model.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            lblName.DataBindings.Add("Text", _model, nameof(_model.Name), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
