using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Cafeteria_IS
{
    public class ValidationUtils
    {
        private static string _emptyError = "No se permiten campos vacios";
        private static string _characterError = "Solo se permiten caracteres alfabeticos";

        public static bool TextBoxEmptyValidation(RadTextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, _emptyError);
                return false;
            }

            errorProvider.Clear();
            return true;
        }

        public static bool TextBoxCharactersValidation(RadTextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, _emptyError);
                return false;
            }
            
            if (!textBox.Text.All(char.IsLetter))
            {
                errorProvider.SetError(textBox, _characterError);
                return false;
            }

            errorProvider.SetError(textBox, "");
            return true;
        }
    }
}