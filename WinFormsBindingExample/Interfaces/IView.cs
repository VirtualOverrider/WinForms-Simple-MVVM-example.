using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingExample.Interfaces
{
    /// <summary>
    /// Interface enforces base requirements of all 'View' types.
    /// </summary>
    public interface IView
    {
        // Should handle Binding operations of the View's control properties to the Model's Properties
        void PerformBinding();
    }
}
