using System.ComponentModel;
using System.Windows.Forms;
using WinFormsBindingExample.Interfaces;

namespace WinFormsBindingExample.Views
{
    [TypeDescriptionProvider(typeof(AbstractDescriptionProvider<WinFormsBindingExample.Views.ViewBase, System.Windows.Forms.UserControl>))]
    public abstract class ViewBase : UserControl, IView
    {
        // Ensure derived Views implement their method to set bindings between control properties => model properties.
        public abstract void PerformBinding();
    }
}
