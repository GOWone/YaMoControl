using System.Windows.Input;
using YaMoControlDesign.Interactivity;

namespace YaMoControlDesign.Controls
{

    public class TextBox : System.Windows.Controls.TextBox
    {
        public TextBox()
        {
            CommandBindings.Add(new CommandBinding(ControlCommands.Clear, (s, e) =>
            {
                if (IsReadOnly)
                {
                    return;
                }

                SetCurrentValue(TextProperty, string.Empty);
            }));
        }
    }
}