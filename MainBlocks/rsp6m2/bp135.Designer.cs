namespace rsp6m2
{
    partial class bp135
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bp135));
            this.roundTumbler1 = new rsp6m2.Controls.RoundTrumbler();
            this.bp135Voltmetr = new rsp6m2.Controls.Voltmetr();
            this.SuspendLayout();
            // 
            // roundTumbler1
            // 
            this.roundTumbler1.BackColor = System.Drawing.Color.Transparent;
            this.roundTumbler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTumbler1.BackgroundImage")));
            this.roundTumbler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundTumbler1.CurrentIndex = 0;
            this.roundTumbler1.Location = new System.Drawing.Point(234, 317);
            this.roundTumbler1.Name = "roundTumbler1";
            this.roundTumbler1.Size = new System.Drawing.Size(52, 85);
            this.roundTumbler1.TabIndex = 0;
            // 
            // bp135Voltmetr
            // 
            this.bp135Voltmetr.BackColor = System.Drawing.Color.Transparent;
            this.bp135Voltmetr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bp135Voltmetr.BackgroundImage")));
            this.bp135Voltmetr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bp135Voltmetr.current_Value = 0;
            this.bp135Voltmetr.Location = new System.Drawing.Point(177, 117);
            this.bp135Voltmetr.Name = "bp135Voltmetr";
            this.bp135Voltmetr.Set_Bar_min = 0;
            this.bp135Voltmetr.Set_Bar_N_bolt = 10;
            this.bp135Voltmetr.Set_Bar_N_not_bolt = 50;
            this.bp135Voltmetr.Set_Bar_N_tzhifra = 10;
            this.bp135Voltmetr.Set_Bar_step = 10D;
            this.bp135Voltmetr.Set_Center_str = "V";
            this.bp135Voltmetr.Set_Value = 0;
            this.bp135Voltmetr.Size = new System.Drawing.Size(160, 160);
            this.bp135Voltmetr.TabIndex = 1;
            // 
            // bp135
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 744);
            this.Controls.Add(this.bp135Voltmetr);
            this.Controls.Add(this.roundTumbler1);
            this.DoubleBuffered = true;
            this.Name = "bp135";
            this.Text = "bp135";
            this.Load += new System.EventHandler(this.bp135_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundTrumbler roundTumbler1;
        private Controls.Voltmetr bp135Voltmetr;
    }
}