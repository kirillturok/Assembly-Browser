using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assembly_Browser.ViewModel
{
    class ButtonViewModel
    {
        public ButtonCommand ButtonCommand { get; set; }
        public ButtonViewModel()
        {
            ButtonCommand = new ButtonCommand(this);
        }

        public void OnExecute()
        {
            MessageBox.Show("Button is cliicked");
        }
    }
}
