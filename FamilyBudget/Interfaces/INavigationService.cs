using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FamilyBudget.ApplicationCore.Interfaces
{
    public interface INavigationService
    {
        public void ClickFamilyButton(Form parentForm, Control container = null);
    }
}
