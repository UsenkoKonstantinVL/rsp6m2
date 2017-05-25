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
            this.panel1 = new System.Windows.Forms.Panel();
            this.prlblock_bi45light = new rsp6m2.Controls.Light();
            this.prlblock_buolight = new rsp6m2.Controls.Light();
            this.prlblock_boilight = new rsp6m2.Controls.Light();
            this.prlblock_bi45 = new rsp6m2.Controls.Tumbler2();
            this.prlblock_buo = new rsp6m2.Controls.Tumbler2();
            this.prlblock_boi = new rsp6m2.Controls.Tumbler2();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 358);
            this.panel1.TabIndex = 6;
            // 
            // prlblock_bi45light
            // 
            this.prlblock_bi45light.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_bi45light.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_bi45light.BackgroundImage")));
            this.prlblock_bi45light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_bi45light.Location = new System.Drawing.Point(453, 0);
            this.prlblock_bi45light.Name = "prlblock_bi45light";
            this.prlblock_bi45light.Size = new System.Drawing.Size(38, 36);
            this.prlblock_bi45light.TabIndex = 0;
            // 
            // prlblock_buolight
            // 
            this.prlblock_buolight.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_buolight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_buolight.BackgroundImage")));
            this.prlblock_buolight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_buolight.Location = new System.Drawing.Point(496, 0);
            this.prlblock_buolight.Name = "prlblock_buolight";
            this.prlblock_buolight.Size = new System.Drawing.Size(38, 36);
            this.prlblock_buolight.TabIndex = 1;
            // 
            // prlblock_boilight
            // 
            this.prlblock_boilight.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_boilight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_boilight.BackgroundImage")));
            this.prlblock_boilight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_boilight.Location = new System.Drawing.Point(540, 0);
            this.prlblock_boilight.Name = "prlblock_boilight";
            this.prlblock_boilight.Size = new System.Drawing.Size(38, 36);
            this.prlblock_boilight.TabIndex = 2;
            // 
            // prlblock_bi45
            // 
            this.prlblock_bi45.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_bi45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_bi45.BackgroundImage")));
            this.prlblock_bi45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_bi45.Location = new System.Drawing.Point(464, 57);
            this.prlblock_bi45.Name = "prlblock_bi45";
            this.prlblock_bi45.Size = new System.Drawing.Size(27, 42);
            this.prlblock_bi45.TabIndex = 3;
            this.prlblock_bi45.Click += new System.EventHandler(this.prlblock_bi45_Click);
            // 
            // prlblock_buo
            // 
            this.prlblock_buo.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_buo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_buo.BackgroundImage")));
            this.prlblock_buo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_buo.Location = new System.Drawing.Point(507, 57);
            this.prlblock_buo.Name = "prlblock_buo";
            this.prlblock_buo.Size = new System.Drawing.Size(27, 42);
            this.prlblock_buo.TabIndex = 4;
            this.prlblock_buo.Click += new System.EventHandler(this.prlblock_bi45_Click);
            // 
            // prlblock_boi
            // 
            this.prlblock_boi.BackColor = System.Drawing.Color.Transparent;
            this.prlblock_boi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prlblock_boi.BackgroundImage")));
            this.prlblock_boi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prlblock_boi.Location = new System.Drawing.Point(540, 57);
            this.prlblock_boi.Name = "prlblock_boi";
            this.prlblock_boi.Size = new System.Drawing.Size(27, 42);
            this.prlblock_boi.TabIndex = 5;
            this.prlblock_boi.Load += new System.EventHandler(this.UnderPRLBlocks_Load);
            this.prlblock_boi.Click += new System.EventHandler(this.prlblock_bi45_Click);
            // 
            // UnderPRLBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.UnderPRLblocks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 370);
            this.Controls.Add(this.prlblock_bi45light);
            this.Controls.Add(this.prlblock_buolight);
            this.Controls.Add(this.prlblock_boilight);
            this.Controls.Add(this.prlblock_bi45);
            this.Controls.Add(this.prlblock_buo);
            this.Controls.Add(this.prlblock_boi);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UnderPRLBlocks";
            this.Text = "Блоки под столечницей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnderPRLBlocks_FormClosing);
            this.Load += new System.EventHandler(this.UnderPRLBlocks_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.prlblock_boi, 0);
            this.Controls.SetChildIndex(this.prlblock_buo, 0);
            this.Controls.SetChildIndex(this.prlblock_bi45, 0);
            this.Controls.SetChildIndex(this.prlblock_boilight, 0);
            this.Controls.SetChildIndex(this.prlblock_buolight, 0);
            this.Controls.SetChildIndex(this.prlblock_bi45light, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private rsp6m2.Controls.Light prlblock_boilight;
        private rsp6m2.Controls.Light prlblock_buolight;
        private rsp6m2.Controls.Light prlblock_bi45light;
        private rsp6m2.Controls.Tumbler2 prlblock_bi45;
        private rsp6m2.Controls.Tumbler2 prlblock_boi;
        private rsp6m2.Controls.Tumbler2 prlblock_buo;
        private System.Windows.Forms.Panel panel1;
    }
}