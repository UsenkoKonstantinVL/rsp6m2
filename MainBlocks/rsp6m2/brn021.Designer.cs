namespace rsp6m2
{
    partial class brn021
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brn021));
            this.voltmetr1 = new rsp6m2.Controls.Voltmetr();
            this.SuspendLayout();
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 250;
            this.voltmetr1.Location = new System.Drawing.Point(203, 182);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 50D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 100;
            this.voltmetr1.Size = new System.Drawing.Size(160, 160);
            this.voltmetr1.TabIndex = 0;
            // 
            // brn021
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.brn021;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 744);
            this.Controls.Add(this.voltmetr1);
            this.Name = "brn021";
            this.Text = "brn021";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Voltmetr voltmetr1;
    }
}