﻿namespace rsp6m2
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
            this.roundTrumbler_bpchs = new rsp6m2.Controls.RoundTrumbler();
            this.voltmetr1 = new rsp6m2.Controls.Voltmetr();
            this.SuspendLayout();
            // 
            // roundTrumbler_bpchs
            // 
            this.roundTrumbler_bpchs.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler_bpchs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler_bpchs.BackgroundImage")));
            this.roundTrumbler_bpchs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundTrumbler_bpchs.CurrentIndex = 0;
            this.roundTrumbler_bpchs.Location = new System.Drawing.Point(225, 393);
            this.roundTrumbler_bpchs.Name = "roundTrumbler_bpchs";
            this.roundTrumbler_bpchs.Size = new System.Drawing.Size(94, 87);
            this.roundTrumbler_bpchs.TabIndex = 1;
            this.roundTrumbler_bpchs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roundTrumbler1_MouseClick);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(177, 180);
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
            this.Controls.Add(this.roundTrumbler_bpchs);
            this.DoubleBuffered = true;
            this.Name = "bpchs";
            this.Text = "bpchs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bpchs_FormClosing);
            this.Controls.SetChildIndex(this.roundTrumbler_bpchs, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundTrumbler roundTrumbler_bpchs;
        private Controls.Voltmetr voltmetr1;
    }
}