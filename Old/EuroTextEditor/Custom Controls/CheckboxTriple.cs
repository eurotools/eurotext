using System;
using System.Windows.Forms;

namespace EuroTextEditor.Classes
{
    internal class CheckboxTriple : CheckBox
    {
        protected override void OnClick(EventArgs e)
        {
            if (AutoCheck)
            {
                switch (CheckState)
                {
                    case CheckState.Checked:
                        if (ThreeState)
                        {
                            CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            CheckState = CheckState.Unchecked;
                        }
                        break;
                    case CheckState.Indeterminate:
                        CheckState = CheckState.Unchecked;
                        break;
                    default:
                        CheckState = CheckState.Checked;
                        break;
                }
            }

            bool oldAutoCheckValue = AutoCheck;
            AutoCheck = false;
            base.OnClick(e);
            AutoCheck = oldAutoCheckValue;
        }
    }
}
