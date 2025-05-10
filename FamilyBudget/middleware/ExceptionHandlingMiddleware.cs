using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.UI.middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly Action _next;

        public ExceptionHandlingMiddleware(Action next)
        {
            _next = next;
        }

        public void Invoke()
        {
            try
            {
                _next();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
