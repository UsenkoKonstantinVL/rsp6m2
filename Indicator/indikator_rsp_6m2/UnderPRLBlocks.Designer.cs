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
            this.PupBlock = new System.Windows.Forms.Button();
            this.PupPanel = new System.Windows.Forms.Panel();
            this.boimTumbler = new indikator_rsp_6m2.tumbler();
            this.buoTumbler = new indikator_rsp_6m2.tumbler();
            this.bi45Tumbler = new indikator_rsp_6m2.tumbler();
            this.PupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PupBlock
            // 
            this.PupBlock.BackColor = System.Drawing.Color.Transparent;
            this.PupBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PupBlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PupBlock.Location = new System.Drawing.Point(453, 0);
            this.PupBlock.Name = "PupBlock";
            this.PupBlock.Size = new System.Drawing.Size(130, 370);
            this.PupBlock.TabIndex = 0;
            this.PupBlock.UseVisualStyleBackColor = false;
            this.PupBlock.Click += new System.EventHandler(this.PupBlock_Click);
            // 
            // PupPanel
            // 
            this.PupPanel.BackgroundImage = global::indikator_rsp_6m2.Properties.Resources.Pup;
            this.PupPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PupPanel.Controls.Add(this.boimTumbler);
            this.PupPanel.Controls.Add(this.buoTumbler);
            this.PupPanel.Controls.Add(this.bi45Tumbler);
            this.PupPanel.Location = new System.Drawing.Point(365, 12);
            this.PupPanel.Name = "PupPanel";
            this.PupPanel.Size = new System.Drawing.Size(154, 346);
            this.PupPanel.TabIndex = 1;
            // 
            // boimTumbler
            // 
            this.boimTumbler.BackColor = System.Drawing.Color.Transparent;
            this.boimTumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boimTumbler.BackgroundImage")));
            this.boimTumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boimTumbler.isSided = false;
            this.boimTumbler.Location = new System.Drawing.Point(103, 60);
            this.boimTumbler.Name = "boimTumbler";
            this.boimTumbler.Set_Skin = 1;
            this.boimTumbler.Size = new System.Drawing.Size(37, 33);
            this.boimTumbler.State = false;
            this.boimTumbler.TabIndex = 2;
            // 
            // buoTumbler
            // 
            this.buoTumbler.BackColor = System.Drawing.Color.Transparent;
            this.buoTumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buoTumbler.BackgroundImage")));
            this.buoTumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buoTumbler.isSided = false;
            this.buoTumbler.Location = new System.Drawing.Point(60, 60);
            this.buoTumbler.Name = "buoTumbler";
            this.buoTumbler.Set_Skin = 1;
            this.buoTumbler.Size = new System.Drawing.Size(37, 33);
            this.buoTumbler.State = false;
            this.buoTumbler.TabIndex = 1;
            // 
            // bi45Tumbler
            // 
            this.bi45Tumbler.BackColor = System.Drawing.Color.Transparent;
            this.bi45Tumbler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bi45Tumbler.BackgroundImage")));
            this.bi45Tumbler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bi45Tumbler.isSided = false;
            this.bi45Tumbler.Location = new System.Drawing.Point(17, 60);
            this.bi45Tumbler.Name = "bi45Tumbler";
            this.bi45Tumbler.Set_Skin = 1;
            this.bi45Tumbler.Size = new System.Drawing.Size(37, 33);
            this.bi45Tumbler.State = false;
            this.bi45Tumbler.TabIndex = 0;
            // 
            // UnderPRLBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::indikator_rsp_6m2.Properties.Resources.UnderPRLblocks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 370);
            this.Controls.Add(this.PupPanel);
            this.Controls.Add(this.PupBlock);
            this.DoubleBuffered = true;
            this.Name = "UnderPRLBlocks";
            this.Text = "UnderPRLBlocks";
            this.PupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PupBlock;
        private System.Windows.Forms.Panel PupPanel;
        private tumbler boimTumbler;
        private tumbler buoTumbler;
        private tumbler bi45Tumbler;
    }
}