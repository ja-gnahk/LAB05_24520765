namespace BTH10
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbLineJoin = new System.Windows.Forms.ComboBox();
            this.cmbDashCap = new System.Windows.Forms.ComboBox();
            this.cmbStartCap = new System.Windows.Forms.ComboBox();
            this.cmbEndCap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCanvas.Location = new System.Drawing.Point(337, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(403, 395);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Location = new System.Drawing.Point(140, 26);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(158, 24);
            this.cmbDashStyle.TabIndex = 1;
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(140, 80);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(158, 24);
            this.cmbWidth.TabIndex = 2;
            // 
            // cmbLineJoin
            // 
            this.cmbLineJoin.FormattingEnabled = true;
            this.cmbLineJoin.Location = new System.Drawing.Point(140, 133);
            this.cmbLineJoin.Name = "cmbLineJoin";
            this.cmbLineJoin.Size = new System.Drawing.Size(158, 24);
            this.cmbLineJoin.TabIndex = 3;
            // 
            // cmbDashCap
            // 
            this.cmbDashCap.FormattingEnabled = true;
            this.cmbDashCap.Location = new System.Drawing.Point(140, 189);
            this.cmbDashCap.Name = "cmbDashCap";
            this.cmbDashCap.Size = new System.Drawing.Size(158, 24);
            this.cmbDashCap.TabIndex = 4;
            // 
            // cmbStartCap
            // 
            this.cmbStartCap.FormattingEnabled = true;
            this.cmbStartCap.Location = new System.Drawing.Point(140, 248);
            this.cmbStartCap.Name = "cmbStartCap";
            this.cmbStartCap.Size = new System.Drawing.Size(158, 24);
            this.cmbStartCap.TabIndex = 5;
            // 
            // cmbEndCap
            // 
            this.cmbEndCap.FormattingEnabled = true;
            this.cmbEndCap.Location = new System.Drawing.Point(140, 303);
            this.cmbEndCap.Name = "cmbEndCap";
            this.cmbEndCap.Size = new System.Drawing.Size(158, 24);
            this.cmbEndCap.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dash Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line Join:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dash Cap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Cap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Cap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(740, 395);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEndCap);
            this.Controls.Add(this.cmbStartCap);
            this.Controls.Add(this.cmbDashCap);
            this.Controls.Add(this.cmbLineJoin);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.cmbDashStyle);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbLineJoin;
        private System.Windows.Forms.ComboBox cmbDashCap;
        private System.Windows.Forms.ComboBox cmbStartCap;
        private System.Windows.Forms.ComboBox cmbEndCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

