using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementTool.Classes
{
    class Helpers
    {
        public static void HideLabel(Label label, int duration = 2000)
        {
            Timer timer = new Timer();
            timer.Interval = duration;

            label.Hide();
        }

        public static void ShowLabel(Label label)
        {
            label.Show();
        }
    }
}
