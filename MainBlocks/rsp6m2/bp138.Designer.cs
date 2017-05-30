namespace rsp6m2
{
    partial class bp138
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bp138));
            this.roundTrumbler_bp138 = new rsp6m2.Controls.RoundTrumbler();
            this.voltmetr1 = new rsp6m2.Controls.Voltmetr();
            this.SuspendLayout();
            // 
            // roundTrumbler_bp138
            // 
            this.roundTrumbler_bp138.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler_bp138.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler_bp138.BackgroundImage")));
            this.roundTrumbler_bp138.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundTrumbler_bp138.CurrentIndex = 0;
            this.roundTrumbler_bp138.Location = new System.Drawing.Point(304, 132);
            this.roundTrumbler_bp138.Name = "roundTrumbler_bp138";
            this.roundTrumbler_bp138.Size = new System.Drawing.Size(94, 87);
            this.roundTrumbler_bp138.TabIndex = 1;
            this.roundTrumbler_bp138.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roundTrumbler1_MouseClick);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(90, 118);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 60D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(132, 128);
            this.voltmetr1.TabIndex = 2;
            // 
            // bp138
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.bp138ex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 744);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.roundTrumbler_bp138);
            this.DoubleBuffered = true;
            this.Name = "bp138";
            this.Text = "Бп-138";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bp138_FormClosing);
            this.Controls.SetChildIndex(this.roundTrumbler_bp138, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundTrumbler roundTrumbler_bp138;
        private Controls.Voltmetr voltmetr1;
    }
}