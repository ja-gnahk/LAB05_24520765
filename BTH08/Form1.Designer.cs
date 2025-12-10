namespace BTH08
{
    partial class Form1
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
            this.analogClock1 = new BTH08.AnalogClock();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.BackColor = System.Drawing.Color.Black;
            this.analogClock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analogClock1.Location = new System.Drawing.Point(0, 0);
            this.analogClock1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.Size = new System.Drawing.Size(800, 450);
            this.analogClock1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Analog Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private BTH08.AnalogClock analogClock1;
    }
}

