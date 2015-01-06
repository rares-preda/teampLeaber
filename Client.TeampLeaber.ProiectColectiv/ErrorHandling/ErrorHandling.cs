using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv.ErrorHandling
{
    public class ErrorHandling
    {
        private static ErrorHandling instance;
        public static ErrorHandling Instance
        {
            get
            {
                if (instance == null)
                    instance = new ErrorHandling();
                return instance;
            }
        }

        private ErrorHandling()
        {

        }

        public void HandleErrors(List<string> errors)
        {
            string message = string.Join("\n", errors.ToArray());
            MessageBox.Show(message);
        }

        public void HandleError(string error)
        {
            MessageBox.Show(error);
        }
    }
}
