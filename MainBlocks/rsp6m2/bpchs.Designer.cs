namespace rsp6m2
{
    partial class bpchs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bpchs));
            this.roundTrumbler1 = new rsp6m2.Controls.RoundTrumbler();
            this.voltmetr1 = new rsp6m2.Controls.Voltmetr();
            this.SuspendLayout();
            // 
            // roundTrumbler1
            // 
            this.roundTrumbler1.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler1.BackgroundImage")));
            this.roundTrumbler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundTrumbler1.CurrentIndex = 0;
            this.roundTrumbler1.Location = new System.Drawing.Point(225, 393);
            this.roundTrumbler1.Name = "roundTrumbler1";
            this.roundTrumbler1.Size = new System.Drawing.Size(94, 87);
            this.roundTrumbler1.TabIndex = 1;
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(169, 181);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 10D;
            this.voltmetr1.Set_Center_str = "mkA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(173, 168);
            this.voltmetr1.TabIndex = 2;
            // 
            // bpchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.bpchsEx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 744);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.roundTrumbler1);
            this.DoubleBuffered = true;
            this.Name = "bpchs";
            this.Text = "bpchs";
            this.Controls.SetChildIndex(this.roundTrumbler1, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundTrumbler roundTrumbler1;
        private Controls.Voltmetr voltmetr1;
    }
}