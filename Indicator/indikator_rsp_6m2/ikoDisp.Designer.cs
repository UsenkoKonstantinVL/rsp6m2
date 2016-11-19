namespace iko_Disp
{
    partial class ikoDisp
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ikoDisp));
            this.START = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ikoPasControl1 = new iko_Disp.ikoPasControl();
            this.ikO_control1 = new iko_Disp.ikoDispControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(452, 481);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(489, 22);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ikoPasControl1
            // 
            this.ikoPasControl1.BackColor = System.Drawing.Color.Transparent;
            this.ikoPasControl1.Location = new System.Drawing.Point(614, -8);
            this.ikoPasControl1.Name = "ikoPasControl1";
            this.ikoPasControl1.Size = new System.Drawing.Size(524, 516);
            this.ikoPasControl1.TabIndex = 2;
            // 
            // ikO_control1
            // 
            this.ikO_control1.BackColor = System.Drawing.Color.Transparent;
            this.ikO_control1.Location = new System.Drawing.Point(67, -42);
            this.ikO_control1.Name = "ikO_control1";
            this.ikO_control1.Size = new System.Drawing.Size(506, 487);
            this.ikO_control1.TabIndex = 0;
            // 
            // ikoDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 576);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ikoPasControl1);
            this.Controls.Add(this.START);
            this.Controls.Add(this.ikO_control1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ikoDisp";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ikoDisp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iko_Disp.ikoDispControl ikO_control1;
        private System.Windows.Forms.Button START;
        private ikoPasControl ikoPasControl1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

