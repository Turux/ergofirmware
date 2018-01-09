namespace HMI
{
    partial class TimeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new VisiWinNET.Forms.Label();
            this.label2 = new VisiWinNET.Forms.Label();
            this.SetGeometryButton = new VisiWinNET.Forms.CommandButton();
            this.SetLoadButton = new VisiWinNET.Forms.CommandButton();
            this.BackButton = new VisiWinNET.Forms.CommandButton();
            this.OpenDashboardButton = new VisiWinNET.Forms.CommandButton();
            this.ClutchButton = new VisiWinNET.Forms.Key();
            this.MotorButton = new VisiWinNET.Forms.Key();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetGeometryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLoadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenDashboardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClutchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.TitleLabel.InternalFont.Name = "Arial";
            this.TitleLabel.InternalFont.Size = 20F;
            this.TitleLabel.LocalizedText.Text = "1 Minute";
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1024, 41);
            this.TitleLabel.VWItem.BitEvents = false;
            this.TitleLabel.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // label2
            // 
            this.label2.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.label2.InternalFont.Name = "Arial";
            this.label2.InternalFont.Size = 18F;
            this.label2.LocalizedText.Text = "T E S T";
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1024, 41);
            this.label2.VWItem.BitEvents = false;
            this.label2.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // SetGeometryButton
            // 
            this.SetGeometryButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.SetGeometryButton.Command.Param = "Geometry";
            this.SetGeometryButton.InternalFont.Name = "Arial";
            this.SetGeometryButton.InternalFont.Size = 14F;
            this.SetGeometryButton.LocalizedText.Text = "Set Geometry";
            this.SetGeometryButton.Location = new System.Drawing.Point(78, 209);
            this.SetGeometryButton.Name = "SetGeometryButton";
            this.SetGeometryButton.Size = new System.Drawing.Size(226, 128);
            this.SetGeometryButton.TabIndex = 3;
            // 
            // SetLoadButton
            // 
            this.SetLoadButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.SetLoadButton.Command.Param = "UserMode";
            this.SetLoadButton.InternalFont.Name = "Arial";
            this.SetLoadButton.InternalFont.Size = 14F;
            this.SetLoadButton.LocalizedText.Text = "Set Loads";
            this.SetLoadButton.Location = new System.Drawing.Point(739, 209);
            this.SetLoadButton.Name = "SetLoadButton";
            this.SetLoadButton.Size = new System.Drawing.Size(226, 128);
            this.SetLoadButton.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ChangeForm;
            this.BackButton.Command.Param = "FCentral";
            this.BackButton.LocalizedText.Text = "Back";
            this.BackButton.Location = new System.Drawing.Point(925, 668);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 48);
            this.BackButton.TabIndex = 5;
            // 
            // OpenDashboardButton
            // 
            this.OpenDashboardButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.OpenDashboardButton.Command.Param = "TimeFrontEnd";
            this.OpenDashboardButton.InternalFont.Name = "Arial";
            this.OpenDashboardButton.InternalFont.Size = 24F;
            this.OpenDashboardButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.OpenDashboardButton.LocalizedText.Text = "OPEN DASHBOARD";
            this.OpenDashboardButton.Location = new System.Drawing.Point(303, 445);
            this.OpenDashboardButton.Name = "OpenDashboardButton";
            this.OpenDashboardButton.Size = new System.Drawing.Size(430, 200);
            this.OpenDashboardButton.TabIndex = 6;
            // 
            // ClutchButton
            // 
            this.ClutchButton.BackColor = System.Drawing.Color.Red;
            this.ClutchButton.BackColorOn = System.Drawing.Color.Lime;
            this.ClutchButton.InternalFont.Name = "Arial";
            this.ClutchButton.InternalFont.Size = 12F;
            this.ClutchButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.ClutchButton.LocalizedText.Text = "Clutch ON";
            this.ClutchButton.LocalizedText.TextOn = "Clutch OFF";
            this.ClutchButton.Location = new System.Drawing.Point(303, 356);
            this.ClutchButton.Name = "ClutchButton";
            this.ClutchButton.Size = new System.Drawing.Size(182, 72);
            this.ClutchButton.TabIndex = 9;
            this.ClutchButton.VWItem.Name = "Ch1.Ergo_PLC.g_stCrank.bEnableClutchTorque";
            this.ClutchButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stCrank.bEnableClutchTorque";
            // 
            // MotorButton
            // 
            this.MotorButton.BackColor = System.Drawing.Color.Red;
            this.MotorButton.BackColorOn = System.Drawing.Color.Lime;
            this.MotorButton.InternalFont.Name = "Arial";
            this.MotorButton.InternalFont.Size = 12F;
            this.MotorButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.MotorButton.LocalizedText.Text = "Motor ON";
            this.MotorButton.LocalizedText.TextOn = "Motor OFF";
            this.MotorButton.Location = new System.Drawing.Point(551, 356);
            this.MotorButton.Name = "MotorButton";
            this.MotorButton.Size = new System.Drawing.Size(182, 72);
            this.MotorButton.TabIndex = 10;
            this.MotorButton.VWItem.Name = "Ch1.Ergo_PLC.g_stCrank.bTorqueEnabled";
            this.MotorButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stCrank.bTorqueEnabled";
            // 
            // TimeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MotorButton);
            this.Controls.Add(this.ClutchButton);
            this.Controls.Add(this.OpenDashboardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SetLoadButton);
            this.Controls.Add(this.SetGeometryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeMenu";
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetGeometryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetLoadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenDashboardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClutchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public VisiWinNET.Forms.Label TitleLabel;
        private VisiWinNET.Forms.Label label2;
        private VisiWinNET.Forms.CommandButton SetGeometryButton;
        private VisiWinNET.Forms.CommandButton SetLoadButton;
        private VisiWinNET.Forms.CommandButton BackButton;
        private VisiWinNET.Forms.CommandButton OpenDashboardButton;
        private VisiWinNET.Forms.Key ClutchButton;
        private VisiWinNET.Forms.Key MotorButton;

    }
}