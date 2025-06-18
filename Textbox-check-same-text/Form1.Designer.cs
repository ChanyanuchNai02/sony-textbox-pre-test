namespace TextboxCheckSameTextApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // textBoxA
            this.textBoxA.Location = new System.Drawing.Point(30, 30);
            this.textBoxA.Name = "A";
            this.textBoxA.Size = new System.Drawing.Size(240, 22);

            // textBoxB
            this.textBoxB.Location = new System.Drawing.Point(30, 90);
            this.textBoxB.Name = "B";
            this.textBoxB.Size = new System.Drawing.Size(240, 22);

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(100, 60);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 25);
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // Result
            this.lblResult.Location = new System.Drawing.Point(300, 30);
            this.lblResult.Name = "Result";
            this.lblResult.Size = new System.Drawing.Size(200, 90);
            this.lblResult.Text = "";
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.BackColor = System.Drawing.Color.LightBlue;
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Name = "Form1";
            this.Text = "Form1";

            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            // Update Form Size and Add Controls
            this.ClientSize = new System.Drawing.Size(550, 180);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}