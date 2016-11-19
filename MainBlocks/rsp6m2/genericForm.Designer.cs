namespace rsp6m2
{
    partial class genericForm
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
            this.SuspendLayout();
            // 
            // genericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 498);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "genericForm";
            this.Text = "genericForm";
            this.Activated += new System.EventHandler(this.genericForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.genericForm_FormClosing);
            this.Load += new System.EventHandler(this.genericForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion


    }
}