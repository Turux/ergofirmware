using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMI
{
    public partial class EngineeringMode : VisiWinNET.Forms.BaseForm
    {

        #region Constructor / Dispose

        /// <summary>
        /// Creates and initializes a new instance of the form.
        /// </summary>
        public EngineeringMode()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();


            this.Size = new System.Drawing.Size(1024, 768);

            // Add further initialization code here.
                // Set the Control Mode in Closed Loop and the GUI accordingly
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eMode", 1);
                closedLoopButton.Checked = true;
                // Set the Power Source to Transducer
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eTelemetrySource", 0);
                TransducerIn.Checked = true;
                // Set PID default values
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.rPgain", 1.0);
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.rIgain", 0.5);
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.rDgain", 0.3);
                

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


        private void closedLoopButton_Click(object sender, EventArgs e)
        {
            if (closedLoopButton.Checked)
            {
                openLoopButton.Checked = false;
                constantPowerButton.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eMode", 1);
            }
            else
            {
 
            }
        }

        private void constantPowerButton_Click(object sender, EventArgs e)
        {
            if (constantPowerButton.Checked)
            {
                openLoopButton.Checked = false;
                closedLoopButton.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eMode", 2);
            }
            else
            {

            }
        }

        private void openLoopButton_Click(object sender, EventArgs e)
        {
            if (openLoopButton.Checked)
            {
                closedLoopButton.Checked = false;
                constantPowerButton.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eMode", 0);
            }
            else
            {

            }
        }

        private void TransducerIn_Click(object sender, EventArgs e)
        {
            if (TransducerIn.Checked)
            {
                leftIn.Checked = false;
                rightIn.Checked = false;
                leftplusrightIn.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eTelemetrySource", 0);
            }
            else
            { }
        }

        private void leftplusrightIn_Click(object sender, EventArgs e)
        {
            if (leftplusrightIn.Checked)
            {
                leftIn.Checked = false;
                rightIn.Checked = false;
                TransducerIn.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eTelemetrySource", 3);
            }
            else
            { }
        }

        private void leftIn_Click(object sender, EventArgs e)
        {
            if (leftIn.Checked)
            {
                leftplusrightIn.Checked = false;
                rightIn.Checked = false;
                TransducerIn.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eTelemetrySource", 1);
            }
            else
            { }
        }

        private void rightIn_Click(object sender, EventArgs e)
        {
            if (rightIn.Checked)
            {
                leftplusrightIn.Checked = false;
                leftIn.Checked = false;
                TransducerIn.Checked = false;
                VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrankControl.eTelemetrySource", 2);
            }
            else
            { }
        }

        private void ResetAll_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stMachine.bResetAllAxes", true);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.bResetError", true);
        }

        

       



        #region  VisiWinNET.AddIn generated code
        //active=1

        #region Initialization of VisiWinNET controls


        #endregion

        #endregion

    }
}