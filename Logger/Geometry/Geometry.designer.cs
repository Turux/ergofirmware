namespace HMI
{
    partial class Geometry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geometry));
            this.pictureBox1 = new VisiWinNET.Forms.PictureBox();
            this.HandleUpButton = new VisiWinNET.Forms.Key();
            this.SaddleUpButton = new VisiWinNET.Forms.Key();
            this.HandleDownButton = new VisiWinNET.Forms.Key();
            this.SaddleDownButton = new VisiWinNET.Forms.Key();
            this.commandButton1 = new VisiWinNET.Forms.Key();
            this.commandButton2 = new VisiWinNET.Forms.Key();
            this.commandButton3 = new VisiWinNET.Forms.Key();
            this.commandButton4 = new VisiWinNET.Forms.Key();
            this.HomeAxesButton = new VisiWinNET.Forms.Key();
            this.PositionAxes = new VisiWinNET.Forms.Key();
            this.BarsXIn = new VisiWinNET.Forms.VarIn();
            this.BarsYIn = new VisiWinNET.Forms.VarIn();
            this.SaddleXIn = new VisiWinNET.Forms.VarIn();
            this.SaddleYIn = new VisiWinNET.Forms.VarIn();
            this.SaddleXOut = new VisiWinNET.Forms.VarOut();
            this.SaddleYOut = new VisiWinNET.Forms.VarOut();
            this.BarsXOut = new VisiWinNET.Forms.VarOut();
            this.BarsYOut = new VisiWinNET.Forms.VarOut();
            this.BackButton = new VisiWinNET.Forms.CommandButton();
            this.MessageOut = new VisiWinNET.Forms.VarOut();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandleUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandleDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleDownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeAxesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionAxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsXIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsYIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleXIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleYIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleXOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleYOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsXOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsYOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("pictureBox1.Images")))});
            this.pictureBox1.ImageSizeMode = VisiWinNET.Forms.ImageSizeModes.StretchImage;
            this.pictureBox1.Location = new System.Drawing.Point(261, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.VWItem.BitEvents = false;
            this.pictureBox1.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // HandleUpButton
            // 
            this.HandleUpButton.InternalFont.Name = "Arial";
            this.HandleUpButton.InternalFont.Size = 20F;
            this.HandleUpButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.HandleUpButton.LocalizedText.Text = "U";
            this.HandleUpButton.Location = new System.Drawing.Point(636, 137);
            this.HandleUpButton.Name = "HandleUpButton";
            this.HandleUpButton.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.HandleUpButton.Size = new System.Drawing.Size(47, 47);
            this.HandleUpButton.TabIndex = 1;
            this.HandleUpButton.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_Y.bManualPositive";
            this.HandleUpButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stBars_Y.bManualPositive";
            // 
            // SaddleUpButton
            // 
            this.SaddleUpButton.InternalFont.Name = "Arial";
            this.SaddleUpButton.InternalFont.Size = 20F;
            this.SaddleUpButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.SaddleUpButton.LocalizedText.Text = "U";
            this.SaddleUpButton.Location = new System.Drawing.Point(309, 167);
            this.SaddleUpButton.Name = "SaddleUpButton";
            this.SaddleUpButton.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.SaddleUpButton.Size = new System.Drawing.Size(47, 47);
            this.SaddleUpButton.TabIndex = 2;
            this.SaddleUpButton.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.bManualPositive";
            this.SaddleUpButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.bManualPositive";
            // 
            // HandleDownButton
            // 
            this.HandleDownButton.InternalFont.Name = "Arial";
            this.HandleDownButton.InternalFont.Size = 20F;
            this.HandleDownButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.HandleDownButton.LocalizedText.Text = "D";
            this.HandleDownButton.Location = new System.Drawing.Point(636, 375);
            this.HandleDownButton.Name = "HandleDownButton";
            this.HandleDownButton.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.HandleDownButton.Size = new System.Drawing.Size(47, 47);
            this.HandleDownButton.TabIndex = 3;
            this.HandleDownButton.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_Y.bManualNegative";
            this.HandleDownButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stBars_Y.bManualNegative";
            // 
            // SaddleDownButton
            // 
            this.SaddleDownButton.InternalFont.Name = "Arial";
            this.SaddleDownButton.InternalFont.Size = 20F;
            this.SaddleDownButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.SaddleDownButton.LocalizedText.Text = "D";
            this.SaddleDownButton.Location = new System.Drawing.Point(309, 354);
            this.SaddleDownButton.Name = "SaddleDownButton";
            this.SaddleDownButton.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.SaddleDownButton.Size = new System.Drawing.Size(47, 47);
            this.SaddleDownButton.TabIndex = 4;
            this.SaddleDownButton.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.bManualNegative";
            this.SaddleDownButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.bManualNegative";
            // 
            // commandButton1
            // 
            this.commandButton1.InternalFont.Name = "Arial";
            this.commandButton1.InternalFont.Size = 20F;
            this.commandButton1.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.commandButton1.LocalizedText.Text = "L";
            this.commandButton1.Location = new System.Drawing.Point(585, 264);
            this.commandButton1.Name = "commandButton1";
            this.commandButton1.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.commandButton1.Size = new System.Drawing.Size(47, 47);
            this.commandButton1.TabIndex = 5;
            this.commandButton1.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_X.bManualPositive";
            this.commandButton1.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stBars_X.bManualPositive";
            // 
            // commandButton2
            // 
            this.commandButton2.InternalFont.Name = "Arial";
            this.commandButton2.InternalFont.Size = 20F;
            this.commandButton2.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.commandButton2.LocalizedText.Text = "R";
            this.commandButton2.Location = new System.Drawing.Point(689, 264);
            this.commandButton2.Name = "commandButton2";
            this.commandButton2.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.commandButton2.Size = new System.Drawing.Size(47, 47);
            this.commandButton2.TabIndex = 6;
            this.commandButton2.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_X.bManualNegative";
            this.commandButton2.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stBars_X.bManualNegative";
            // 
            // commandButton3
            // 
            this.commandButton3.InternalFont.Name = "Arial";
            this.commandButton3.InternalFont.Size = 20F;
            this.commandButton3.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.commandButton3.LocalizedText.Text = "L";
            this.commandButton3.Location = new System.Drawing.Point(225, 242);
            this.commandButton3.Name = "commandButton3";
            this.commandButton3.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.commandButton3.Size = new System.Drawing.Size(47, 47);
            this.commandButton3.TabIndex = 7;
            this.commandButton3.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_X.bManualNegative";
            this.commandButton3.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stSaddle_X.bManualNegative";
            // 
            // commandButton4
            // 
            this.commandButton4.InternalFont.Name = "Arial";
            this.commandButton4.InternalFont.Size = 20F;
            this.commandButton4.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.commandButton4.LocalizedText.Text = "R";
            this.commandButton4.Location = new System.Drawing.Point(422, 242);
            this.commandButton4.Name = "commandButton4";
            this.commandButton4.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.commandButton4.Size = new System.Drawing.Size(47, 47);
            this.commandButton4.TabIndex = 8;
            this.commandButton4.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_X.bManualPositive";
            this.commandButton4.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stSaddle_X.bManualPositive";
            // 
            // HomeAxesButton
            // 
            this.HomeAxesButton.LocalizedText.Text = "Home Axes";
            this.HomeAxesButton.Location = new System.Drawing.Point(0, 642);
            this.HomeAxesButton.Name = "HomeAxesButton";
            this.HomeAxesButton.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.HomeAxesButton.Size = new System.Drawing.Size(146, 48);
            this.HomeAxesButton.TabIndex = 10;
            this.HomeAxesButton.VWItem.Name = "Ch1.Ergo_PLC.g_stMachine.bDatumAllAxes";
            this.HomeAxesButton.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stMachine.bDatumAllAxes";
            // 
            // PositionAxes
            // 
            this.PositionAxes.InternalFont.Name = "Arial";
            this.PositionAxes.InternalFont.Size = 12F;
            this.PositionAxes.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.PositionAxes.LocalizedText.Text = ">>>";
            this.PositionAxes.Location = new System.Drawing.Point(395, 49);
            this.PositionAxes.Name = "PositionAxes";
            this.PositionAxes.SetMode = VisiWinNET.Forms.SetMode.KeyMode;
            this.PositionAxes.Size = new System.Drawing.Size(63, 30);
            this.PositionAxes.TabIndex = 23;
            this.PositionAxes.VWItem.Name = "Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes";
            this.PositionAxes.VWItemMonitor.Name = "Ch1.Ergo_PLC.g_stMachine.bPositionAllAxes";
            // 
            // BarsXIn
            // 
            this.BarsXIn.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXIn.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXIn.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarsXIn.Label.InternalFont.Name = "Arial";
            this.BarsXIn.Label.InternalFont.Size = 9F;
            this.BarsXIn.Label.Text.Text = "Bars X";
            this.BarsXIn.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsXIn.Location = new System.Drawing.Point(3, 16);
            this.BarsXIn.Name = "BarsXIn";
            this.BarsXIn.PasswordChar = '\0';
            this.BarsXIn.Size = new System.Drawing.Size(94, 63);
            this.BarsXIn.TabIndex = 12;
            this.BarsXIn.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXIn.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarsXIn.Unit.SizeRatio = 0.25;
            this.BarsXIn.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsXIn.VWItem.DecPoint = 2;
            this.BarsXIn.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_X.rTargetPosition";
            // 
            // BarsYIn
            // 
            this.BarsYIn.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYIn.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYIn.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarsYIn.Label.InternalFont.Name = "Arial";
            this.BarsYIn.Label.InternalFont.Size = 9F;
            this.BarsYIn.Label.Text.Text = "Bars Y";
            this.BarsYIn.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsYIn.Location = new System.Drawing.Point(101, 16);
            this.BarsYIn.Name = "BarsYIn";
            this.BarsYIn.PasswordChar = '\0';
            this.BarsYIn.Size = new System.Drawing.Size(92, 63);
            this.BarsYIn.TabIndex = 13;
            this.BarsYIn.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYIn.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarsYIn.Unit.SizeRatio = 0.25;
            this.BarsYIn.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsYIn.VWItem.DecPoint = 2;
            this.BarsYIn.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_Y.rTargetPosition";
            // 
            // SaddleXIn
            // 
            this.SaddleXIn.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXIn.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXIn.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaddleXIn.Label.InternalFont.Name = "Arial";
            this.SaddleXIn.Label.InternalFont.Size = 9F;
            this.SaddleXIn.Label.Text.Text = "Saddle X";
            this.SaddleXIn.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleXIn.LimitMax.Value = 170;
            this.SaddleXIn.Location = new System.Drawing.Point(199, 16);
            this.SaddleXIn.Name = "SaddleXIn";
            this.SaddleXIn.PasswordChar = '\0';
            this.SaddleXIn.Size = new System.Drawing.Size(92, 63);
            this.SaddleXIn.TabIndex = 14;
            this.SaddleXIn.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXIn.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaddleXIn.Unit.SizeRatio = 0.25;
            this.SaddleXIn.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleXIn.VWItem.DecPoint = 2;
            this.SaddleXIn.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_X.rTargetPosition";
            // 
            // SaddleYIn
            // 
            this.SaddleYIn.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYIn.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYIn.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaddleYIn.Label.InternalFont.Name = "Arial";
            this.SaddleYIn.Label.InternalFont.Size = 9F;
            this.SaddleYIn.Label.Text.Text = "Saddle Y";
            this.SaddleYIn.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleYIn.LimitMax.Value = 340;
            this.SaddleYIn.Location = new System.Drawing.Point(297, 16);
            this.SaddleYIn.Name = "SaddleYIn";
            this.SaddleYIn.PasswordChar = '\0';
            this.SaddleYIn.Size = new System.Drawing.Size(92, 63);
            this.SaddleYIn.TabIndex = 15;
            this.SaddleYIn.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYIn.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaddleYIn.Unit.SizeRatio = 0.25;
            this.SaddleYIn.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleYIn.VWItem.DecPoint = 2;
            this.SaddleYIn.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.rTargetPosition";
            // 
            // SaddleXOut
            // 
            this.SaddleXOut.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXOut.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXOut.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleXOut.Location = new System.Drawing.Point(81, 242);
            this.SaddleXOut.Name = "SaddleXOut";
            this.SaddleXOut.Size = new System.Drawing.Size(114, 41);
            this.SaddleXOut.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleXOut.Unit.InternalFont.Name = "Arial";
            this.SaddleXOut.Unit.InternalFont.Size = 9F;
            this.SaddleXOut.Unit.SizeRatio = 0.25;
            this.SaddleXOut.Unit.Text.Text = "mm";
            this.SaddleXOut.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleXOut.VWItem.DecPoint = 2;
            this.SaddleXOut.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_X.rActualPosition";
            // 
            // SaddleYOut
            // 
            this.SaddleYOut.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYOut.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYOut.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleYOut.Location = new System.Drawing.Point(184, 360);
            this.SaddleYOut.Name = "SaddleYOut";
            this.SaddleYOut.Size = new System.Drawing.Size(105, 41);
            this.SaddleYOut.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.SaddleYOut.Unit.InternalFont.Name = "Arial";
            this.SaddleYOut.Unit.InternalFont.Size = 9F;
            this.SaddleYOut.Unit.SizeRatio = 0.25;
            this.SaddleYOut.Unit.Text.Text = "mm";
            this.SaddleYOut.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaddleYOut.VWItem.DecPoint = 2;
            this.SaddleYOut.VWItem.Name = "Ch1.Ergo_PLC.g_stSaddle_Y.rActualPosition";
            // 
            // BarsXOut
            // 
            this.BarsXOut.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXOut.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXOut.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsXOut.Location = new System.Drawing.Point(755, 270);
            this.BarsXOut.Name = "BarsXOut";
            this.BarsXOut.Size = new System.Drawing.Size(105, 41);
            this.BarsXOut.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsXOut.Unit.InternalFont.Name = "Arial";
            this.BarsXOut.Unit.InternalFont.Size = 9F;
            this.BarsXOut.Unit.SizeRatio = 0.25;
            this.BarsXOut.Unit.Text.Text = "mm";
            this.BarsXOut.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsXOut.VWItem.DecPoint = 2;
            this.BarsXOut.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_X.rActualPosition";
            // 
            // BarsYOut
            // 
            this.BarsYOut.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYOut.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYOut.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsYOut.Location = new System.Drawing.Point(709, 143);
            this.BarsYOut.Name = "BarsYOut";
            this.BarsYOut.Size = new System.Drawing.Size(105, 41);
            this.BarsYOut.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.BarsYOut.Unit.InternalFont.Name = "Arial";
            this.BarsYOut.Unit.InternalFont.Size = 9F;
            this.BarsYOut.Unit.SizeRatio = 0.25;
            this.BarsYOut.Unit.Text.Text = "mm";
            this.BarsYOut.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BarsYOut.VWItem.DecPoint = 2;
            this.BarsYOut.VWItem.Name = "Ch1.Ergo_PLC.g_stBars_Y.rActualPosition";
            // 
            // BackButton
            // 
            this.BackButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.BackButton.Command.Param = "#HistoryBack";
            this.BackButton.LocalizedText.Text = "Back";
            this.BackButton.Location = new System.Drawing.Point(878, 642);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(146, 48);
            this.BackButton.TabIndex = 29;
            // 
            // MessageOut
            // 
            this.MessageOut.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.MessageOut.ForeColor = System.Drawing.Color.Red;
            this.MessageOut.InternalFont.Name = "Arial";
            this.MessageOut.InternalFont.Size = 10F;
            this.MessageOut.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.MessageOut.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.MessageOut.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessageOut.Location = new System.Drawing.Point(585, 49);
            this.MessageOut.Name = "MessageOut";
            this.MessageOut.Size = new System.Drawing.Size(417, 30);
            this.MessageOut.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.MessageOut.Unit.SizeRatio = 0.25;
            this.MessageOut.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MessageOut.VWItem.Name = "Ch1.Ergo_PLC.g_stMachine.sUserMessage";
            // 
            // Geometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MessageOut);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PositionAxes);
            this.Controls.Add(this.BarsYOut);
            this.Controls.Add(this.BarsXOut);
            this.Controls.Add(this.SaddleYOut);
            this.Controls.Add(this.SaddleXOut);
            this.Controls.Add(this.SaddleYIn);
            this.Controls.Add(this.SaddleXIn);
            this.Controls.Add(this.BarsYIn);
            this.Controls.Add(this.BarsXIn);
            this.Controls.Add(this.HomeAxesButton);
            this.Controls.Add(this.commandButton4);
            this.Controls.Add(this.commandButton3);
            this.Controls.Add(this.commandButton2);
            this.Controls.Add(this.commandButton1);
            this.Controls.Add(this.SaddleDownButton);
            this.Controls.Add(this.HandleDownButton);
            this.Controls.Add(this.SaddleUpButton);
            this.Controls.Add(this.HandleUpButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Geometry";
            this.Load += new System.EventHandler(this.Geometry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandleUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandleDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleDownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeAxesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionAxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsXIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsYIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleXIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleYIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleXOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaddleYOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsXOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsYOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisiWinNET.Forms.PictureBox pictureBox1;
        private VisiWinNET.Forms.Key HandleUpButton;
        private VisiWinNET.Forms.Key SaddleUpButton;
        private VisiWinNET.Forms.Key HandleDownButton;
        private VisiWinNET.Forms.Key SaddleDownButton;
        private VisiWinNET.Forms.Key commandButton1;
        private VisiWinNET.Forms.Key commandButton2;
        private VisiWinNET.Forms.Key commandButton3;
        private VisiWinNET.Forms.Key commandButton4;
        private VisiWinNET.Forms.Key PositionAxes;
        private VisiWinNET.Forms.Key HomeAxesButton;
        private VisiWinNET.Forms.VarIn BarsXIn;
        private VisiWinNET.Forms.VarIn BarsYIn;
        private VisiWinNET.Forms.VarIn SaddleXIn;
        private VisiWinNET.Forms.VarIn SaddleYIn;
        private VisiWinNET.Forms.VarOut SaddleXOut;
        private VisiWinNET.Forms.VarOut SaddleYOut;
        private VisiWinNET.Forms.VarOut BarsXOut;
        private VisiWinNET.Forms.VarOut BarsYOut;
        private VisiWinNET.Forms.CommandButton BackButton;
        private VisiWinNET.Forms.VarOut MessageOut;



    }
}