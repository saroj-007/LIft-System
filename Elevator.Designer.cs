namespace Lift
{
    partial class Elevator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator));
            this.Data = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.moveuptimer = new System.Windows.Forms.Timer(this.components);
            this.movedowntimer = new System.Windows.Forms.Timer(this.components);
            this.upOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.downOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.downclosetimer = new System.Windows.Forms.Timer(this.components);
            this.upclosetimer = new System.Windows.Forms.Timer(this.components);
            this.timeauto = new System.Windows.Forms.Timer(this.components);
            this.timerautoup = new System.Windows.Forms.Timer(this.components);
            this.timerautodown = new System.Windows.Forms.Timer(this.components);
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonopen = new System.Windows.Forms.Button();
            this.Indisplay = new System.Windows.Forms.PictureBox();
            this.downdisplay = new System.Windows.Forms.PictureBox();
            this.updisplay = new System.Windows.Forms.PictureBox();
            this.Fbutton = new System.Windows.Forms.Button();
            this.Sbutton = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightup = new System.Windows.Forms.PictureBox();
            this.leftup = new System.Windows.Forms.PictureBox();
            this.leftdown = new System.Windows.Forms.PictureBox();
            this.rightdown = new System.Windows.Forms.PictureBox();
            this.inside = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Indisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.FormattingEnabled = true;
            this.Data.Items.AddRange(new object[] {
            "Data"});
            this.Data.Location = new System.Drawing.Point(537, 44);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(319, 472);
            this.Data.TabIndex = 19;
            // 
            // btnLoad
            // 
            this.btnView.Location = new System.Drawing.Point(267, 14);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(44, 20);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "Load";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // moveuptimer
            // 
            this.moveuptimer.Interval = 5;
            this.moveuptimer.Tick += new System.EventHandler(this.moveuptimer_Tick_1);
            // 
            // movedowntimer
            // 
            this.movedowntimer.Interval = 5;
            this.movedowntimer.Tick += new System.EventHandler(this.movedowntimer_Tick_1);
            // 
            // upOpenTimer
            // 
            this.upOpenTimer.Interval = 25;
            this.upOpenTimer.Tick += new System.EventHandler(this.upOpenTimer_Tick_1);
            // 
            // downOpenTimer
            // 
            this.downOpenTimer.Interval = 25;
            this.downOpenTimer.Tick += new System.EventHandler(this.downOpenTimer_Tick_1);
            // 
            // downclosetimer
            // 
            this.downclosetimer.Interval = 25;
            this.downclosetimer.Tick += new System.EventHandler(this.downclosetimer_Tick_1);
            // 
            // upclosetimer
            // 
            this.upclosetimer.Interval = 25;
            this.upclosetimer.Tick += new System.EventHandler(this.upclosetimer_Tick_1);
            // 
            // timeauto
            // 
            this.timeauto.Interval = 5000;
            this.timeauto.Tick += new System.EventHandler(this.timerauto_Tick_1);
            // 
            // timerautoup
            // 
            this.timerautoup.Interval = 25;
            this.timerautoup.Tick += new System.EventHandler(this.timerautoup_Tick);
            // 
            // timerautodown
            // 
            this.timerautodown.Interval = 25;
            this.timerautodown.Tick += new System.EventHandler(this.timerautodown_Tick);
            // 
            // buttonclose
            // 
            this.buttonclose.BackgroundImage = global::Lift.Properties.Resources.close;
            this.buttonclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonclose.Location = new System.Drawing.Point(75, 20);
            this.buttonclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(48, 46);
            this.buttonclose.TabIndex = 27;
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonopen
            // 
            this.buttonopen.BackgroundImage = global::Lift.Properties.Resources.open1;
            this.buttonopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonopen.Location = new System.Drawing.Point(14, 20);
            this.buttonopen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(48, 46);
            this.buttonopen.TabIndex = 26;
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // Indisplay
            // 
            this.Indisplay.BackColor = System.Drawing.Color.DarkRed;
            this.Indisplay.Image = global::Lift.Properties.Resources._1;
            this.Indisplay.Location = new System.Drawing.Point(139, 20);
            this.Indisplay.Name = "Indisplay";
            this.Indisplay.Size = new System.Drawing.Size(78, 99);
            this.Indisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Indisplay.TabIndex = 25;
            this.Indisplay.TabStop = false;
            // 
            // downdisplay
            // 
            this.downdisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downdisplay.Image = global::Lift.Properties.Resources._1;
            this.downdisplay.Location = new System.Drawing.Point(126, 242);
            this.downdisplay.Name = "downdisplay";
            this.downdisplay.Size = new System.Drawing.Size(64, 31);
            this.downdisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downdisplay.TabIndex = 24;
            this.downdisplay.TabStop = false;
            // 
            // updisplay
            // 
            this.updisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updisplay.Image = global::Lift.Properties.Resources._1;
            this.updisplay.Location = new System.Drawing.Point(126, 14);
            this.updisplay.Name = "updisplay";
            this.updisplay.Size = new System.Drawing.Size(64, 31);
            this.updisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updisplay.TabIndex = 23;
            this.updisplay.TabStop = false;
            // 
            // Fbutton
            // 
            this.Fbutton.BackgroundImage = global::Lift.Properties.Resources.second_floor_button;
            this.Fbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fbutton.Location = new System.Drawing.Point(12, 70);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(51, 49);
            this.Fbutton.TabIndex = 18;
            this.Fbutton.UseVisualStyleBackColor = true;
            this.Fbutton.Click += new System.EventHandler(this.buttonig_Click_1);
            // 
            // Sbutton
            // 
            this.Sbutton.BackgroundImage = global::Lift.Properties.Resources.first_floor_button;
            this.Sbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sbutton.Location = new System.Drawing.Point(72, 71);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(51, 49);
            this.Sbutton.TabIndex = 17;
            this.Sbutton.UseVisualStyleBackColor = true;
            this.Sbutton.Click += new System.EventHandler(this.buttoni1_Click_1);
            // 
            // buttonF
            // 
            this.buttonF.BackgroundImage = global::Lift.Properties.Resources.upside_down;
            this.buttonF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonF.Location = new System.Drawing.Point(12, 328);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(51, 48);
            this.buttonF.TabIndex = 11;
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttong_Click_1);
            // 
            // buttonS
            // 
            this.buttonS.BackgroundImage = global::Lift.Properties.Resources.button;
            this.buttonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonS.Location = new System.Drawing.Point(12, 99);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(51, 48);
            this.buttonS.TabIndex = 10;
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(5, 461);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(309, 366);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Lift.Properties.Resources.wall;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(5, -242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 299);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lift.Properties.Resources.wall;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(244, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 522);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-78, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 507);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rightup
            // 
            this.rightup.BackgroundImage = global::Lift.Properties.Resources.right;
            this.rightup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightup.Location = new System.Drawing.Point(160, 54);
            this.rightup.Name = "rightup";
            this.rightup.Size = new System.Drawing.Size(84, 182);
            this.rightup.TabIndex = 13;
            this.rightup.TabStop = false;
            // 
            // leftup
            // 
            this.leftup.BackgroundImage = global::Lift.Properties.Resources.left;
            this.leftup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftup.Location = new System.Drawing.Point(76, 54);
            this.leftup.Name = "leftup";
            this.leftup.Size = new System.Drawing.Size(84, 182);
            this.leftup.TabIndex = 12;
            this.leftup.TabStop = false;
            // 
            // leftdown
            // 
            this.leftdown.BackgroundImage = global::Lift.Properties.Resources.left;
            this.leftdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftdown.Location = new System.Drawing.Point(76, 283);
            this.leftdown.Name = "leftdown";
            this.leftdown.Size = new System.Drawing.Size(84, 182);
            this.leftdown.TabIndex = 14;
            this.leftdown.TabStop = false;
            // 
            // rightdown
            // 
            this.rightdown.BackgroundImage = global::Lift.Properties.Resources.right;
            this.rightdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightdown.Location = new System.Drawing.Point(160, 283);
            this.rightdown.Name = "rightdown";
            this.rightdown.Size = new System.Drawing.Size(84, 182);
            this.rightdown.TabIndex = 15;
            this.rightdown.TabStop = false;
            // 
            // inside
            // 
            this.inside.BackgroundImage = global::Lift.Properties.Resources.open;
            this.inside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inside.Location = new System.Drawing.Point(77, 54);
            this.inside.Name = "inside";
            this.inside.Size = new System.Drawing.Size(166, 182);
            this.inside.TabIndex = 7;
            this.inside.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(5, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(309, 322);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(29, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Time&Date";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(171, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Activity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Location = new System.Drawing.Point(537, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(318, 38);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sbutton);
            this.groupBox2.Controls.Add(this.buttonclose);
            this.groupBox2.Controls.Add(this.buttonopen);
            this.groupBox2.Controls.Add(this.Fbutton);
            this.groupBox2.Controls.Add(this.Indisplay);
            this.groupBox2.Location = new System.Drawing.Point(284, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(228, 136);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lift.Properties.Resources.wall;
            this.ClientSize = new System.Drawing.Size(850, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.downdisplay);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.updisplay);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rightup);
            this.Controls.Add(this.leftup);
            this.Controls.Add(this.leftdown);
            this.Controls.Add(this.rightdown);
            this.Controls.Add(this.inside);
            this.Controls.Add(this.pictureBox4);
            this.MaximizeBox = false;
            this.Name = "Elevator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Indisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox inside;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.PictureBox leftup;
        private System.Windows.Forms.PictureBox rightup;
        private System.Windows.Forms.PictureBox leftdown;
        private System.Windows.Forms.PictureBox rightdown;
        private System.Windows.Forms.Button Sbutton;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.ListBox Data;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Timer moveuptimer;
        private System.Windows.Forms.Timer movedowntimer;
        private System.Windows.Forms.Timer upOpenTimer;
        private System.Windows.Forms.Timer downOpenTimer;
        private System.Windows.Forms.Timer downclosetimer;
        private System.Windows.Forms.Timer upclosetimer;
        private System.Windows.Forms.Timer timeauto;
        private System.Windows.Forms.Timer timerautoup;
        private System.Windows.Forms.Timer timerautodown;
        private System.Windows.Forms.PictureBox updisplay;
        private System.Windows.Forms.PictureBox downdisplay;
        private System.Windows.Forms.PictureBox Indisplay;
        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

