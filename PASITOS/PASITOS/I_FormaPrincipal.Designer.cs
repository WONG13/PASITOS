namespace PASITOS
{
    partial class I_FormaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_FormaPrincipal));
            this.SC1 = new System.Windows.Forms.SplitContainer();
            this.SC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SC1
            // 
            this.SC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC1.Location = new System.Drawing.Point(0, 0);
            this.SC1.Name = "SC1";
            this.SC1.Size = new System.Drawing.Size(884, 561);
            this.SC1.SplitterDistance = 178;
            this.SC1.TabIndex = 0;
            // 
            // I_FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.SC1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "I_FormaPrincipal";
            this.Text = "PASITOS";
            this.Load += new System.EventHandler(this.I_FormaPrincipal_Load);
            this.SC1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SC1;
    }
}

