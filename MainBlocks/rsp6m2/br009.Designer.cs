namespace rsp6m2
{
    partial class br009
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(br009));
            this.br009_tumbler_1 = new rsp6m2.Controls.Tumbler2();
            this.label1 = new System.Windows.Forms.Label();
            this.br009_tumbler_2 = new rsp6m2.Controls.tumbler3();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // br009_tumbler_1
            // 
            this.br009_tumbler_1.BackColor = System.Drawing.Color.Transparent;
            this.br009_tumbler_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("br009_tumbler_1.BackgroundImage")));
            this.br009_tumbler_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.br009_tumbler_1.Location = new System.Drawing.Point(256, 581);
            this.br009_tumbler_1.Name = "br009_tumbler_1";
            this.br009_tumbler_1.Size = new System.Drawing.Size(36, 38);
            this.br009_tumbler_1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "РРУ";
            // 
            // br009_tumbler_2
            // 
            this.br009_tumbler_2.BackColor = System.Drawing.Color.Transparent;
            this.br009_tumbler_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("br009_tumbler_2.BackgroundImage")));
            this.br009_tumbler_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.br009_tumbler_2.Location = new System.Drawing.Point(435, 343);
            this.br009_tumbler_2.Name = "br009_tumbler_2";
            this.br009_tumbler_2.Position = 1;
            this.br009_tumbler_2.Size = new System.Drawing.Size(35, 35);
            this.br009_tumbler_2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Местный";
            // 
            // br009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.br009_tumbler_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.br009_tumbler_1);
            this.DoubleBuffered = true;
            this.Name = "br009";
            this.Text = "БР-009";
            this.Controls.SetChildIndex(this.br009_tumbler_1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.br009_tumbler_2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Tumbler2 br009_tumbler_1;
        private System.Windows.Forms.Label label1;
        private Controls.tumbler3 br009_tumbler_2;
        private System.Windows.Forms.Label label2;
    }
}