using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMI
{
    public partial class TimeMenu : VisiWinNET.Forms.BaseForm
    {

        #region Constructor / Dispose

        /// <summary>
        /// Creates and initializes a new instance of the form.
        /// </summary>
        public TimeMenu()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();


            this.Size = new System.Drawing.Size(1024, 768);

            // Add further initialization code here.
            int minutes = Convert.ToUInt16(Convert.ToDouble(VisiWinNET.Services.AppService.VWGet("Ch1.Ergo_PLC.g_stCrank.rCountForFiveMin"))/12000);
            if (minutes <= 1)
            {
                this.TitleLabel.LocalizedText.Text= (minutes.ToString() + " minute");
            }
            else
            {
                this.TitleLabel.LocalizedText.Text = (minutes.ToString() + " minutes");
            }

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


        #region  VisiWinNET.AddIn generated code
        //active=1

        #region Initialization of VisiWinNET controls


        #endregion

        #endregion

    }
}