namespace HMI
{
    partial class FCentral
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
            this.components = new System.ComponentModel.Container();
            this.touchKeyboard = new VisiWinNET.Forms.TouchKeyboard(this.components);
            this.sandglass = new VisiWinNET.Forms.Sandglass(this.components);
            this.cmdEnd = new VisiWinNET.Forms.CommandButton();
            this.label1 = new VisiWinNET.Forms.Label();
            this.groupBox1 = new VisiWinNET.Forms.GroupBox();
            this.Time3MinButton = new VisiWinNET.Forms.CommandButton();
            this.Time1MinButton = new VisiWinNET.Forms.CommandButton();
            this.Time20MinButton = new VisiWinNET.Forms.CommandButton();
            this.Time5MinButton = new VisiWinNET.Forms.CommandButton();
            this.label2 = new VisiWinNET.Forms.Label();
            this.groupBox2 = new VisiWinNET.Forms.GroupBox();
            this.engineeringModeButton = new VisiWinNET.Forms.CommandButton();
            this.groupBox3 = new VisiWinNET.Forms.GroupBox();
            this.Geometry3MinButton = new VisiWinNET.Forms.CommandButton();
            ((System.ComponentModel.ISupportInitialize)(this.touchKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandglass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time3MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time1MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time20MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time5MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineeringModeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Geometry3MinButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sandglass
            // 
            this.sandglass.SandglassLocation = new System.Drawing.Point(0, 0);
            this.sandglass.SandglassPosition = VisiWinNET.Forms.SandglassPosition.CenterScreen;
            this.sandglass.ShowBehavior = VisiWinNET.Forms.SandglassShowBehavior.Always;
            // 
            // cmdEnd
            // 
            this.cmdEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEnd.Command.Command = VisiWinNET.Forms.ApplicationCommands.ExitApplication;
            this.cmdEnd.InternalFont.Name = "Calibri";
            this.cmdEnd.InternalFont.Size = 12F;
            this.cmdEnd.LocalizedText.Text = "Exit";
            this.cmdEnd.Location = new System.Drawing.Point(672, 594);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(129, 44);
            this.cmdEnd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.label1.InternalFont.Name = "Arial";
            this.label1.InternalFont.Size = 14F;
            this.label1.LocalizedText.Text = "W  E  L  C  O  M  E";
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 24);
            this.label1.VWItem.BitEvents = false;
            this.label1.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // groupBox1
            // 
            this.groupBox1.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly;
            this.groupBox1.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox;
            this.groupBox1.Controls.Add(this.Time3MinButton);
            this.groupBox1.Controls.Add(this.Time1MinButton);
            this.groupBox1.Controls.Add(this.Time20MinButton);
            this.groupBox1.Controls.Add(this.Time5MinButton);
            this.groupBox1.LocalizedText.Text = "Time Based Tests";
            this.groupBox1.Location = new System.Drawing.Point(23, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 104);
            this.groupBox1.TabIndex = 1;
            // 
            // Time3MinButton
            // 
            this.Time3MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Time3MinButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time3MinButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.Time3MinButton.Command.Param = "TimeMenu";
            this.Time3MinButton.InternalFont.Name = "Microsoft Sans Serif";
            this.Time3MinButton.InternalFont.Size = 10F;
            this.Time3MinButton.LocalizedText.Text = "3 Min";
            this.Time3MinButton.Location = new System.Drawing.Point(133, 30);
            this.Time3MinButton.Name = "Time3MinButton";
            this.Time3MinButton.Size = new System.Drawing.Size(79, 49);
            this.Time3MinButton.TabIndex = 3;
            this.Time3MinButton.Click += new System.EventHandler(this.Time3MinButton_Click);
            // 
            // Time1MinButton
            // 
            this.Time1MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Time1MinButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time1MinButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.Time1MinButton.Command.Param = "TimeMenu";
            this.Time1MinButton.InternalFont.Name = "Microsoft Sans Serif";
            this.Time1MinButton.InternalFont.Size = 10F;
            this.Time1MinButton.LocalizedText.Text = "1 Min";
            this.Time1MinButton.Location = new System.Drawing.Point(12, 30);
            this.Time1MinButton.Name = "Time1MinButton";
            this.Time1MinButton.Size = new System.Drawing.Size(79, 49);
            this.Time1MinButton.TabIndex = 2;
            this.Time1MinButton.Click += new System.EventHandler(this.Time1MinButton_Click);
            // 
            // Time20MinButton
            // 
            this.Time20MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Time20MinButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time20MinButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.Time20MinButton.Command.Param = "TimeMenu";
            this.Time20MinButton.LocalizedText.Text = "20 Min";
            this.Time20MinButton.Location = new System.Drawing.Point(383, 30);
            this.Time20MinButton.Name = "Time20MinButton";
            this.Time20MinButton.Size = new System.Drawing.Size(79, 49);
            this.Time20MinButton.TabIndex = 1;
            this.Time20MinButton.Click += new System.EventHandler(this.Time20MinButton_Click);
            // 
            // Time5MinButton
            // 
            this.Time5MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Time5MinButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time5MinButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.Time5MinButton.Command.Param = "TimeMenu";
            this.Time5MinButton.InternalFont.Name = "Microsoft Sans Serif";
            this.Time5MinButton.InternalFont.Size = 10F;
            this.Time5MinButton.LocalizedText.Text = "5 Min";
            this.Time5MinButton.Location = new System.Drawing.Point(256, 30);
            this.Time5MinButton.Name = "Time5MinButton";
            this.Time5MinButton.Size = new System.Drawing.Size(79, 49);
            this.Time5MinButton.TabIndex = 0;
            this.Time5MinButton.Click += new System.EventHandler(this.Time5MinButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.label2.InternalFont.Name = "Arial";
            this.label2.InternalFont.Size = 14F;
            this.label2.LocalizedText.Text = "Chose a Test";
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 24);
            this.label2.VWItem.BitEvents = false;
            this.label2.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // groupBox2
            // 
            this.groupBox2.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly;
            this.groupBox2.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox;
            this.groupBox2.Controls.Add(this.engineeringModeButton);
            this.groupBox2.LocalizedText.Text = "Settings";
            this.groupBox2.Location = new System.Drawing.Point(27, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 104);
            this.groupBox2.TabIndex = 3;
            // 
            // engineeringModeButton
            // 
            this.engineeringModeButton.BackColor = System.Drawing.Color.Silver;
            this.engineeringModeButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.engineeringModeButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.engineeringModeButton.Command.Param = "EngineeringMode";
            this.engineeringModeButton.InternalFont.Name = "Microsoft Sans Serif";
            this.engineeringModeButton.InternalFont.Size = 10F;
            this.engineeringModeButton.LocalizedText.Text = "Engineerig Mode";
            this.engineeringModeButton.Location = new System.Drawing.Point(12, 34);
            this.engineeringModeButton.Name = "engineeringModeButton";
            this.engineeringModeButton.Size = new System.Drawing.Size(79, 49);
            this.engineeringModeButton.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.groupBox3.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly;
            this.groupBox3.Border.Style = VisiWinNET.Forms.BorderStyle.GroupBox;
            this.groupBox3.Controls.Add(this.Geometry3MinButton);
            this.groupBox3.LocalizedText.Text = "Geometry Tests";
            this.groupBox3.Location = new System.Drawing.Point(23, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 103);
            this.groupBox3.TabIndex = 6;
            // 
            // Geometry3MinButton
            // 
            this.Geometry3MinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Geometry3MinButton.BackColorDown = System.Drawing.SystemColors.ActiveCaptionText;
            this.Geometry3MinButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.Geometry3MinButton.Command.Param = "TimeMenu";
            this.Geometry3MinButton.InternalFont.Name = "Microsoft Sans Serif";
            this.Geometry3MinButton.InternalFont.Size = 10F;
            this.Geometry3MinButton.LocalizedText.Text = "3 Min";
            this.Geometry3MinButton.Location = new System.Drawing.Point(12, 34);
            this.Geometry3MinButton.Name = "Geometry3MinButton";
            this.Geometry3MinButton.Size = new System.Drawing.Size(79, 49);
            this.Geometry3MinButton.TabIndex = 4;
            this.Geometry3MinButton.Click += new System.EventHandler(this.Geometry3MinButton_Click_1);
            // 
            // FCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1066, 722);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEnd);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCentral";
            this.Text = "FCentral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.touchKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandglass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Time3MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time1MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time20MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time5MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.engineeringModeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Geometry3MinButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisiWinNET.Forms.CommandButton cmdEnd;
	    private VisiWinNET.Forms.TouchKeyboard touchKeyboard;
	    private VisiWinNET.Forms.Sandglass sandglass;
        private VisiWinNET.Forms.Label label1;
        private VisiWinNET.Forms.GroupBox groupBox1;
        private VisiWinNET.Forms.CommandButton Time20MinButton;
        private VisiWinNET.Forms.CommandButton Time5MinButton;
        private VisiWinNET.Forms.CommandButton Time1MinButton;
        private VisiWinNET.Forms.Label label2;
        private VisiWinNET.Forms.GroupBox groupBox2;
        private VisiWinNET.Forms.CommandButton engineeringModeButton;
        private VisiWinNET.Forms.CommandButton Time3MinButton;
        private VisiWinNET.Forms.GroupBox groupBox3;
        private VisiWinNET.Forms.CommandButton Geometry3MinButton;        
        
    }
}