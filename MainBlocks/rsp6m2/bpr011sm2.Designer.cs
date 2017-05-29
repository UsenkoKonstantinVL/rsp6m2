namespace rsp6m2
{
    partial class bpr011sm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bpr011sm2));
            this.voltmetr1 = new rsp6m2.Controls.Voltmetr();
            this.roundTrumbler1 = new rsp6m2.Controls.RoundTrumbler();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yellowElement1 = new rsp6m2.Controls.YellowElement();
            this.greenElement1 = new rsp6m2.Controls.GreenElement();
            this.SuspendLayout();
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(166, 337);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 10D;
            this.voltmetr1.Set_Center_str = "mkA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(185, 172);
            this.voltmetr1.TabIndex = 1;
            // 
            // roundTrumbler1
            // 
            this.roundTrumbler1.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler1.BackgroundImage")));
            this.roundTrumbler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundTrumbler1.CurrentIndex = 0;
            this.roundTrumbler1.Location = new System.Drawing.Point(220, 535);
            this.roundTrumbler1.Name = "roundTrumbler1";
            this.roundTrumbler1.Size = new System.Drawing.Size(94, 87);
            this.roundTrumbler1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ГОТОВ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "РАБОТА";
            // 
            // yellowElement1
            // 
            this.yellowElement1.BackColor = System.Drawing.Color.LightYellow;
            this.yellowElement1.IsLighting = false;
            this.yellowElement1.Location = new System.Drawing.Point(229, 156);
            this.yellowElement1.Name = "yellowElement1";
            this.yellowElement1.Size = new System.Drawing.Size(66, 32);
            this.yellowElement1.TabIndex = 8;
            // 
            // greenElement1
            // 
            this.greenElement1.BackColor = System.Drawing.Color.LightGreen;
            this.greenElement1.IlLighting = false;
            this.greenElement1.Location = new System.Drawing.Point(229, 106);
            this.greenElement1.Name = "greenElement1";
            this.greenElement1.Size = new System.Drawing.Size(66, 32);
            this.greenElement1.TabIndex = 7;
            this.greenElement1.Load += new System.EventHandler(this.greenElement1_Load);
            // 
            // bpr011sm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.bpr011sm2Ex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowElement1);
            this.Controls.Add(this.greenElement1);
            this.Controls.Add(this.roundTrumbler1);
            this.Controls.Add(this.voltmetr1);
            this.DoubleBuffered = true;
            this.Name = "bpr011sm2";
            this.Text = "bpr011sm2";
            this.Load += new System.EventHandler(this.bpr011sm2_Load);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.roundTrumbler1, 0);
            this.Controls.SetChildIndex(this.greenElement1, 0);
            this.Controls.SetChildIndex(this.yellowElement1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Voltmetr voltmetr1;
        private Controls.RoundTrumbler roundTrumbler1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.YellowElement yellowElement1;
        private Controls.GreenElement greenElement1;
    }
}