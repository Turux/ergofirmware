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
    /// Start up screen of the application. 
    /// Will be displayed as long as the VisiWinNET runtime and the application are initializing.
    /// </summary>
    public partial class FStart : VisiWinNET.Forms.StartForm
    {
        /// <summary>
        /// Creates and initializes a new instance of the class.
        /// </summary>
        public FStart()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
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

        /// <summary>
        /// Is called when the VisiWinNET runtime is initialized.
        /// </summary>
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e"> Provides information for the event.</param>
        protected override void OnInitReady(object sender, VisiWinNET.Project.ProjectManagerEventArgs e)
        {
            base.OnInitReady(sender, e);

            if (e.Success)
            {
                VisiWinNET.Forms.GuiConfiguration.Initialize(System.Reflection.Assembly.GetExecutingAssembly());

                // Add further initialization code here.

                VisiWinNET.Forms.ProjectForms.Load("FCentral");
                VisiWinNET.Forms.ProjectForms.Show("FCentral");
            }
            else
            {
                MessageBox.Show("Project startup failed!", "VisiWinNET Compact");
                Application.Exit();
            }

        }
        
        /// <summary>
        /// Is called when the VisiWinNET runtime is closed.
        /// </summary>
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e"> Provides information for the event.</param>
        protected override void OnProjectShutdownFinished(object sender, EventArgs e)
        {
            base.OnProjectShutdownFinished(sender, e);
            Application.Exit();
        }
    }
}