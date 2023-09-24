using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Elevator : Form
    {
        DataAdapter database = new DataAdapter();
        Door d = new Door();
        UpDown ud = new UpDown();
        Auto a = new Auto();
        public Elevator()
        {
            InitializeComponent();

        }


        //declaring variable
        int y_up = 54;
        int y_down = 284;


        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            Fbutton.Enabled = false;
            Sbutton.Enabled = false;
            buttonS.Enabled = false;
            buttonopen.Enabled = false;
            buttonclose.Enabled = false;
            moveuptimer.Enabled = true;
            timeauto.Stop();
            Indisplay.Image = Lift.Properties.Resources.going_up;
            updisplay.Image = Lift.Properties.Resources.going_up;
            downdisplay.Image = Lift.Properties.Resources.going_up;
        }

        private void upOpenTimer_Tick_1(object sender, EventArgs e)
        {
            d.UpOpen(leftup, rightup, upOpenTimer, timeauto, Fbutton, Sbutton, buttonS, buttonF);
        }

        private void buttong_Click_1(object sender, EventArgs e)
        {
            buttonS.Enabled = false;
            Fbutton.Enabled = false;
            Sbutton.Enabled = false;
            buttonF.Enabled = false;
            buttonopen.Enabled = false;
            buttonclose.Enabled = false;
            movedowntimer.Enabled = true;
            Indisplay.Image = Lift.Properties.Resources.going_down;
            updisplay.Image = Lift.Properties.Resources.going_down;
            downdisplay.Image = Lift.Properties.Resources.going_down;
        }

        private void buttoni1_Click_1(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            Fbutton.Enabled = false;
            buttonS.Enabled = false;
            Sbutton.Enabled = false;
            buttonopen.Enabled = false;
            buttonclose.Enabled = false;
            downclosetimer.Start();
            moveuptimer.Start();
            Indisplay.Image = Lift.Properties.Resources.going_up;
            updisplay.Image = Lift.Properties.Resources.going_up;
            downdisplay.Image = Lift.Properties.Resources.going_up;
        }

        private void moveuptimer_Tick_1(object sender, EventArgs e)
        {
            ud.MoveUp(inside, moveuptimer, upOpenTimer, Indisplay, updisplay, downdisplay, y_up, buttonopen, buttonclose);
        }

        private void buttonig_Click_1(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            buttonS.Enabled = false;
            Sbutton.Enabled = false;
            Fbutton.Enabled = false;
            buttonopen.Enabled = false;
            buttonclose.Enabled = false;
            upclosetimer.Start();
            movedowntimer.Start();
            timeauto.Stop();
            Indisplay.Image = Lift.Properties.Resources.going_down;
            updisplay.Image = Lift.Properties.Resources.going_down;
            downdisplay.Image = Lift.Properties.Resources.going_down;
        }

        private void movedowntimer_Tick_1(object sender, EventArgs e)
        {
            ud.MoveDown(inside, movedowntimer, downOpenTimer, Indisplay, updisplay, downdisplay, y_down, buttonopen, buttonclose);
        }

        private void downOpenTimer_Tick_1(object sender, EventArgs e)
        {
            d.DownOpen(leftdown, rightdown, downOpenTimer, timeauto, Fbutton, Sbutton, buttonS, buttonF);
        }

        private void downclosetimer_Tick_1(object sender, EventArgs e)
        {
            d.DownClose(leftdown, rightdown, downclosetimer, moveuptimer, Sbutton);
        }

        private void upclosetimer_Tick_1(object sender, EventArgs e)
        {
            d.UpClose(leftup, rightup, upclosetimer, movedowntimer, Fbutton);
        }

        private void timerauto_Tick_1(object sender, EventArgs e)
        {
            a.Time(inside, timerautodown, timerautoup, buttonS, buttonF, Sbutton, Fbutton, y_up, y_down);
        }

        private void timerautoup_Tick(object sender, EventArgs e)
        {
          a.TimeUp(leftup, rightup, timerautoup, timeauto, buttonF, buttonS, Fbutton);
        }

        private void timerautodown_Tick(object sender, EventArgs e)
        {
         a.TimeDown(leftdown, rightdown, timerautodown, timeauto, buttonF, buttonS, Sbutton);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Data.Items.Clear();
            DataSet ds = database.View();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Data.Items.Add(row["DateAndTime"].ToString() + "\t\t" + row["Activity".ToString()]);
            }
        }

        private void buttonopen_Click(object sender, EventArgs e)
        {
            if(inside.Top==y_up)
            {
                upOpenTimer.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
            else
            {
                downOpenTimer.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            if (inside.Top == y_up)
            {
                upclosetimer.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
            else
            {
                downclosetimer.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
