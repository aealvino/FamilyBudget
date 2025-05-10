using System;
using System.Windows.Forms;
using Serilog;

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
                HandleGlobalException(ex);
            }
        }
        public static void HandleGlobalException(Exception ex)
        {
            Log.Error(ex, "Глобальная ошибка");
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
