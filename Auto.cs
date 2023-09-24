using System;
using System.Windows.Forms;

namespace Lift
{
    class Auto
    {
        DataAdapter database = new DataAdapter();


        public void Time(PictureBox inside, Timer timerautodown, Timer timerautoup, Button buttonS, Button buttonF, Button Sbutton, Button Fbutton, int y_up, int y_down)
        {
            if (inside.Top > y_up)
            {
                timerautodown.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
            else if (inside.Top < y_down)
            {
                timerautoup.Start();
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
            }
        }

        public void TimeUp(PictureBox leftup, PictureBox rightup, Timer timerautoup, Timer timeauto, Button buttonF, Button buttonS, Button Fbutton)
        {
            if (leftup.Left <= 77 && rightup.Left >= 161)
            {
                leftup.Left += 1;
                rightup.Left -= 1;
            }
            else
            {
                timerautoup.Stop();
                timeauto.Stop();
                buttonF.Enabled = true;
                buttonS.Enabled = true;
                Fbutton.Enabled = true;
                database.Install("second floor door closing");
            }
        }

        public void TimeDown(PictureBox leftdown, PictureBox rightdown, Timer timerautodown, Timer timeauto, Button buttonF, Button buttonS, Button Sbutton)
        {
            if (leftdown.Left <= 77 && rightdown.Left >= 161)
            {
                leftdown.Left += 1;
                rightdown.Left -= 1;
            }
            else
            {
                timerautodown.Stop();
                timeauto.Stop();
                buttonS.Enabled = true;
                buttonF.Enabled = true;
                Sbutton.Enabled = true;
                database.Install("First floor door closing");
            }
        }
    }
}

