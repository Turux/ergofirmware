using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMI
{
    public partial class UserMode : VisiWinNET.Forms.BaseForm
    {

        #region Constructor / Dispose

        /// <summary>
        /// Creates and initializes a new instance of the form.
        /// </summary>
        public UserMode()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();


            this.Size = new System.Drawing.Size(1024, 768);

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
                    components.Dispose();

            }
            base.Dispose(disposing);
        }

        #endregion

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }



        #region  VisiWinNET.AddIn generated code
        //active=1

        #region Initialization of VisiWinNET controls


        #endregion

        #endregion

    }
}