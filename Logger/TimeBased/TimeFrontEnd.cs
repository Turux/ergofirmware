using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HMI
{
    public partial class TimeFrontEnd : VisiWinNET.Forms.BaseForm
    {

        int trialID;
        int totalTime_ms;
        int timeLeft_ms;
        int minutes;
        int totalIterations;
        int completedInterations;
        double barX;
        double barY;
        double saddleX;
        double saddleY;
        double barXmore;
        double barXless;
        double barYmore;
        double barYless;
        bool hide;

        //bool recording = false;

        private void InitializeFileName()
        {
            this.trialID = 1;
        }

        private void UpdateFileName()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string plcLocalFileName = this.trialID.ToString() + "_" + DateTime.Now.ToString("HH-mm-ss") + ".txt";
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.sUserFileName", Path.Combine(path, plcLocalFileName));
            this.trialID = this.trialID+1;
        }

        private void ClearDistance()
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.iDistance", 0);
            
        }

        private void ResetTimer()
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rTimerCount", 0);
            this.timeLeft_ms = this.totalTime_ms;
            this.TimeLeftOut.VWItem.Value = this.minutes.ToString() + ":00";
        }

        private void UpdateTitle()
        {
            if (this.minutes <= 1)
            {
                this.TestTitle.LocalizedText.Text = (minutes.ToString() + " minute");
            }
            else
            {
                this.TestTitle.LocalizedText.Text = (minutes.ToString() + " minutes");
            }
        }

        private void GetInitialPosition()
        {
            this.barX = Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stBars_X.rActualPosition"));
            this.barY = Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stBars_Y.rActualPosition"));
            this.saddleX = Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stSaddle_X.rActualPosition"));
            this.saddleY = Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stSaddle_Y.rActualPosition"));
            double barXincrement = (this.barX / 100) * 10;
            double barYincrement = (this.barY / 100) * 10;
            this.barXmore = this.barX + barXincrement;
            this.barXless = this.barX - barXincrement;
            this.barYmore = this.barY + barYincrement;
            this.barYless = this.barY - barYincrement;
        }

        private void InitializeTime()
        {
            this.minutes = Convert.ToUInt16(Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin")) / 12000);
            this.totalIterations = Convert.ToUInt16(Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin")));
            if (Convert.ToBoolean(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.bEnableRecording")))
            {
            }
            else
            {
                this.TimeLeftOut.VWItem.Value = this.minutes.ToString() + ":00";
            }
        }

        private void EnableGeometry()
        {
            if (Convert.ToBoolean(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest")))
            {
                this.GeometryBox.Visible = true;
            }
        }
        

        #region Constructor / Dispose

        /// <summary>
        /// Creates and initializes a new instance of the form.
        /// </summary>
        public TimeFrontEnd()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();


            this.Size = new System.Drawing.Size(1024, 768);

            // Add further initialization code here.
            this.InitializeTime();
            this.UpdateTitle();
            this.InitializeFileName();
            this.ClearDistance();
            this.EnableGeometry();
            this.GetInitialPosition();
            this.hide = false;

        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"> true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();

            }
            base.Dispose(disposing);
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.bEnableRecording")))
            {
                this.completedInterations = Convert.ToUInt16(Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.rTimerCount")));
                this.timeLeft_ms = (this.totalIterations - this.completedInterations) * 5;
                //this.timeLeft_ms = this.timeLeft_ms - this.Tick.Interval;
                int timeLeft_min = (timeLeft_ms / 1000) / 60;
                int timeLeft_sec = (timeLeft_ms / 1000) - (timeLeft_min * 60);
                string timeoutput = timeLeft_min.ToString() + ":" + timeLeft_sec.ToString();
                this.TimeLeftOut.VWItem.Value = timeoutput;
            }
        }

        private void RecordLED_Change(object sender, VisiWinNET.DataAccess.StateChangeEventArgs e)
        {
            if (Convert.ToBoolean(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.bEnableRecording")))
            {
                this.UpdateFileName();
            }
            this.ClearDistance();
            this.ResetTimer();
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            if (this.hide)
            {
                this.CadenceOut.Visible = true;
                this.PowerOut.Visible = true;
                this.DistanceOut.Visible = true;
                this.SpeedOut.Visible = true;
                this.hide = false;
                this.DisableButton.LocalizedText.Text = "Hide All";
            }
            else
            {
                this.CadenceOut.Visible = false;
                this.PowerOut.Visible = false;
                this.DistanceOut.Visible = false;
                this.SpeedOut.Visible = false;
                this.hide = true;
                this.DisableButton.LocalizedText.Text = "Show All";
            }
        }

        private void Pos5Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barX);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barY);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos4Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barY);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos6Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barY);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos2Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barX);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos8Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barX);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos3Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos7Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos9Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }

        private void Pos1Button_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_X.rTargetPosition", this.barXless);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition", this.barYmore);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 1);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes", 0);
        }





        #region  VisiWinNET.AddIn generated code
        //active=1

        #region Initialization of VisiWinNET controls


        #endregion

        #endregion

    }
}