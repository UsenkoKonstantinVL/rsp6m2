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
            this.bi45 = new rsp6m2.Controls.Light();
            this.light2 = new rsp6m2.Controls.Light();
            this.light3 = new rsp6m2.Controls.Light();
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
            this.PupPanel.BackgroundImage = global::rsp6m2.Properties.Resources.Pup;
            this.PupPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PupPanel.Controls.Add(this.light3);
            this.PupPanel.Controls.Add(this.light2);
            this.PupPanel.Controls.Add(this.bi45);
            this.PupPanel.Location = new System.Drawing.Point(365, 12);
            this.PupPanel.Name = "PupPanel";
            this.PupPanel.Size = new System.Drawing.Size(154, 346);
            this.PupPanel.TabIndex = 1;
            // 
            // bi45
            // 
            this.bi45.BackColor = System.Drawing.Color.Transparent;
            this.bi45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bi45.BackgroundImage")));
            this.bi45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bi45.Location = new System.Drawing.Point(21, 0);
            this.bi45.Name = "bi45";
            this.bi45.Size = new System.Drawing.Size(38, 36);
            this.bi45.TabIndex = 0;
            // 
            // light2
            // 
            this.light2.BackColor = System.Drawing.Color.Transparent;
            this.light2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light2.BackgroundImage")));
            this.light2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light2.Location = new System.Drawing.Point(65, 0);
            this.light2.Name = "light2";
            this.light2.Size = new System.Drawing.Size(38, 36);
            this.light2.TabIndex = 1;
            // 
            // light3
            // 
            this.light3.BackColor = System.Drawing.Color.Transparent;
            this.light3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light3.BackgroundImage")));
            this.light3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light3.Location = new System.Drawing.Point(109, 0);
            this.light3.Name = "light3";
            this.light3.Size = new System.Drawing.Size(38, 36);
            this.light3.TabIndex = 2;
            // 
            // UnderPRLBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rsp6m2.Properties.Resources.UnderPRLblocks;
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
        private rsp6m2.Controls.Light light3;
        private rsp6m2.Controls.Light light2;
        private rsp6m2.Controls.Light bi45;
    }
}