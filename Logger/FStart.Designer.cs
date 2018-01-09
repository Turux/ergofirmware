namespace HMI
{
    partial class FStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStart));
            this.label1 = new VisiWinNET.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BackColorOn = System.Drawing.Color.White;
            this.label1.Border.Style = VisiWinNET.Forms.BorderStyle.None;
            this.label1.InternalFont.Name = "Arial";
            this.label1.InternalFont.Size = 15F;
            this.label1.LocalizedText.Text = "Ergometer Tests & Logging";
            this.label1.Location = new System.Drawing.Point(0, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 66);
            this.label1.VWItem.BitEvents = false;
            this.label1.VWItem.Mode = VisiWinNET.DataAccess.ItemMode.Bits;
            // 
            // FStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(520, 316);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FStart";
            this.Project = "Logger";
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisiWinNET.Forms.Label label1;
    }
}