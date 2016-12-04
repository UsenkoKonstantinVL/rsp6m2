namespace indikator_rsp_6m2
{
    partial class UnderPRLBlocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnderPRLBlocks));
            this.bi45light = new rsp6m2.Controls.Light();
            this.buoLight = new rsp6m2.Controls.Light();
            this.boimLight = new rsp6m2.Controls.Light();
            this.bi45Tumbler = new rsp6m2.Controls.Tumbler2();
            this.buoTumbler = new rsp6m2.Controls.Tumbler2();
            this.boimTumbler = new rsp6m2.Controls.Tumbler2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bi45light
            // 
            this.bi45light.BackColor = System.Drawing.Color.Transparent;
            this.bi45light.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bi45light.BackgroundImage")));
            this.bi45light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bi45light.Location = new System.Drawing.Point(453, 0);
            this.bi45light.Name = "bi45light";
            this.bi45light.Size = new System.Drawing.Size(38, 36);
            this.bi45light.TabIndex = 0;
            // 
            // buoLight
            // 
            this.buoLight.BackColor = System.Drawing.Color.Transparent;
            this.buoLight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buoLight.BackgroundImage")));
            this.buoLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buoLight.Location = new System.Drawing.Point(496, 0);
            this.buoLight.Name = "buoLight";
            this.buoLight.Size = new System.Drawing.Size(38, 36);
            this.buoLight.TabIndex = 1;
            // 
            // boimLight
            // 
            this.boimLight.BackColor = System.Drawing.Color.Transparent;
            this.boimLight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boimLight.BackgroundImage")));
            this.boimLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boimLight.Location = new System.Drawing.Point(540, 0);
            this.boimLight.Name = "boimLight";
            this.boimLight.Size = new System.Drawing.Size(38, 36);
            this.boimLight.TabIndex = 2;
            // 
            // bi45Tumbler
            // 
            this.bi45Tumbler.BackColor = System.Drawing.Color.Transparent;
            this.bi45Tumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bi45Tumbler.BackgroundImage")));
            this.bi45Tumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bi45Tumbler.Location = new System.Drawing.Point(464, 57);
            this.bi45Tumbler.Name = "bi45Tumbler";
            this.bi45Tumbler.Size = new System.Drawing.Size(27, 42);
            this.bi45Tumbler.TabIndex = 3;
            // 
            // buoTumbler
            // 
            this.buoTumbler.BackColor = System.Drawing.Color.Transparent;
            this.buoTumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buoTumbler.BackgroundImage")));
            this.buoTumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buoTumbler.Location = new System.Drawing.Point(507, 57);
            this.buoTumbler.Name = "buoTumbler";
            this.buoTumbler.Size = new System.Drawing.Size(27, 42);
            this.buoTumbler.TabIndex = 4;
            // 
            // boimTumbler
            // 
            this.boimTumbler.BackColor = System.Drawing.Color.Transparent;
            this.boimTumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boimTumbler.BackgroundImage")));
            this.boimTumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boimTumbler.Location = new System.Drawing.Point(540, 57);
            this.boimTumbler.Name = "boimTumbler";
            this.boimTumbler.Size = new System.Drawing.Size(27, 42);
            this.boimTumbler.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 358);
            this.panel1.TabIndex = 6;
            // 
            // UnderPRLBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.UnderPRLblocks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 370);
            this.Controls.Add(this.bi45light);
            this.Controls.Add(this.buoLight);
            this.Controls.Add(this.boimLight);
            this.Controls.Add(this.bi45Tumbler);
            this.Controls.Add(this.buoTumbler);
            this.Controls.Add(this.boimTumbler);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UnderPRLBlocks";
            this.Text = "UnderPRLBlocks";
            this.Load += new System.EventHandler(this.UnderPRLBlocks_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private rsp6m2.Controls.Light boimLight;
        private rsp6m2.Controls.Light buoLight;
        private rsp6m2.Controls.Light bi45light;
        private rsp6m2.Controls.Tumbler2 bi45Tumbler;
        private rsp6m2.Controls.Tumbler2 boimTumbler;
        private rsp6m2.Controls.Tumbler2 buoTumbler;
        private System.Windows.Forms.Panel panel1;
    }
}