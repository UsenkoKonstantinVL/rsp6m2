namespace rsp6m2
{
    partial class prlPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prlPower));
            this.roundTrumbler1 = new rsp6m2.Controls.RoundTrumbler();
            this.roundTrumbler2 = new rsp6m2.Controls.RoundTrumbler();
            this.tumbler11 = new rsp6m2.Controls.Tumbler1();
            this.tumbler12 = new rsp6m2.Controls.Tumbler1();
            this.tumbler21 = new rsp6m2.Controls.Tumbler2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tumbler23 = new rsp6m2.Controls.Tumbler2();
            this.tumbler22 = new rsp6m2.Controls.Tumbler2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundTrumbler1
            // 
            this.roundTrumbler1.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler1.BackgroundImage")));
            this.roundTrumbler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundTrumbler1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundTrumbler1.CurrentIndex = 0;
            this.roundTrumbler1.Location = new System.Drawing.Point(240, 110);
            this.roundTrumbler1.Name = "roundTrumbler1";
            this.roundTrumbler1.Size = new System.Drawing.Size(145, 74);
            this.roundTrumbler1.TabIndex = 1;
            this.roundTrumbler1.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // roundTrumbler2
            // 
            this.roundTrumbler2.BackColor = System.Drawing.Color.Transparent;
            this.roundTrumbler2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundTrumbler2.BackgroundImage")));
            this.roundTrumbler2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundTrumbler2.CurrentIndex = 0;
            this.roundTrumbler2.Location = new System.Drawing.Point(416, 111);
            this.roundTrumbler2.Name = "roundTrumbler2";
            this.roundTrumbler2.Size = new System.Drawing.Size(94, 74);
            this.roundTrumbler2.TabIndex = 2;
            this.roundTrumbler2.Load += new System.EventHandler(this.roundTrumbler2_Load);
            this.roundTrumbler2.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // tumbler11
            // 
            this.tumbler11.BackColor = System.Drawing.Color.Transparent;
            this.tumbler11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler11.BackgroundImage")));
            this.tumbler11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tumbler11.Location = new System.Drawing.Point(32, 110);
            this.tumbler11.Name = "tumbler11";
            this.tumbler11.Size = new System.Drawing.Size(35, 73);
            this.tumbler11.TabIndex = 3;
            this.tumbler11.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // tumbler12
            // 
            this.tumbler12.BackColor = System.Drawing.Color.Transparent;
            this.tumbler12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler12.BackgroundImage")));
            this.tumbler12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tumbler12.Location = new System.Drawing.Point(95, 110);
            this.tumbler12.Name = "tumbler12";
            this.tumbler12.Size = new System.Drawing.Size(35, 73);
            this.tumbler12.TabIndex = 4;
            this.tumbler12.Load += new System.EventHandler(this.tumbler12_Load);
            this.tumbler12.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // tumbler21
            // 
            this.tumbler21.BackColor = System.Drawing.Color.Transparent;
            this.tumbler21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler21.BackgroundImage")));
            this.tumbler21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tumbler21.Location = new System.Drawing.Point(32, 3);
            this.tumbler21.Name = "tumbler21";
            this.tumbler21.Size = new System.Drawing.Size(27, 42);
            this.tumbler21.TabIndex = 5;
            this.tumbler21.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tumbler23);
            this.panel3.Controls.Add(this.tumbler22);
            this.panel3.Controls.Add(this.tumbler21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 78);
            this.panel3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "1";
            // 
            // tumbler23
            // 
            this.tumbler23.BackColor = System.Drawing.Color.Transparent;
            this.tumbler23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler23.BackgroundImage")));
            this.tumbler23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tumbler23.Location = new System.Drawing.Point(158, 3);
            this.tumbler23.Name = "tumbler23";
            this.tumbler23.Size = new System.Drawing.Size(27, 42);
            this.tumbler23.TabIndex = 8;
            this.tumbler23.Load += new System.EventHandler(this.tumbler23_Load);
            this.tumbler23.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // tumbler22
            // 
            this.tumbler22.BackColor = System.Drawing.Color.Transparent;
            this.tumbler22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler22.BackgroundImage")));
            this.tumbler22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tumbler22.Location = new System.Drawing.Point(95, 3);
            this.tumbler22.Name = "tumbler22";
            this.tumbler22.Size = new System.Drawing.Size(27, 42);
            this.tumbler22.TabIndex = 7;
            this.tumbler22.Load += new System.EventHandler(this.tumbler22_Load);
            this.tumbler22.Click += new System.EventHandler(this.tumbler11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Положение1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Положение2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Положение3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Тумблер1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Тумблер2";
            // 
            // prlPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 364);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tumbler12);
            this.Controls.Add(this.tumbler11);
            this.Controls.Add(this.roundTrumbler2);
            this.Controls.Add(this.roundTrumbler1);
            this.Name = "prlPower";
            this.Text = "prlPower";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.prlPower_FormClosing);
            this.Load += new System.EventHandler(this.prlPower_Load);
            this.Controls.SetChildIndex(this.roundTrumbler1, 0);
            this.Controls.SetChildIndex(this.roundTrumbler2, 0);
            this.Controls.SetChildIndex(this.tumbler11, 0);
            this.Controls.SetChildIndex(this.tumbler12, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundTrumbler roundTrumbler1;
        private Controls.RoundTrumbler roundTrumbler2;
        private Controls.Tumbler1 tumbler11;
        private Controls.Tumbler1 tumbler12;
        private Controls.Tumbler2 tumbler21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Controls.Tumbler2 tumbler23;
        private Controls.Tumbler2 tumbler22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}