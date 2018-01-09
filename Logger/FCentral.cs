using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMI
{
    /// <summary>
    /// Central form of the application.
    /// </summary>
    public partial class FCentral : VisiWinNET.Forms.BaseForm
    {

        /// <summary>
        /// Creates and initializes a new instance of the class.
        /// </summary>
        public FCentral()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 0);
            
            // Add further initialization code here.
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
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void Time1MinButton_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin", 12001);
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 0);
            
        }

        private void Time5MinButton_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin", (12001*5));
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 0);
        }

        private void Time20MinButton_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin", (12001 * 20));
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 0);
        }

        private void Time3MinButton_Click(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin", (12001 * 3));
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 0);
        }

        private void Geometry3MinButton_Click_1(object sender, EventArgs e)
        {
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin", (12001 * 3));
            VisiWinNET.Services.AppService.VWSet("Ch1.Ergo_PLC.g_stUIData.xGeometryTest", 1);
        }

       

    }
}