namespace TextboxCopyApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button btnShow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox A
            this.textBoxA.Location = new System.Drawing.Point(30, 30);
            this.textBoxA.Name = "A";
            this.textBoxA.Size = new System.Drawing.Size(240, 22);

            // textBox B
            this.textBoxB.Location = new System.Drawing.Point(30, 90);
            this.textBoxB.Name = "B";
            this.textBoxB.Size = new System.Drawing.Size(240, 22);

            // btnShow
            this.btnShow.Location = new System.Drawing.Point(100, 60);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 25);
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}