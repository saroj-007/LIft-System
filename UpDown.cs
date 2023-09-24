using System;
using System.Windows.Forms;

namespace Lift
{
    class UpDown
    {
        DataAdapter database = new DataAdapter();


        public void MoveUp(PictureBox inside, Timer moveuptimer, Timer upOpenTimer, PictureBox Indisplay, PictureBox updisplay, PictureBox downdisplay, int y_up, Button buttonopen, Button buttonclose)
        {

            if (inside.Top > y_up)
            {
                inside.Top -= 1;
            }
            else
            {
                moveuptimer.Enabled = false;
                buttonopen.Enabled = true;
                buttonclose.Enabled = true;
                upOpenTimer.Start();
                Indisplay.Image = Lift.Properties.Resources._1;
                updisplay.Image = Lift.Properties.Resources._1;
                downdisplay.Image = Lift.Properties.Resources._1;
                database.Install("Elevator shaft is moving upward");
            }
        }

        public void MoveDown(PictureBox inside, Timer movedowntimer, Timer downOpenTimer, PictureBox Indisplay, PictureBox updisplay, PictureBox downdisplay, int y_down, Button buttonopen, Button buttonclose)
        {
            if (inside.Top < y_down)
            {
                inside.Top += 1;
            }
            else if (inside.Top == y_down)
            {
                movedowntimer.Enabled = false;
                buttonopen.Enabled = true;
                buttonclose.Enabled = true;
                downOpenTimer.Start();
                Indisplay.Image = Lift.Properties.Resources._0;
               updisplay.Image = Lift.Properties.Resources._0;
               downdisplay.Image = Lift.Properties.Resources._0;
                database.Install("Elevator shaft is moving downward");
            }
        }
    }
}
