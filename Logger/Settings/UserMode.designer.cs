namespace HMI
{
    partial class UserMode
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
            this.tabControl1 = new VisiWinNET.Forms.TabControl();
            this.CLtab = new VisiWinNET.Forms.TabPage();
            this.Gear6CL = new VisiWinNET.Forms.VarIn();
            this.Gear9CL = new VisiWinNET.Forms.VarIn();
            this.Gear8CL = new VisiWinNET.Forms.VarIn();
            this.Gear7CL = new VisiWinNET.Forms.VarIn();
            this.Gear5CL = new VisiWinNET.Forms.VarIn();
            this.Gear4CL = new VisiWinNET.Forms.VarIn();
            this.Gear3CL = new VisiWinNET.Forms.VarIn();
            this.Gear2CL = new VisiWinNET.Forms.VarIn();
            this.Gear1CL = new VisiWinNET.Forms.VarIn();
            this.CPtab = new VisiWinNET.Forms.TabPage();
            this.varIn4 = new VisiWinNET.Forms.VarIn();
            this.varIn5 = new VisiWinNET.Forms.VarIn();
            this.varIn6 = new VisiWinNET.Forms.VarIn();
            this.varIn1 = new VisiWinNET.Forms.VarIn();
            this.varIn2 = new VisiWinNET.Forms.VarIn();
            this.varIn3 = new VisiWinNET.Forms.VarIn();
            this.Gear3CP = new VisiWinNET.Forms.VarIn();
            this.Gear2CP = new VisiWinNET.Forms.VarIn();
            this.Gear1CP = new VisiWinNET.Forms.VarIn();
            this.Cogtab = new VisiWinNET.Forms.TabPage();
            this.GearSize9 = new VisiWinNET.Forms.VarIn();
            this.GearSize8 = new VisiWinNET.Forms.VarIn();
            this.GearSize7 = new VisiWinNET.Forms.VarIn();
            this.GearSize6 = new VisiWinNET.Forms.VarIn();
            this.GearSize5 = new VisiWinNET.Forms.VarIn();
            this.GearSize4 = new VisiWinNET.Forms.VarIn();
            this.GearSize3 = new VisiWinNET.Forms.VarIn();
            this.GearSize2 = new VisiWinNET.Forms.VarIn();
            this.GearSize1 = new VisiWinNET.Forms.VarIn();
            this.BackButton = new VisiWinNET.Forms.CommandButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CLtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gear6CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear9CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear8CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear7CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear5CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear4CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear3CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear2CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear1CL)).BeginInit();
            this.CPtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varIn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear3CP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear2CP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear1CP)).BeginInit();
            this.Cogtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Blink.Mode = VisiWinNET.Services.BlinkMode.EventOnly;
            this.tabControl1.Controls.Add(this.CLtab);
            this.tabControl1.Controls.Add(this.CPtab);
            this.tabControl1.Controls.Add(this.Cogtab);
            this.tabControl1.Location = new System.Drawing.Point(20, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(976, 619);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabMaxSize = new System.Drawing.Size(200, 40);
            this.tabControl1.TabMinSize = new System.Drawing.Size(80, 30);
            this.tabControl1.TabPages.AddRange(new VisiWinNET.Forms.TabPage[] {
            this.CLtab,
            this.CPtab,
            this.Cogtab});
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // CLtab
            // 
            this.CLtab.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.CLtab.Controls.Add(this.Gear6CL);
            this.CLtab.Controls.Add(this.Gear9CL);
            this.CLtab.Controls.Add(this.Gear8CL);
            this.CLtab.Controls.Add(this.Gear7CL);
            this.CLtab.Controls.Add(this.Gear5CL);
            this.CLtab.Controls.Add(this.Gear4CL);
            this.CLtab.Controls.Add(this.Gear3CL);
            this.CLtab.Controls.Add(this.Gear2CL);
            this.CLtab.Controls.Add(this.Gear1CL);
            this.CLtab.Name = "CLtab";
            this.CLtab.Tab.LocalizedText.Text = "Closed Loop";
            this.CLtab.Tab.Size = new System.Drawing.Size(90, 80);
            // 
            // Gear6CL
            // 
            this.Gear6CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear6CL.InternalFont.Name = "Stencil";
            this.Gear6CL.InternalFont.Size = 29F;
            this.Gear6CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear6CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear6CL.Label.InternalFont.Name = "Tahoma";
            this.Gear6CL.Label.InternalFont.Size = 12F;
            this.Gear6CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear6CL.Label.SizeRatio = 0.2;
            this.Gear6CL.Label.Text.Text = "6th";
            this.Gear6CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear6CL.LimitMax.Value = 50;
            this.Gear6CL.LimitMin.Value = 1;
            this.Gear6CL.Location = new System.Drawing.Point(407, 208);
            this.Gear6CL.Name = "Gear6CL";
            this.Gear6CL.PasswordChar = '\0';
            this.Gear6CL.Size = new System.Drawing.Size(148, 100);
            this.Gear6CL.TabIndex = 8;
            this.Gear6CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear6CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear6CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear6CL.Unit.InternalFont.Size = 12F;
            this.Gear6CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear6CL.Unit.SizeRatio = 0.25;
            this.Gear6CL.Unit.Text.Text = "Nm";
            this.Gear6CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear6CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[6]";
            // 
            // Gear9CL
            // 
            this.Gear9CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear9CL.InternalFont.Name = "Stencil";
            this.Gear9CL.InternalFont.Size = 29F;
            this.Gear9CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear9CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear9CL.Label.InternalFont.Name = "Tahoma";
            this.Gear9CL.Label.InternalFont.Size = 12F;
            this.Gear9CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear9CL.Label.SizeRatio = 0.2;
            this.Gear9CL.Label.Text.Text = "9th";
            this.Gear9CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear9CL.LimitMax.Value = 50;
            this.Gear9CL.LimitMin.Value = 1;
            this.Gear9CL.Location = new System.Drawing.Point(407, 377);
            this.Gear9CL.Name = "Gear9CL";
            this.Gear9CL.PasswordChar = '\0';
            this.Gear9CL.Size = new System.Drawing.Size(148, 100);
            this.Gear9CL.TabIndex = 7;
            this.Gear9CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear9CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear9CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear9CL.Unit.InternalFont.Size = 12F;
            this.Gear9CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear9CL.Unit.SizeRatio = 0.25;
            this.Gear9CL.Unit.Text.Text = "Nm";
            this.Gear9CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear9CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[9]";
            // 
            // Gear8CL
            // 
            this.Gear8CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear8CL.InternalFont.Name = "Stencil";
            this.Gear8CL.InternalFont.Size = 29F;
            this.Gear8CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear8CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear8CL.Label.InternalFont.Name = "Tahoma";
            this.Gear8CL.Label.InternalFont.Size = 12F;
            this.Gear8CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear8CL.Label.SizeRatio = 0.2;
            this.Gear8CL.Label.Text.Text = "8th";
            this.Gear8CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear8CL.LimitMax.Value = 50;
            this.Gear8CL.LimitMin.Value = 1;
            this.Gear8CL.Location = new System.Drawing.Point(224, 377);
            this.Gear8CL.Name = "Gear8CL";
            this.Gear8CL.PasswordChar = '\0';
            this.Gear8CL.Size = new System.Drawing.Size(148, 100);
            this.Gear8CL.TabIndex = 6;
            this.Gear8CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear8CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear8CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear8CL.Unit.InternalFont.Size = 12F;
            this.Gear8CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear8CL.Unit.SizeRatio = 0.25;
            this.Gear8CL.Unit.Text.Text = "Nm";
            this.Gear8CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear8CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[8]";
            // 
            // Gear7CL
            // 
            this.Gear7CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear7CL.InternalFont.Name = "Stencil";
            this.Gear7CL.InternalFont.Size = 29F;
            this.Gear7CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear7CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear7CL.Label.InternalFont.Name = "Tahoma";
            this.Gear7CL.Label.InternalFont.Size = 12F;
            this.Gear7CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear7CL.Label.SizeRatio = 0.2;
            this.Gear7CL.Label.Text.Text = "7th";
            this.Gear7CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear7CL.LimitMax.Value = 50;
            this.Gear7CL.LimitMin.Value = 1;
            this.Gear7CL.Location = new System.Drawing.Point(41, 377);
            this.Gear7CL.Name = "Gear7CL";
            this.Gear7CL.PasswordChar = '\0';
            this.Gear7CL.Size = new System.Drawing.Size(148, 100);
            this.Gear7CL.TabIndex = 5;
            this.Gear7CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear7CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear7CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear7CL.Unit.InternalFont.Size = 12F;
            this.Gear7CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear7CL.Unit.SizeRatio = 0.25;
            this.Gear7CL.Unit.Text.Text = "Nm";
            this.Gear7CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear7CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[7]";
            // 
            // Gear5CL
            // 
            this.Gear5CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear5CL.InternalFont.Name = "Stencil";
            this.Gear5CL.InternalFont.Size = 29F;
            this.Gear5CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear5CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear5CL.Label.InternalFont.Name = "Tahoma";
            this.Gear5CL.Label.InternalFont.Size = 12F;
            this.Gear5CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear5CL.Label.SizeRatio = 0.2;
            this.Gear5CL.Label.Text.Text = "5th";
            this.Gear5CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear5CL.LimitMax.Value = 50;
            this.Gear5CL.LimitMin.Value = 1;
            this.Gear5CL.Location = new System.Drawing.Point(224, 208);
            this.Gear5CL.Name = "Gear5CL";
            this.Gear5CL.PasswordChar = '\0';
            this.Gear5CL.Size = new System.Drawing.Size(148, 100);
            this.Gear5CL.TabIndex = 4;
            this.Gear5CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear5CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear5CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear5CL.Unit.InternalFont.Size = 12F;
            this.Gear5CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear5CL.Unit.SizeRatio = 0.25;
            this.Gear5CL.Unit.Text.Text = "Nm";
            this.Gear5CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear5CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[5]";
            // 
            // Gear4CL
            // 
            this.Gear4CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear4CL.InternalFont.Name = "Stencil";
            this.Gear4CL.InternalFont.Size = 29F;
            this.Gear4CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear4CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear4CL.Label.InternalFont.Name = "Tahoma";
            this.Gear4CL.Label.InternalFont.Size = 12F;
            this.Gear4CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear4CL.Label.SizeRatio = 0.2;
            this.Gear4CL.Label.Text.Text = "4th";
            this.Gear4CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear4CL.LimitMax.Value = 50;
            this.Gear4CL.LimitMin.Value = 1;
            this.Gear4CL.Location = new System.Drawing.Point(41, 208);
            this.Gear4CL.Name = "Gear4CL";
            this.Gear4CL.PasswordChar = '\0';
            this.Gear4CL.Size = new System.Drawing.Size(148, 100);
            this.Gear4CL.TabIndex = 3;
            this.Gear4CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear4CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear4CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear4CL.Unit.InternalFont.Size = 12F;
            this.Gear4CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear4CL.Unit.SizeRatio = 0.25;
            this.Gear4CL.Unit.Text.Text = "Nm";
            this.Gear4CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear4CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[4]";
            // 
            // Gear3CL
            // 
            this.Gear3CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CL.InternalFont.Name = "Stencil";
            this.Gear3CL.InternalFont.Size = 29F;
            this.Gear3CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear3CL.Label.InternalFont.Name = "Tahoma";
            this.Gear3CL.Label.InternalFont.Size = 12F;
            this.Gear3CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear3CL.Label.SizeRatio = 0.2;
            this.Gear3CL.Label.Text.Text = "3rd";
            this.Gear3CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear3CL.LimitMax.Value = 50;
            this.Gear3CL.LimitMin.Value = 1;
            this.Gear3CL.Location = new System.Drawing.Point(407, 52);
            this.Gear3CL.Name = "Gear3CL";
            this.Gear3CL.PasswordChar = '\0';
            this.Gear3CL.Size = new System.Drawing.Size(148, 100);
            this.Gear3CL.TabIndex = 2;
            this.Gear3CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear3CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear3CL.Unit.InternalFont.Size = 12F;
            this.Gear3CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear3CL.Unit.SizeRatio = 0.25;
            this.Gear3CL.Unit.Text.Text = "Nm";
            this.Gear3CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear3CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[3]";
            // 
            // Gear2CL
            // 
            this.Gear2CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CL.InternalFont.Name = "Stencil";
            this.Gear2CL.InternalFont.Size = 29F;
            this.Gear2CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear2CL.Label.InternalFont.Name = "Tahoma";
            this.Gear2CL.Label.InternalFont.Size = 12F;
            this.Gear2CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear2CL.Label.SizeRatio = 0.2;
            this.Gear2CL.Label.Text.Text = "2nd";
            this.Gear2CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear2CL.LimitMax.Value = 50;
            this.Gear2CL.LimitMin.Value = 1;
            this.Gear2CL.Location = new System.Drawing.Point(224, 52);
            this.Gear2CL.Name = "Gear2CL";
            this.Gear2CL.PasswordChar = '\0';
            this.Gear2CL.Size = new System.Drawing.Size(148, 100);
            this.Gear2CL.TabIndex = 1;
            this.Gear2CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear2CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear2CL.Unit.InternalFont.Size = 12F;
            this.Gear2CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear2CL.Unit.SizeRatio = 0.25;
            this.Gear2CL.Unit.Text.Text = "Nm";
            this.Gear2CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear2CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[2]";
            // 
            // Gear1CL
            // 
            this.Gear1CL.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CL.InternalFont.Name = "Stencil";
            this.Gear1CL.InternalFont.Size = 29F;
            this.Gear1CL.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CL.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear1CL.Label.InternalFont.Name = "Tahoma";
            this.Gear1CL.Label.InternalFont.Size = 12F;
            this.Gear1CL.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear1CL.Label.SizeRatio = 0.2;
            this.Gear1CL.Label.Text.Text = "1st";
            this.Gear1CL.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear1CL.LimitMax.Value = 50;
            this.Gear1CL.LimitMin.Value = 1;
            this.Gear1CL.Location = new System.Drawing.Point(41, 52);
            this.Gear1CL.Name = "Gear1CL";
            this.Gear1CL.PasswordChar = '\0';
            this.Gear1CL.Size = new System.Drawing.Size(148, 100);
            this.Gear1CL.TabIndex = 0;
            this.Gear1CL.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CL.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear1CL.Unit.InternalFont.Name = "Tahoma";
            this.Gear1CL.Unit.InternalFont.Size = 12F;
            this.Gear1CL.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear1CL.Unit.SizeRatio = 0.25;
            this.Gear1CL.Unit.Text.Text = "Nm";
            this.Gear1CL.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear1CL.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetClosedLoopTorque_Nm[1]";
            // 
            // CPtab
            // 
            this.CPtab.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.CPtab.Controls.Add(this.varIn4);
            this.CPtab.Controls.Add(this.varIn5);
            this.CPtab.Controls.Add(this.varIn6);
            this.CPtab.Controls.Add(this.varIn1);
            this.CPtab.Controls.Add(this.varIn2);
            this.CPtab.Controls.Add(this.varIn3);
            this.CPtab.Controls.Add(this.Gear3CP);
            this.CPtab.Controls.Add(this.Gear2CP);
            this.CPtab.Controls.Add(this.Gear1CP);
            this.CPtab.Enabled = false;
            this.CPtab.Name = "CPtab";
            this.CPtab.Tab.LocalizedText.Text = "Constant Power";
            this.CPtab.Tab.Size = new System.Drawing.Size(120, 80);
            this.CPtab.Visible = false;
            // 
            // varIn4
            // 
            this.varIn4.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn4.InternalFont.Name = "Stencil";
            this.varIn4.InternalFont.Size = 29F;
            this.varIn4.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn4.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn4.Label.InternalFont.Name = "Tahoma";
            this.varIn4.Label.InternalFont.Size = 12F;
            this.varIn4.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn4.Label.SizeRatio = 0.2;
            this.varIn4.Label.Text.Text = "3rd";
            this.varIn4.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn4.LimitMax.Value = 50;
            this.varIn4.Location = new System.Drawing.Point(416, 364);
            this.varIn4.Name = "varIn4";
            this.varIn4.PasswordChar = '\0';
            this.varIn4.Size = new System.Drawing.Size(148, 100);
            this.varIn4.TabIndex = 17;
            this.varIn4.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn4.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn4.Unit.InternalFont.Name = "Tahoma";
            this.varIn4.Unit.InternalFont.Size = 12F;
            this.varIn4.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn4.Unit.SizeRatio = 0.2;
            this.varIn4.Unit.Text.Text = "W";
            this.varIn4.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn4.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[2]";
            // 
            // varIn5
            // 
            this.varIn5.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn5.InternalFont.Name = "Stencil";
            this.varIn5.InternalFont.Size = 29F;
            this.varIn5.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn5.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn5.Label.InternalFont.Name = "Tahoma";
            this.varIn5.Label.InternalFont.Size = 12F;
            this.varIn5.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn5.Label.SizeRatio = 0.2;
            this.varIn5.Label.Text.Text = "2nd";
            this.varIn5.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn5.LimitMax.Value = 50;
            this.varIn5.Location = new System.Drawing.Point(233, 364);
            this.varIn5.Name = "varIn5";
            this.varIn5.PasswordChar = '\0';
            this.varIn5.Size = new System.Drawing.Size(148, 100);
            this.varIn5.TabIndex = 16;
            this.varIn5.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn5.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn5.Unit.InternalFont.Name = "Tahoma";
            this.varIn5.Unit.InternalFont.Size = 12F;
            this.varIn5.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn5.Unit.SizeRatio = 0.2;
            this.varIn5.Unit.Text.Text = "W";
            this.varIn5.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn5.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[2]";
            // 
            // varIn6
            // 
            this.varIn6.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn6.InternalFont.Name = "Stencil";
            this.varIn6.InternalFont.Size = 29F;
            this.varIn6.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn6.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn6.Label.InternalFont.Name = "Tahoma";
            this.varIn6.Label.InternalFont.Size = 12F;
            this.varIn6.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn6.Label.SizeRatio = 0.2;
            this.varIn6.Label.Text.Text = "1st";
            this.varIn6.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn6.LimitMax.Value = 50;
            this.varIn6.Location = new System.Drawing.Point(40, 364);
            this.varIn6.Name = "varIn6";
            this.varIn6.PasswordChar = '\0';
            this.varIn6.Size = new System.Drawing.Size(148, 100);
            this.varIn6.TabIndex = 15;
            this.varIn6.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn6.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn6.Unit.InternalFont.Name = "Tahoma";
            this.varIn6.Unit.InternalFont.Size = 12F;
            this.varIn6.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn6.Unit.SizeRatio = 0.2;
            this.varIn6.Unit.Text.Text = "W";
            this.varIn6.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn6.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[1]";
            // 
            // varIn1
            // 
            this.varIn1.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn1.InternalFont.Name = "Stencil";
            this.varIn1.InternalFont.Size = 29F;
            this.varIn1.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn1.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn1.Label.InternalFont.Name = "Tahoma";
            this.varIn1.Label.InternalFont.Size = 12F;
            this.varIn1.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn1.Label.SizeRatio = 0.2;
            this.varIn1.Label.Text.Text = "3rd";
            this.varIn1.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn1.LimitMax.Value = 50;
            this.varIn1.Location = new System.Drawing.Point(416, 198);
            this.varIn1.Name = "varIn1";
            this.varIn1.PasswordChar = '\0';
            this.varIn1.Size = new System.Drawing.Size(148, 100);
            this.varIn1.TabIndex = 14;
            this.varIn1.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn1.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn1.Unit.InternalFont.Name = "Tahoma";
            this.varIn1.Unit.InternalFont.Size = 12F;
            this.varIn1.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn1.Unit.SizeRatio = 0.2;
            this.varIn1.Unit.Text.Text = "W";
            this.varIn1.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn1.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[2]";
            // 
            // varIn2
            // 
            this.varIn2.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn2.InternalFont.Name = "Stencil";
            this.varIn2.InternalFont.Size = 29F;
            this.varIn2.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn2.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn2.Label.InternalFont.Name = "Tahoma";
            this.varIn2.Label.InternalFont.Size = 12F;
            this.varIn2.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn2.Label.SizeRatio = 0.2;
            this.varIn2.Label.Text.Text = "2nd";
            this.varIn2.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn2.LimitMax.Value = 50;
            this.varIn2.Location = new System.Drawing.Point(233, 198);
            this.varIn2.Name = "varIn2";
            this.varIn2.PasswordChar = '\0';
            this.varIn2.Size = new System.Drawing.Size(148, 100);
            this.varIn2.TabIndex = 13;
            this.varIn2.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn2.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn2.Unit.InternalFont.Name = "Tahoma";
            this.varIn2.Unit.InternalFont.Size = 12F;
            this.varIn2.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn2.Unit.SizeRatio = 0.2;
            this.varIn2.Unit.Text.Text = "W";
            this.varIn2.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn2.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[2]";
            // 
            // varIn3
            // 
            this.varIn3.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn3.InternalFont.Name = "Stencil";
            this.varIn3.InternalFont.Size = 29F;
            this.varIn3.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn3.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn3.Label.InternalFont.Name = "Tahoma";
            this.varIn3.Label.InternalFont.Size = 12F;
            this.varIn3.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn3.Label.SizeRatio = 0.2;
            this.varIn3.Label.Text.Text = "1st";
            this.varIn3.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn3.LimitMax.Value = 50;
            this.varIn3.Location = new System.Drawing.Point(40, 198);
            this.varIn3.Name = "varIn3";
            this.varIn3.PasswordChar = '\0';
            this.varIn3.Size = new System.Drawing.Size(148, 100);
            this.varIn3.TabIndex = 12;
            this.varIn3.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.varIn3.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varIn3.Unit.InternalFont.Name = "Tahoma";
            this.varIn3.Unit.InternalFont.Size = 12F;
            this.varIn3.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.varIn3.Unit.SizeRatio = 0.2;
            this.varIn3.Unit.Text.Text = "W";
            this.varIn3.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.varIn3.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[1]";
            // 
            // Gear3CP
            // 
            this.Gear3CP.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CP.InternalFont.Name = "Stencil";
            this.Gear3CP.InternalFont.Size = 29F;
            this.Gear3CP.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CP.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear3CP.Label.InternalFont.Name = "Tahoma";
            this.Gear3CP.Label.InternalFont.Size = 12F;
            this.Gear3CP.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear3CP.Label.SizeRatio = 0.2;
            this.Gear3CP.Label.Text.Text = "3rd";
            this.Gear3CP.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear3CP.LimitMax.Value = 50;
            this.Gear3CP.Location = new System.Drawing.Point(416, 48);
            this.Gear3CP.Name = "Gear3CP";
            this.Gear3CP.PasswordChar = '\0';
            this.Gear3CP.Size = new System.Drawing.Size(148, 100);
            this.Gear3CP.TabIndex = 11;
            this.Gear3CP.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear3CP.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear3CP.Unit.InternalFont.Name = "Tahoma";
            this.Gear3CP.Unit.InternalFont.Size = 12F;
            this.Gear3CP.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear3CP.Unit.SizeRatio = 0.2;
            this.Gear3CP.Unit.Text.Text = "W";
            this.Gear3CP.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear3CP.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[3]";
            // 
            // Gear2CP
            // 
            this.Gear2CP.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CP.InternalFont.Name = "Stencil";
            this.Gear2CP.InternalFont.Size = 29F;
            this.Gear2CP.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CP.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear2CP.Label.InternalFont.Name = "Tahoma";
            this.Gear2CP.Label.InternalFont.Size = 12F;
            this.Gear2CP.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear2CP.Label.SizeRatio = 0.2;
            this.Gear2CP.Label.Text.Text = "2nd";
            this.Gear2CP.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear2CP.LimitMax.Value = 50;
            this.Gear2CP.Location = new System.Drawing.Point(233, 48);
            this.Gear2CP.Name = "Gear2CP";
            this.Gear2CP.PasswordChar = '\0';
            this.Gear2CP.Size = new System.Drawing.Size(148, 100);
            this.Gear2CP.TabIndex = 10;
            this.Gear2CP.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear2CP.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear2CP.Unit.InternalFont.Name = "Tahoma";
            this.Gear2CP.Unit.InternalFont.Size = 12F;
            this.Gear2CP.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear2CP.Unit.SizeRatio = 0.2;
            this.Gear2CP.Unit.Text.Text = "W";
            this.Gear2CP.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear2CP.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[2]";
            // 
            // Gear1CP
            // 
            this.Gear1CP.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CP.InternalFont.Name = "Stencil";
            this.Gear1CP.InternalFont.Size = 29F;
            this.Gear1CP.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CP.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear1CP.Label.InternalFont.Name = "Tahoma";
            this.Gear1CP.Label.InternalFont.Size = 12F;
            this.Gear1CP.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear1CP.Label.SizeRatio = 0.2;
            this.Gear1CP.Label.Text.Text = "1st";
            this.Gear1CP.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear1CP.LimitMax.Value = 50;
            this.Gear1CP.Location = new System.Drawing.Point(40, 48);
            this.Gear1CP.Name = "Gear1CP";
            this.Gear1CP.PasswordChar = '\0';
            this.Gear1CP.Size = new System.Drawing.Size(148, 100);
            this.Gear1CP.TabIndex = 9;
            this.Gear1CP.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.Gear1CP.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gear1CP.Unit.InternalFont.Name = "Tahoma";
            this.Gear1CP.Unit.InternalFont.Size = 12F;
            this.Gear1CP.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.Gear1CP.Unit.SizeRatio = 0.2;
            this.Gear1CP.Unit.Text.Text = "W";
            this.Gear1CP.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gear1CP.VWItem.Name = "Ch1.Ergo_PLC.g_stCrankControl.arSetConstantPower_W[1]";
            // 
            // Cogtab
            // 
            this.Cogtab.Authorization.Mode = VisiWinNET.UserManagement.AuthorizationModes.Disabled;
            this.Cogtab.Controls.Add(this.GearSize9);
            this.Cogtab.Controls.Add(this.GearSize8);
            this.Cogtab.Controls.Add(this.GearSize7);
            this.Cogtab.Controls.Add(this.GearSize6);
            this.Cogtab.Controls.Add(this.GearSize5);
            this.Cogtab.Controls.Add(this.GearSize4);
            this.Cogtab.Controls.Add(this.GearSize3);
            this.Cogtab.Controls.Add(this.GearSize2);
            this.Cogtab.Controls.Add(this.GearSize1);
            this.Cogtab.Name = "Cogtab";
            this.Cogtab.Tab.LocalizedText.Text = "Gears";
            this.Cogtab.Tab.Size = new System.Drawing.Size(90, 80);
            // 
            // GearSize9
            // 
            this.GearSize9.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize9.InternalFont.Name = "Stencil";
            this.GearSize9.InternalFont.Size = 29F;
            this.GearSize9.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize9.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize9.Label.InternalFont.Name = "Tahoma";
            this.GearSize9.Label.InternalFont.Size = 12F;
            this.GearSize9.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize9.Label.SizeRatio = 0.2;
            this.GearSize9.Label.Text.Text = "9th";
            this.GearSize9.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize9.LimitMax.Value = 50;
            this.GearSize9.Location = new System.Drawing.Point(415, 365);
            this.GearSize9.Name = "GearSize9";
            this.GearSize9.PasswordChar = '\0';
            this.GearSize9.Size = new System.Drawing.Size(148, 100);
            this.GearSize9.TabIndex = 26;
            this.GearSize9.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize9.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize9.Unit.InternalFont.Name = "Tahoma";
            this.GearSize9.Unit.InternalFont.Size = 12F;
            this.GearSize9.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize9.Unit.SizeRatio = 0.27;
            this.GearSize9.Unit.Text.Text = "mm";
            this.GearSize9.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize9.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[9]";
            // 
            // GearSize8
            // 
            this.GearSize8.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize8.InternalFont.Name = "Stencil";
            this.GearSize8.InternalFont.Size = 29F;
            this.GearSize8.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize8.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize8.Label.InternalFont.Name = "Tahoma";
            this.GearSize8.Label.InternalFont.Size = 12F;
            this.GearSize8.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize8.Label.SizeRatio = 0.2;
            this.GearSize8.Label.Text.Text = "8th";
            this.GearSize8.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize8.LimitMax.Value = 50;
            this.GearSize8.Location = new System.Drawing.Point(232, 365);
            this.GearSize8.Name = "GearSize8";
            this.GearSize8.PasswordChar = '\0';
            this.GearSize8.Size = new System.Drawing.Size(148, 100);
            this.GearSize8.TabIndex = 25;
            this.GearSize8.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize8.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize8.Unit.InternalFont.Name = "Tahoma";
            this.GearSize8.Unit.InternalFont.Size = 12F;
            this.GearSize8.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize8.Unit.SizeRatio = 0.27;
            this.GearSize8.Unit.Text.Text = "mm";
            this.GearSize8.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize8.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[8]";
            // 
            // GearSize7
            // 
            this.GearSize7.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize7.InternalFont.Name = "Stencil";
            this.GearSize7.InternalFont.Size = 29F;
            this.GearSize7.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize7.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize7.Label.InternalFont.Name = "Tahoma";
            this.GearSize7.Label.InternalFont.Size = 12F;
            this.GearSize7.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize7.Label.SizeRatio = 0.2;
            this.GearSize7.Label.Text.Text = "7th";
            this.GearSize7.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize7.LimitMax.Value = 50;
            this.GearSize7.Location = new System.Drawing.Point(39, 365);
            this.GearSize7.Name = "GearSize7";
            this.GearSize7.PasswordChar = '\0';
            this.GearSize7.Size = new System.Drawing.Size(148, 100);
            this.GearSize7.TabIndex = 24;
            this.GearSize7.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize7.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize7.Unit.InternalFont.Name = "Tahoma";
            this.GearSize7.Unit.InternalFont.Size = 12F;
            this.GearSize7.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize7.Unit.SizeRatio = 0.27;
            this.GearSize7.Unit.Text.Text = "mm";
            this.GearSize7.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize7.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[7]";
            // 
            // GearSize6
            // 
            this.GearSize6.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize6.InternalFont.Name = "Stencil";
            this.GearSize6.InternalFont.Size = 29F;
            this.GearSize6.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize6.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize6.Label.InternalFont.Name = "Tahoma";
            this.GearSize6.Label.InternalFont.Size = 12F;
            this.GearSize6.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize6.Label.SizeRatio = 0.2;
            this.GearSize6.Label.Text.Text = "6th";
            this.GearSize6.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize6.LimitMax.Value = 50;
            this.GearSize6.Location = new System.Drawing.Point(415, 199);
            this.GearSize6.Name = "GearSize6";
            this.GearSize6.PasswordChar = '\0';
            this.GearSize6.Size = new System.Drawing.Size(148, 100);
            this.GearSize6.TabIndex = 23;
            this.GearSize6.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize6.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize6.Unit.InternalFont.Name = "Tahoma";
            this.GearSize6.Unit.InternalFont.Size = 12F;
            this.GearSize6.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize6.Unit.SizeRatio = 0.27;
            this.GearSize6.Unit.Text.Text = "mm";
            this.GearSize6.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize6.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[6]";
            // 
            // GearSize5
            // 
            this.GearSize5.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize5.InternalFont.Name = "Stencil";
            this.GearSize5.InternalFont.Size = 29F;
            this.GearSize5.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize5.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize5.Label.InternalFont.Name = "Tahoma";
            this.GearSize5.Label.InternalFont.Size = 12F;
            this.GearSize5.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize5.Label.SizeRatio = 0.2;
            this.GearSize5.Label.Text.Text = "5th";
            this.GearSize5.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize5.LimitMax.Value = 50;
            this.GearSize5.Location = new System.Drawing.Point(232, 199);
            this.GearSize5.Name = "GearSize5";
            this.GearSize5.PasswordChar = '\0';
            this.GearSize5.Size = new System.Drawing.Size(148, 100);
            this.GearSize5.TabIndex = 22;
            this.GearSize5.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize5.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize5.Unit.InternalFont.Name = "Tahoma";
            this.GearSize5.Unit.InternalFont.Size = 12F;
            this.GearSize5.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize5.Unit.SizeRatio = 0.27;
            this.GearSize5.Unit.Text.Text = "mm";
            this.GearSize5.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize5.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[5]";
            // 
            // GearSize4
            // 
            this.GearSize4.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize4.InternalFont.Name = "Stencil";
            this.GearSize4.InternalFont.Size = 29F;
            this.GearSize4.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize4.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize4.Label.InternalFont.Name = "Tahoma";
            this.GearSize4.Label.InternalFont.Size = 12F;
            this.GearSize4.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize4.Label.SizeRatio = 0.2;
            this.GearSize4.Label.Text.Text = "4th";
            this.GearSize4.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize4.LimitMax.Value = 50;
            this.GearSize4.Location = new System.Drawing.Point(39, 199);
            this.GearSize4.Name = "GearSize4";
            this.GearSize4.PasswordChar = '\0';
            this.GearSize4.Size = new System.Drawing.Size(148, 100);
            this.GearSize4.TabIndex = 21;
            this.GearSize4.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize4.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize4.Unit.InternalFont.Name = "Tahoma";
            this.GearSize4.Unit.InternalFont.Size = 12F;
            this.GearSize4.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize4.Unit.SizeRatio = 0.27;
            this.GearSize4.Unit.Text.Text = "mm";
            this.GearSize4.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize4.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[4]";
            // 
            // GearSize3
            // 
            this.GearSize3.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize3.InternalFont.Name = "Stencil";
            this.GearSize3.InternalFont.Size = 29F;
            this.GearSize3.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize3.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize3.Label.InternalFont.Name = "Tahoma";
            this.GearSize3.Label.InternalFont.Size = 12F;
            this.GearSize3.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize3.Label.SizeRatio = 0.2;
            this.GearSize3.Label.Text.Text = "3rd";
            this.GearSize3.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize3.LimitMax.Value = 50;
            this.GearSize3.Location = new System.Drawing.Point(415, 49);
            this.GearSize3.Name = "GearSize3";
            this.GearSize3.PasswordChar = '\0';
            this.GearSize3.Size = new System.Drawing.Size(148, 100);
            this.GearSize3.TabIndex = 20;
            this.GearSize3.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize3.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize3.Unit.InternalFont.Name = "Tahoma";
            this.GearSize3.Unit.InternalFont.Size = 12F;
            this.GearSize3.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize3.Unit.SizeRatio = 0.27;
            this.GearSize3.Unit.Text.Text = "mm";
            this.GearSize3.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize3.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[3]";
            // 
            // GearSize2
            // 
            this.GearSize2.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize2.InternalFont.Name = "Stencil";
            this.GearSize2.InternalFont.Size = 29F;
            this.GearSize2.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize2.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize2.Label.InternalFont.Name = "Tahoma";
            this.GearSize2.Label.InternalFont.Size = 12F;
            this.GearSize2.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize2.Label.SizeRatio = 0.2;
            this.GearSize2.Label.Text.Text = "2nd";
            this.GearSize2.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize2.LimitMax.Value = 50;
            this.GearSize2.Location = new System.Drawing.Point(232, 49);
            this.GearSize2.Name = "GearSize2";
            this.GearSize2.PasswordChar = '\0';
            this.GearSize2.Size = new System.Drawing.Size(148, 100);
            this.GearSize2.TabIndex = 19;
            this.GearSize2.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize2.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize2.Unit.InternalFont.Name = "Tahoma";
            this.GearSize2.Unit.InternalFont.Size = 12F;
            this.GearSize2.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize2.Unit.SizeRatio = 0.27;
            this.GearSize2.Unit.Text.Text = "mm";
            this.GearSize2.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize2.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[2]";
            // 
            // GearSize1
            // 
            this.GearSize1.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize1.InternalFont.Name = "Stencil";
            this.GearSize1.InternalFont.Size = 29F;
            this.GearSize1.Label.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize1.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize1.Label.InternalFont.Name = "Tahoma";
            this.GearSize1.Label.InternalFont.Size = 12F;
            this.GearSize1.Label.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize1.Label.SizeRatio = 0.2;
            this.GearSize1.Label.Text.Text = "1st";
            this.GearSize1.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize1.LimitMax.Value = 50;
            this.GearSize1.Location = new System.Drawing.Point(39, 49);
            this.GearSize1.Name = "GearSize1";
            this.GearSize1.PasswordChar = '\0';
            this.GearSize1.Size = new System.Drawing.Size(148, 100);
            this.GearSize1.TabIndex = 18;
            this.GearSize1.Unit.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.GearSize1.Unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GearSize1.Unit.InternalFont.Name = "Tahoma";
            this.GearSize1.Unit.InternalFont.Size = 12F;
            this.GearSize1.Unit.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.GearSize1.Unit.SizeRatio = 0.27;
            this.GearSize1.Unit.Text.Text = "mm";
            this.GearSize1.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GearSize1.VWItem.Name = "Ch1.Ergo_PLC.g_stUIData.arCogSizes[1]";
            // 
            // BackButton
            // 
            this.BackButton.Command.Command = VisiWinNET.Forms.ApplicationCommands.ShowForm;
            this.BackButton.Command.Param = "#HistoryBack";
            this.BackButton.InternalFont.Name = "Tahoma";
            this.BackButton.InternalFont.Size = 14F;
            this.BackButton.InternalFont.Style = System.Drawing.FontStyle.Bold;
            this.BackButton.LocalizedText.Text = "BACK";
            this.BackButton.Location = new System.Drawing.Point(871, 650);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 62);
            this.BackButton.TabIndex = 1;
            // 
            // UserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMode";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CLtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gear6CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear9CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear8CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear7CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear5CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear4CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear3CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear2CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear1CL)).EndInit();
            this.CPtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varIn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varIn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear3CP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear2CP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gear1CP)).EndInit();
            this.Cogtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GearSize9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GearSize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisiWinNET.Forms.TabControl tabControl1;
        private VisiWinNET.Forms.TabPage CLtab;
        private VisiWinNET.Forms.TabPage CPtab;
        private VisiWinNET.Forms.CommandButton BackButton;
        private VisiWinNET.Forms.VarIn Gear1CL;
        private VisiWinNET.Forms.VarIn Gear3CL;
        private VisiWinNET.Forms.VarIn Gear2CL;
        private VisiWinNET.Forms.VarIn Gear4CL;
        private VisiWinNET.Forms.VarIn Gear5CL;
        private VisiWinNET.Forms.VarIn Gear7CL;
        private VisiWinNET.Forms.VarIn Gear6CL;
        private VisiWinNET.Forms.VarIn Gear9CL;
        private VisiWinNET.Forms.VarIn Gear8CL;
        private VisiWinNET.Forms.VarIn Gear1CP;
        private VisiWinNET.Forms.VarIn Gear2CP;
        private VisiWinNET.Forms.VarIn Gear3CP;
        private VisiWinNET.Forms.VarIn varIn4;
        private VisiWinNET.Forms.VarIn varIn5;
        private VisiWinNET.Forms.VarIn varIn6;
        private VisiWinNET.Forms.VarIn varIn1;
        private VisiWinNET.Forms.VarIn varIn2;
        private VisiWinNET.Forms.VarIn varIn3;
        private VisiWinNET.Forms.TabPage Cogtab;
        private VisiWinNET.Forms.VarIn GearSize9;
        private VisiWinNET.Forms.VarIn GearSize8;
        private VisiWinNET.Forms.VarIn GearSize7;
        private VisiWinNET.Forms.VarIn GearSize6;
        private VisiWinNET.Forms.VarIn GearSize5;
        private VisiWinNET.Forms.VarIn GearSize4;
        private VisiWinNET.Forms.VarIn GearSize3;
        private VisiWinNET.Forms.VarIn GearSize2;
        private VisiWinNET.Forms.VarIn GearSize1;

    }
}