using System;
using System.Windows.Forms;

namespace Lift
{
    class Door
    {
        DataAdapter database = new DataAdapter();

        public void DownClose(PictureBox leftdown, PictureBox rightdown, Timer downclosetimer, Timer moveuptimer, Button Sbutton)
        {

            if (leftdown.Left <= 77 && rightdown.Left >= 161)
            {
                leftdown.Left += 1;
                rightdown.Left -= 1;
            }
            else
            {
                downclosetimer.Stop();
                Sbutton.Enabled = true;
                database.Install("Ground floor door closing");
            }
        }

        public void UpClose(PictureBox leftup, PictureBox rightup, Timer upclosetimer, Timer movedowntimer, Button Fbutton)
        {
            if (leftup.Left <= 77 && rightup.Left >= 161)
            {
                leftup.Left += 1;
                rightup.Left -= 1;
            }
            else
            {
                upclosetimer.Stop();
                Fbutton.Enabled = true;
                database.Install("first floor door closing");
            }
        }

        public void UpOpen(PictureBox leftup, PictureBox rightup, Timer upOpenTimer, Timer timeauto, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (leftup.Left >= 3 && rightup.Left <= 230)
            {
                leftup.Left -= 1;
                rightup.Left += 1;
            }
            else
            {
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                upOpenTimer.Stop();
                timeauto.Start();
                database.Install("first floor door opening");
            }
        }

        public void DownOpen(PictureBox leftdown, PictureBox rightdown, Timer downOpenTimer, Timer timeauto, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (leftdown.Left >= 3 && rightdown.Left <= 230)
            {
                leftdown.Left -= 1;
                rightdown.Left += 1;
            }
            else
            {
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                downOpenTimer.Stop();
                timeauto.Start();
                database.Install("Ground floor door opening");
            }
        }
    }
}
